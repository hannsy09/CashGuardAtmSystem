using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Cash_Guard_System
{
    public partial class MIniStatement : Form
    {
        private MySqlConnection connection;
        private string connectionString = "Server=127.0.0.1;Database=account;Uid=root;Pwd=;";
        private string accountNumber;
        private DataTable miniStatementData;

        public MIniStatement(string accountNumber)
        {
            InitializeComponent();
            this.accountNumber = accountNumber;
            connection = new MySqlConnection(connectionString);
            LoadMiniStatement();
        }

        private void LoadMiniStatement()
        {
            try
            {
                connection.Open();

               
                string query = "SELECT `Account Number`, `Type`, `Amount`, `Date` FROM `transactiontbl` WHERE `Account Number` = @AccountNumber";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@AccountNumber", accountNumber);
                MySqlDataAdapter sda = new MySqlDataAdapter(cmd);

                miniStatementData = new DataTable();
                sda.Fill(miniStatementData);

                MinistatementDGV.DataSource = miniStatementData;
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void MIniStatement_Load(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            FullViewMinistatement fullViewMinistatement = new FullViewMinistatement(accountNumber, miniStatementData);
            fullViewMinistatement.Show();
            this.Hide();
        }
    }
}
