using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Guna.UI2.WinForms;

namespace Cash_Guard_System
{
    public partial class Account : Form
    {
        private MySqlConnection connection;
        private string connectionString = "Server=127.0.0.1;Database=account;Uid=root;Pwd=;";
        private string loggedInAccountNumber;
        private Dashboard dashboardForm;
        private ToolTip toolTip;

        public Account(string loggedInAccountNumber, Dashboard dashboardForm)
        {
            InitializeComponent();
            this.loggedInAccountNumber = loggedInAccountNumber;
            this.dashboardForm = dashboardForm;
        }

        private void getBalance()
        {
            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();

                string query = "SELECT `Balance` FROM `signup` WHERE `Account Number` = @AccountNumber";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@AccountNumber", loggedInAccountNumber);

                object result = command.ExecuteScalar();
                if (result != null)
                {
                    string balance = result.ToString();
                    AccountBalance.Text = "Balance: " + balance; 
                }
                else
                {
                    MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


        private void Account_Load(object sender, EventArgs e)
        {
            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();

                string query = "SELECT `First Name` FROM `signup` WHERE `Account Number` = @AccountNumber";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@AccountNumber", loggedInAccountNumber);

                object result = command.ExecuteScalar();
                if (result != null)
                {
                    string firstName = result.ToString();
                    FirstName.Text = firstName;
                }
                else
                {
                    MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

          
            getBalance();

            toolTip = new ToolTip();

            txtChangePin.KeyPress += new KeyPressEventHandler(PinTextBox_KeyPress);
            txtConfirmPin.KeyPress += new KeyPressEventHandler(PinTextBox_KeyPress);

            txtChangePin.Leave += new EventHandler(PinTextBox_Leave);
            txtConfirmPin.Leave += new EventHandler(PinTextBox_Leave);
        }

        private void PinTextBox_Leave(object sender, EventArgs e)
        {
            Control control = sender as Control;

            if (control == txtChangePin || control == txtConfirmPin)
            {
                ValidatePIN(control);
            }
        }

        
        private void PinTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            Guna2TextBox gunaTextBox = sender as Guna2TextBox;

            if (textBox != null)
            {
                
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46)
                {
                    e.Handled = true;
                }
            }
            else if (gunaTextBox != null)
            {
                
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46)
                {
                    e.Handled = true;
                }
            }
        }

        
        private void ValidatePIN(Control control)
        {
            TextBox textBox = control as TextBox;
            Guna2TextBox gunaTextBox = control as Guna2TextBox;

            if (textBox != null)
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    toolTip.Show("PIN cannot be empty.", textBox, 2000);
                    textBox.Focus();
                }
                else if (textBox.Text.Length != 4)
                {
                    toolTip.Show("PIN must be exactly 4 digits long.", textBox, 2000);
                    textBox.Focus();
                }
                else
                {
                    toolTip.Hide(textBox);
                }
            }
            else if (gunaTextBox != null)
            {
                if (string.IsNullOrWhiteSpace(gunaTextBox.Text))
                {
                    toolTip.Show("PIN cannot be empty.", gunaTextBox, 2000);
                    gunaTextBox.Focus();
                }
                else if (gunaTextBox.Text.Length != 4)
                {
                    toolTip.Show("PIN must be exactly 4 digits long.", gunaTextBox, 2000);
                    gunaTextBox.Focus();
                }
                else
                {
                    toolTip.Hide(gunaTextBox);
                }
            }
        }

        private void Confirmbtn_Click(object sender, EventArgs e)
        {
            string newPIN = txtChangePin.Text;
            string confirmNewPIN = txtConfirmPin.Text;

            if (string.IsNullOrWhiteSpace(newPIN) || string.IsNullOrWhiteSpace(confirmNewPIN))
            {
                MessageBox.Show("PIN fields cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (newPIN != confirmNewPIN)
            {
                MessageBox.Show("PINs do not match. Please re-enter.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                connection.Open();

                
                string query = "UPDATE `signup` SET `Pin` = @NewPIN WHERE `Account Number` = @AccountNumber";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@NewPIN", newPIN);
                command.Parameters.AddWithValue("@AccountNumber", loggedInAccountNumber);

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("PIN changed successfully. Please log in with your new PIN.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    
                    this.Dispose();
                    dashboardForm.Dispose();

                  
                    Login loginForm = new Login();
                    loginForm.Show();
                }
                else
                {
                    MessageBox.Show("No rows affected. PIN change failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtChangePin.UseSystemPasswordChar = !guna2CheckBox1.Checked;
            txtConfirmPin.UseSystemPasswordChar = !guna2CheckBox1.Checked;
        }
    }
}
