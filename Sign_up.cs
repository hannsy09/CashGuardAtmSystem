using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace Cash_Guard_System
{
    public partial class Sign_up : Form
    {
        private MySqlConnection connection;
        private string connectionString = "Server=127.0.0.1;Database=account;Uid=root;Pwd=;";
        private ToolTip toolTip1;

        public Sign_up()
        {
            InitializeComponent();
            connection = new MySqlConnection(connectionString);
            toolTip1 = new ToolTip();
            txtAccountNumber.Enabled = false;

            GenerateAccountNumber();

            txtFirstName.KeyPress += txtFirstName_KeyPress;
            txtLastName.KeyPress += txtLastName_KeyPress;
            txtOccupation.KeyPress += txtOccupation_KeyPress;
            txtpin.KeyPress += txtpin_KeyPress;
            txtConfirmPIN.KeyPress += txtConfirmPIN_KeyPress;
            txtPhone.KeyPress += txtPhone_KeyPress;
        }

        
        private void GenerateAccountNumber()
        {
            Random random = new Random();
            int newAccountNumber = random.Next(1000, 10000); 
            txtAccountNumber.Text = newAccountNumber.ToString(); 
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                ShowToolTip(txtFirstName, "First Name cannot be empty.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                ShowToolTip(txtLastName, "Last Name cannot be empty.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtOccupation.Text))
            {
                ShowToolTip(txtOccupation, "Occupation cannot be empty.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtpin.Text) || txtpin.Text.Length != 4)
            {
                ShowToolTip(txtpin, "PIN must be 4 digits.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtConfirmPIN.Text) || txtConfirmPIN.Text.Length != 4)
            {
                ShowToolTip(txtConfirmPIN, "Confirm PIN must be 4 digits.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPhone.Text) || !Regex.IsMatch(txtPhone.Text, @"^09\d{9}$"))
            {
                ShowToolTip(txtPhone, "Phone number must be 11 digits starting with '09'.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text) || !txtEmail.Text.EndsWith("@gmail.com"))
            {
                ShowToolTip(txtEmail, "Email must be a valid Gmail address.");
                return false;
            }

            return true;
        }

        private void ShowToolTip(Control control, string message)
        {
            toolTip1.Show(message, control, control.Width / 2, control.Height / 2, 2000);
        }

        private void Signupbtn_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string occupation = txtOccupation.Text;
            string pin = txtpin.Text;
            string confirmPin = txtConfirmPIN.Text;
            string phone = txtPhone.Text;
            string email = txtEmail.Text;
            DateTime dateOfBirth = dateTimePickerDOB.Value;
            string address = txtAddress.Text;

            if (pin != confirmPin)
            {
                MessageBox.Show("PINs do not match. Please re-enter.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                connection.Open();

                int balance = 0;
                string query = "INSERT INTO `signup` (`Account Number`, `First Name`, `Last Name`, `Occupation`, `Pin`, `Phone`, `Email`, `Date Of Birth`, `Address`, `Balance`) " +
               "VALUES (@AccountNumber, @FirstName, @LastName, @Occupation, @PIN, @Phone, @Email, @DateOfBirth, @Address, @Balance)";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@AccountNumber", txtAccountNumber.Text); 
                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@Occupation", occupation);
                command.Parameters.AddWithValue("@PIN", pin);
                command.Parameters.AddWithValue("@Phone", phone);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                command.Parameters.AddWithValue("@Address", address);
                command.Parameters.AddWithValue("@Balance", balance);

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    // Display success message
                    MessageBox.Show($"Account Created Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No rows affected. Account creation failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Database error occurred: {ex.Message}\nErrorCode: {ex.ErrorCode}\nStackTrace: {ex.StackTrace}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}\nStackTrace: {ex.StackTrace}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }

            Login login = new Login();
            login.Show();
            Hide();
        }

        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Tab && e.KeyChar != (char)Keys.Enter)
            {
                e.Handled = true;
            }
        }

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Tab && e.KeyChar != (char)Keys.Enter)
            {
                e.Handled = true;
            }
        }

        private void txtOccupation_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Tab && e.KeyChar != (char)Keys.Enter)
            {
                e.Handled = true;
            }
        }

        private void txtpin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Tab && e.KeyChar != (char)Keys.Enter)
            {
                e.Handled = true;
            }
        }

        private void txtConfirmPIN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Tab && e.KeyChar != (char)Keys.Enter)
            {
                e.Handled = true;
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Tab && e.KeyChar != (char)Keys.Enter)
            {
                e.Handled = true;
            }
        }

        private void txtFirstName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                ShowToolTip(txtFirstName, "First Name cannot be empty.");
            }
        }

        private void txtLastName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                ShowToolTip(txtLastName, "Last Name cannot be empty.");
            }
        }

        private void txtOccupation_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOccupation.Text))
            {
                ShowToolTip(txtOccupation, "Occupation cannot be empty.");
            }
        }

        private void txtpin_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtpin.Text) || txtpin.Text.Length != 4)
            {
                ShowToolTip(txtpin, "PIN must be 4 digits.");
            }
        }

        private void txtConfirmPIN_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtConfirmPIN.Text) || txtConfirmPIN.Text.Length != 4)
            {
                ShowToolTip(txtConfirmPIN, "Confirm PIN must be 4 digits.");
            }
        }

        private void txtPhone_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPhone.Text) || !Regex.IsMatch(txtPhone.Text, @"^09\d{9}$"))
            {
                ShowToolTip(txtPhone, "Phone number must be 11 digits starting with '09'.");
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text) || !txtEmail.Text.EndsWith("@gmail.com"))
            {
                ShowToolTip(txtEmail, "Email must be a valid Gmail address.");
            }
        }

        private void Sign_up_Load(object sender, EventArgs e)
        {
        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Sign_up_Load_1(object sender, EventArgs e)
        {

        }

        private void Sign_up_Load_2(object sender, EventArgs e)
        {
             
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();

        }
    }
}
