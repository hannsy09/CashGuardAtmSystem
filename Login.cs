using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Net.Mail;

namespace Cash_Guard_System
{
    public partial class Login : Form
    {
        private readonly MySqlConnection _connection;
        private MySqlCommand _command;
        private MySqlDataReader _mdr;
        private ToolTip _toolTip;

        public Login()
        {
            InitializeComponent();
            _command = new MySqlCommand();
            _connection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=");
            _command.Connection = _connection;
            _toolTip = new ToolTip();

            
            txtPassword.KeyPress += new KeyPressEventHandler(TextBox_KeyPress);
            txtUsername.KeyPress += new KeyPressEventHandler(TextBox_KeyPress);

            
            txtUsername.KeyDown += new KeyEventHandler(TextBox_KeyDown);
            txtPassword.KeyDown += new KeyEventHandler(TextBox_KeyDown);

            
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form_KeyDown);

            
            
        }

        private void Signupbtn_Click(object sender, EventArgs e)
        {
            Sign_up signup = new Sign_up();
            signup.Show();
            Hide();
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            try
            {
                _connection.Open();
                string selectQuery = "SELECT * FROM account.signup WHERE `Account Number` = @AccountNumber AND Pin = @PIN";
                _command.CommandText = selectQuery;
                _command.Parameters.Clear();
                _command.Parameters.AddWithValue("@AccountNumber", txtUsername.Text);
                _command.Parameters.AddWithValue("@PIN", txtPassword.Text);
                _mdr = _command.ExecuteReader();

                if (_mdr.Read())
                {
                    _mdr.Close();
                    MessageBox.Show("Login Successful!");
                    Dashboard dashboard = new Dashboard(txtUsername.Text);
                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect Login Information! Try again.");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"MySQL error: {ex.Message}", "Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"General error: {ex.Message}", "Error");
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                ShowToolTip(txtPassword, "Account Number cannot be empty.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                ShowToolTip(txtUsername, "Password cannot be empty.");
                return false;
            }

            return true;
        }

        private void ShowToolTip(Control control, string message)
        {
            _toolTip.Show(message, control, control.Width / 2, control.Height / 2, 2000);
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            // Allow only numbers, backspace, and delete
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Loginbtn.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Loginbtn.PerformClick();
                e.SuppressKeyPress = true; 
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
            guna2DateTimePicker1.Value = DateTime.Today;
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtUsername.UseSystemPasswordChar = !guna2CheckBox1.Checked;
            txtPassword.UseSystemPasswordChar = !guna2CheckBox1.Checked;
        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ForgotPintxt_Click(object sender, EventArgs e)
        {
            string accountNumber = txtUsername.Text;
            if (string.IsNullOrWhiteSpace(accountNumber))
            {
                MessageBox.Show("Please enter your account number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                _connection.Open();
                string query = "SELECT Email FROM account.signup WHERE `Account Number` = @AccountNumber";
                _command.CommandText = query;
                _command.Parameters.Clear();
                _command.Parameters.AddWithValue("@AccountNumber", accountNumber);
                string email = _command.ExecuteScalar()?.ToString();

                if (string.IsNullOrWhiteSpace(email))
                {
                    MessageBox.Show("Account number not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string newPin = GenerateNewPin();
                SendNewPinEmail(email, newPin);

                query = "UPDATE account.signup SET Pin = @NewPin WHERE `Account Number` = @AccountNumber";
                _command.CommandText = query;
                _command.Parameters.Clear();
                _command.Parameters.AddWithValue("@NewPin", newPin);
                _command.Parameters.AddWithValue("@AccountNumber", accountNumber);
                _command.ExecuteNonQuery();

                MessageBox.Show("A new PIN has been sent to your email.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"MySQL error: {ex.Message}", "Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"General error: {ex.Message}", "Error");
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }
        }

        private string GenerateNewPin()
        {
            Random random = new Random();
            return random.Next(1000, 10000).ToString("D4");
        }

        private void SendNewPinEmail(string email, string newPin)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587)
                {
                    Credentials = new System.Net.NetworkCredential("your-email@gmail.com", "your-app-password"), 
                    EnableSsl = true
                };

                MailMessage mailMessage = new MailMessage
                {
                    From = new MailAddress("your-email@gmail.com"),
                    Subject = "Your New PIN Code",
                    Body = $"Your new PIN code is: {newPin}",
                    IsBodyHtml = false,
                };
                mailMessage.To.Add(email);

                client.Send(mailMessage);
            }
            catch (SmtpException ex)
            {
                MessageBox.Show("Failed to send email: " + ex.Message, "Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show("General error: " + ex.Message, "Error");
            }
        }
    }
}
