using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Cash_Guard_System
{
    public partial class Withdraw : Form
    {
        private MySqlConnection connection;
        private string connectionString = "Server=127.0.0.1;Database=account;Uid=root;Pwd=;";
        private string accountNumber;
        private decimal currentBalance;
        private ToolTip toolTip;

        public Withdraw(string accountNumber)
        {
            InitializeComponent();
            this.accountNumber = accountNumber;
            connection = new MySqlConnection(connectionString);
            toolTip = new ToolTip();

            txtAmount.KeyPress += new KeyPressEventHandler(AmountTextBox_KeyPress);
            txtConfirmAmount.KeyPress += new KeyPressEventHandler(AmountTextBox_KeyPress);

            toolTip.SetToolTip(txtAmount, "Amount cannot be empty.");
            toolTip.SetToolTip(txtConfirmAmount, "Confirm Amount cannot be empty.");

            // Set the form's KeyPreview property to true to handle key events at the form level
            this.KeyPreview = true;
            // Attach the KeyDown event handler for the form
            this.KeyDown += new KeyEventHandler(Form_KeyDown);

            // Load the current balance
            LoadCurrentBalance();
        }

        private void LoadCurrentBalance()
        {
            try
            {
                connection.Open();

                // Retrieve the current balance
                string querySelect = "SELECT `Balance` FROM `signup` WHERE `Account Number` = @AccountNumber";
                MySqlCommand commandSelect = new MySqlCommand(querySelect, connection);
                commandSelect.Parameters.AddWithValue("@AccountNumber", accountNumber);
                object result = commandSelect.ExecuteScalar();

                if (result != null && decimal.TryParse(result.ToString(), out currentBalance))
                {
                    // Update the AccountBalance label with the current balance
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

        private void Withdrawbtn_Click(object sender, EventArgs e)
        {
            PerformWithdrawal();
        }

        private void PerformWithdrawal()
        {
            if (decimal.TryParse(txtAmount.Text, out decimal withdrawAmount))
            {
                if (txtAmount.Text != txtConfirmAmount.Text)
                {
                    MessageBox.Show("Withdrawal amounts do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (withdrawAmount <= 0)
                {
                    MessageBox.Show("Withdrawal amount must be greater than zero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (withdrawAmount > currentBalance)
                {
                    MessageBox.Show("Insufficient balance for the withdrawal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MySqlTransaction transaction = null;
                try
                {
                    connection.Open();
                    transaction = connection.BeginTransaction();

                    currentBalance -= withdrawAmount;
                    string queryUpdate = "UPDATE `signup` SET `Balance` = @Balance WHERE `Account Number` = @AccountNumber";
                    MySqlCommand commandUpdate = new MySqlCommand(queryUpdate, connection);
                    commandUpdate.Parameters.AddWithValue("@Balance", currentBalance);
                    commandUpdate.Parameters.AddWithValue("@AccountNumber", accountNumber);
                    commandUpdate.Transaction = transaction;
                    int rowsAffected = commandUpdate.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        InsertTransaction("Withdraw", withdrawAmount, transaction);
                        transaction.Commit();

                        MessageBox.Show($"Withdrawal of ₱{withdrawAmount} successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        DialogResult result = MessageBox.Show("Do you want to perform another transaction?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.No)
                        {
                            this.Close();
                            Dashboard dashboard = new Dashboard(accountNumber); // Pass the account number as the loggedInIdentifier
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
            else
            {
                MessageBox.Show("Invalid withdrawal amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    PerformWithdrawal();
                }
            }
        }

        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Trigger the withdrawal only when the focus is on the confirm amount textbox
                if (txtConfirmAmount.Focused)
                {
                    PerformWithdrawal();
                    e.SuppressKeyPress = true;
                }
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
    }
}
