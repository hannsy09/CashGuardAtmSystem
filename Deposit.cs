using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Cash_Guard_System
{
    public partial class Deposit : Form
    {
        private MySqlConnection connection;
        private string connectionString = "Server=127.0.0.1;Database=account;Uid=root;Pwd=;";
        private string accountNumber;
        private decimal currentBalance;
        private ToolTip toolTip;


        public Deposit(string accountNumber)
        {
            InitializeComponent();
            this.accountNumber = accountNumber;
            connection = new MySqlConnection(connectionString);
            toolTip = new ToolTip();

            txtAmount.KeyPress += new KeyPressEventHandler(AmountTextBox_KeyPress);
            txtConfirmAmount.KeyPress += new KeyPressEventHandler(AmountTextBox_KeyPress);

            toolTip.SetToolTip(txtAmount, "Amount cannot be empty.");
            toolTip.SetToolTip(txtConfirmAmount, "Confirm Amount cannot be empty.");

            
            this.KeyPreview = true;
           
            this.KeyDown += new KeyEventHandler(Form_KeyDown);

            
            LoadCurrentBalance();
        }

        private void LoadCurrentBalance()
        {
            try
            {
                connection.Open();

              
                string querySelect = "SELECT `Balance` FROM `signup` WHERE `Account Number` = @AccountNumber";
                MySqlCommand commandSelect = new MySqlCommand(querySelect, connection);
                commandSelect.Parameters.AddWithValue("@AccountNumber", accountNumber);
                object result = commandSelect.ExecuteScalar();

                if (result != null && decimal.TryParse(result.ToString(), out currentBalance))
                {
                    
                    AccountBalance.Text = $"Account Balance: ₱{currentBalance}";
                }
                else
                {
                    MessageBox.Show("Failed to retrieve current balance.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Database error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection != null && connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            // Validate numerical input
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtAmount.Text, "^[0-9]*$"))
            {
                MessageBox.Show("Please enter only numerical values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAmount.Text = string.Empty;
            }
        }

        private void txtConfirmAmount_TextChanged(object sender, EventArgs e)
        {
            // Validate numerical input
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtConfirmAmount.Text, "^[0-9]*$"))
            {
                MessageBox.Show("Please enter only numerical values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtConfirmAmount.Text = string.Empty;
            }
        }

        private void Depositbtn_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtAmount.Text, out decimal depositAmount))
            {
                if (txtAmount.Text != txtConfirmAmount.Text)
                {
                    MessageBox.Show("Deposit amounts do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (depositAmount < 0)
                {
                    MessageBox.Show("Deposit amount cannot be negative.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MySqlTransaction transaction = null;
                    try
                    {
                        connection.Open();
                        transaction = connection.BeginTransaction();

                        currentBalance += depositAmount;
                        string queryUpdate = "UPDATE `signup` SET `Balance` = @Balance WHERE `Account Number` = @AccountNumber";
                        MySqlCommand commandUpdate = new MySqlCommand(queryUpdate, connection);
                        commandUpdate.Parameters.AddWithValue("@Balance", currentBalance);
                        commandUpdate.Parameters.AddWithValue("@AccountNumber", accountNumber);
                        commandUpdate.Transaction = transaction;
                        int rowsAffected = commandUpdate.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            InsertTransaction("Deposit", depositAmount, transaction);

                            transaction.Commit();
                            MessageBox.Show($"Deposit of ₱{depositAmount} successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            DialogResult result = MessageBox.Show("Do you want to perform another transaction?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.No)
                            {
                                this.Close();
                                Dashboard dashboard = new Dashboard(accountNumber);
                                dashboard.Show();
                            }
                            else
                            {
                                txtAmount.Clear();
                                txtConfirmAmount.Clear();
                            }
                        }
                        else
                        {
                            transaction.Rollback();
                            MessageBox.Show("Failed to update balance.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        if (transaction != null)
                        {
                            try
                            {
                                transaction.Rollback();
                            }
                            catch (Exception rollbackEx)
                            {
                                MessageBox.Show($"Rollback failed: {rollbackEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                        MessageBox.Show($"Transaction failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        if (connection != null && connection.State == ConnectionState.Open)
                            connection.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid deposit amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InsertTransaction(string transactionType, decimal transactionAmount, MySqlTransaction transaction)
        {
            try
            {
                DateTime currentDate = DateTime.Now;
                string queryInsert = "INSERT INTO `transactiontbl` (`Account Number`, `Type`, `Amount`, `Date`) VALUES (@AccountNumber, @Type, @Amount, @Date)";
                MySqlCommand commandInsert = new MySqlCommand(queryInsert, connection);
                commandInsert.Parameters.AddWithValue("@AccountNumber", accountNumber);
                commandInsert.Parameters.AddWithValue("@Type", transactionType);
                commandInsert.Parameters.AddWithValue("@Amount", transactionAmount);
                commandInsert.Parameters.AddWithValue("@Date", currentDate);
                commandInsert.Transaction = transaction;

                int rowsAffected = commandInsert.ExecuteNonQuery();
                if (rowsAffected <= 0)
                {
                    throw new Exception("Failed to insert transaction record.");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Database error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }








        private void AmountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '\t' && e.KeyChar != '\r')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '\r')
            {
                if (sender == txtAmount)
                {
                    txtConfirmAmount.Focus();
                }
                else if (sender == txtConfirmAmount)
                {
                    Depositbtn_Click(sender, e); 
                }
            }
        }

        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
          
            if (e.KeyCode == Keys.Enter)
            {
                
                Depositbtn.PerformClick();
               
                e.SuppressKeyPress = true;
            }
        }

        private void InsertTransaction(string transactionType, decimal transactionAmount)
        {
            try
            {
                connection.Open();

               
                DateTime currentDate = DateTime.Now;

                string queryInsert = "INSERT INTO `transactiontbl` (`Account Number`, `Type`, `Amount`, `Date`) VALUES (@AccountNumber, @Type, @Amount, @Date)";
                MySqlCommand commandInsert = new MySqlCommand(queryInsert, connection);
                commandInsert.Parameters.AddWithValue("@AccountNumber", accountNumber);
                commandInsert.Parameters.AddWithValue("@Type", transactionType);
                commandInsert.Parameters.AddWithValue("@Amount", transactionAmount);
                commandInsert.Parameters.AddWithValue("@Date", currentDate);

                int rowsAffected = commandInsert.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                   
                }
                else
                {
                    
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Database error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection != null && connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        private void Deposit_Load(object sender, EventArgs e)
        {

        }
    }
}
