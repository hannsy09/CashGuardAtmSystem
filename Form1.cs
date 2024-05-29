using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cash_Guard_System
{
    public partial class Dashboard : Form
    {
        private string loggedInIdentifier; 


        public Dashboard(string loggedInIdentifier)
        {
            InitializeComponent();
            this.loggedInIdentifier = loggedInIdentifier;
        }

        public void loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }

        private void Accountbtn_Click(object sender, EventArgs e)
        {
            loadform(new Account(loggedInIdentifier, this));
        }

        private void Withdrawbtn_Click(object sender, EventArgs e)
        {
            loadform(new Withdraw(loggedInIdentifier)); 
        }

        private void Depositbtn_Click(object sender, EventArgs e)
        {
            loadform(new Deposit(loggedInIdentifier));
        }

        private void Logoutbtn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void guna2HtmlToolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Ministatementbtn_Click(object sender, EventArgs e)
        {
            loadform(new MIniStatement(loggedInIdentifier));
        }
    }
}
