using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Cash_Guard_System
{
    public partial class FullViewMinistatement : Form
    {
        private string accountNumber;
        private Bitmap bitmap;
        private readonly MySqlConnection _connection;
        private MySqlCommand _command;

        public FullViewMinistatement(string accountNumber, DataTable miniStatementData)
        {
            InitializeComponent();
            this.accountNumber = accountNumber;


            Fullview.DataSource = miniStatementData;

          
            _connection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=account");
            _command = new MySqlCommand();
            _command.Connection = _connection;
        }

        private void FullViewMinistatement_Load(object sender, EventArgs e)
        {
            LoadAccountDetails();
            DateNow.Value = DateTime.Now;
            DateNow.Enabled = false;
        }

        private void LoadAccountDetails()
        {
            try
            {
                _connection.Open();
                string query = "SELECT `First Name`, `Balance` FROM signup WHERE `Account Number` = @AccountNumber";
                _command.CommandText = query;
                _command.Parameters.Clear();
                _command.Parameters.AddWithValue("@AccountNumber", accountNumber);
                MySqlDataReader reader = _command.ExecuteReader();

                if (reader.Read())
                {
                    Nametxt.Text = "Account Name: " + reader["First Name"].ToString();
                    Balancetxt.Text = "BALANCE: ₱" + reader["Balance"].ToString();
                }
                else
                {
                    MessageBox.Show("Account details not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                reader.Close();
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

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard(accountNumber);
            dashboard.Show();
            this.Hide();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if (bitmap != null)
                e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Panel panel = new Panel();
            this.Controls.Add(panel);

            Graphics graphic = panel.CreateGraphics();
            Size size = this.ClientSize;
            bitmap = new Bitmap(size.Width, size.Height);
            graphic = Graphics.FromImage(bitmap);

            Point point = PointToScreen(panel.Location);
            graphic.CopyFromScreen(point.X, point.Y, 0, 0, size);

            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
    }
}
