
namespace Cash_Guard_System
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        



        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sidepanel = new System.Windows.Forms.Panel();
            this.Logoutbtn = new Guna.UI2.WinForms.Guna2Button();
            this.Ministatementbtn = new Guna.UI2.WinForms.Guna2Button();
            this.Depositbtn = new Guna.UI2.WinForms.Guna2Button();
            this.Withdrawbtn = new Guna.UI2.WinForms.Guna2Button();
            this.Accountbtn = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AccountToolTip = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.WithdrawToolTip = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.MinistatementToolTip = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.DepositToolTip = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.LogoutToolTip = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.guna2GradientPanel1.SuspendLayout();
            this.mainpanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.sidepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 36;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BorderRadius = 30;
            this.guna2GradientPanel1.Controls.Add(this.mainpanel);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(10, 10);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(330, 387);
            this.guna2GradientPanel1.TabIndex = 0;
            // 
            // mainpanel
            // 
            this.mainpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.mainpanel.Controls.Add(this.panel1);
            this.mainpanel.Location = new System.Drawing.Point(49, 0);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(281, 390);
            this.mainpanel.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 390);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(125, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "←";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(38, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Choose a transaction";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(84, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "To CashGuard";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(83, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "WELCOME";
            // 
            // sidepanel
            // 
            this.sidepanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.sidepanel.Controls.Add(this.Logoutbtn);
            this.sidepanel.Controls.Add(this.Ministatementbtn);
            this.sidepanel.Controls.Add(this.Depositbtn);
            this.sidepanel.Controls.Add(this.Withdrawbtn);
            this.sidepanel.Controls.Add(this.Accountbtn);
            this.sidepanel.Controls.Add(this.pictureBox1);
            this.sidepanel.Location = new System.Drawing.Point(10, 10);
            this.sidepanel.Name = "sidepanel";
            this.sidepanel.Size = new System.Drawing.Size(43, 387);
            this.sidepanel.TabIndex = 0;
            // 
            // Logoutbtn
            // 
            this.Logoutbtn.CheckedState.Parent = this.Logoutbtn;
            this.Logoutbtn.CustomImages.Parent = this.Logoutbtn;
            this.Logoutbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Logoutbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Logoutbtn.ForeColor = System.Drawing.Color.White;
            this.Logoutbtn.HoverState.Parent = this.Logoutbtn;
            this.Logoutbtn.Image = ((System.Drawing.Image)(resources.GetObject("Logoutbtn.Image")));
            this.Logoutbtn.Location = new System.Drawing.Point(3, 333);
            this.Logoutbtn.Name = "Logoutbtn";
            this.Logoutbtn.ShadowDecoration.Parent = this.Logoutbtn;
            this.Logoutbtn.Size = new System.Drawing.Size(37, 40);
            this.Logoutbtn.TabIndex = 4;
            this.LogoutToolTip.SetToolTip(this.Logoutbtn, "Logout");
            this.Logoutbtn.Click += new System.EventHandler(this.Logoutbtn_Click);
            // 
            // Ministatementbtn
            // 
            this.Ministatementbtn.CheckedState.Parent = this.Ministatementbtn;
            this.Ministatementbtn.CustomImages.Parent = this.Ministatementbtn;
            this.Ministatementbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Ministatementbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Ministatementbtn.ForeColor = System.Drawing.Color.White;
            this.Ministatementbtn.HoverState.Parent = this.Ministatementbtn;
            this.Ministatementbtn.Image = ((System.Drawing.Image)(resources.GetObject("Ministatementbtn.Image")));
            this.Ministatementbtn.Location = new System.Drawing.Point(3, 226);
            this.Ministatementbtn.Name = "Ministatementbtn";
            this.Ministatementbtn.ShadowDecoration.Parent = this.Ministatementbtn;
            this.Ministatementbtn.Size = new System.Drawing.Size(37, 40);
            this.Ministatementbtn.TabIndex = 3;
            this.Ministatementbtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MinistatementToolTip.SetToolTip(this.Ministatementbtn, "Mini Statement");
            this.Ministatementbtn.Click += new System.EventHandler(this.Ministatementbtn_Click);
            // 
            // Depositbtn
            // 
            this.Depositbtn.CheckedState.Parent = this.Depositbtn;
            this.Depositbtn.CustomImages.Parent = this.Depositbtn;
            this.Depositbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Depositbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Depositbtn.ForeColor = System.Drawing.Color.White;
            this.Depositbtn.HoverState.Parent = this.Depositbtn;
            this.Depositbtn.Image = ((System.Drawing.Image)(resources.GetObject("Depositbtn.Image")));
            this.Depositbtn.Location = new System.Drawing.Point(3, 180);
            this.Depositbtn.Name = "Depositbtn";
            this.Depositbtn.ShadowDecoration.Parent = this.Depositbtn;
            this.Depositbtn.Size = new System.Drawing.Size(37, 40);
            this.Depositbtn.TabIndex = 2;
            this.Depositbtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.DepositToolTip.SetToolTip(this.Depositbtn, "Deposit");
            this.Depositbtn.Click += new System.EventHandler(this.Depositbtn_Click);
            // 
            // Withdrawbtn
            // 
            this.Withdrawbtn.CheckedState.Parent = this.Withdrawbtn;
            this.Withdrawbtn.CustomImages.Parent = this.Withdrawbtn;
            this.Withdrawbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Withdrawbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Withdrawbtn.ForeColor = System.Drawing.Color.White;
            this.Withdrawbtn.HoverState.Parent = this.Withdrawbtn;
            this.Withdrawbtn.Image = ((System.Drawing.Image)(resources.GetObject("Withdrawbtn.Image")));
            this.Withdrawbtn.Location = new System.Drawing.Point(3, 134);
            this.Withdrawbtn.Name = "Withdrawbtn";
            this.Withdrawbtn.ShadowDecoration.Parent = this.Withdrawbtn;
            this.Withdrawbtn.Size = new System.Drawing.Size(37, 40);
            this.Withdrawbtn.TabIndex = 1;
            this.Withdrawbtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.WithdrawToolTip.SetToolTip(this.Withdrawbtn, "Withdraw");
            this.Withdrawbtn.Click += new System.EventHandler(this.Withdrawbtn_Click);
            // 
            // Accountbtn
            // 
            this.Accountbtn.CheckedState.Parent = this.Accountbtn;
            this.Accountbtn.CustomImages.Parent = this.Accountbtn;
            this.Accountbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Accountbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Accountbtn.ForeColor = System.Drawing.Color.White;
            this.Accountbtn.HoverState.Parent = this.Accountbtn;
            this.Accountbtn.Image = ((System.Drawing.Image)(resources.GetObject("Accountbtn.Image")));
            this.Accountbtn.Location = new System.Drawing.Point(3, 88);
            this.Accountbtn.Name = "Accountbtn";
            this.Accountbtn.ShadowDecoration.Parent = this.Accountbtn;
            this.Accountbtn.Size = new System.Drawing.Size(37, 40);
            this.Accountbtn.TabIndex = 0;
            this.Accountbtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.AccountToolTip.SetToolTip(this.Accountbtn, "Home");
            this.Accountbtn.Click += new System.EventHandler(this.Accountbtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // AccountToolTip
            // 
            this.AccountToolTip.AllowLinksHandling = true;
            this.AccountToolTip.AutoPopDelay = 3000;
            this.AccountToolTip.InitialDelay = 300;
            this.AccountToolTip.MaximumSize = new System.Drawing.Size(0, 0);
            this.AccountToolTip.ReshowDelay = 100;
            this.AccountToolTip.Popup += new System.Windows.Forms.PopupEventHandler(this.guna2HtmlToolTip1_Popup);
            // 
            // WithdrawToolTip
            // 
            this.WithdrawToolTip.AllowLinksHandling = true;
            this.WithdrawToolTip.AutoPopDelay = 3000;
            this.WithdrawToolTip.InitialDelay = 500;
            this.WithdrawToolTip.MaximumSize = new System.Drawing.Size(0, 0);
            this.WithdrawToolTip.ReshowDelay = 100;
            // 
            // MinistatementToolTip
            // 
            this.MinistatementToolTip.AllowLinksHandling = true;
            this.MinistatementToolTip.AutoPopDelay = 3000;
            this.MinistatementToolTip.InitialDelay = 500;
            this.MinistatementToolTip.MaximumSize = new System.Drawing.Size(0, 0);
            this.MinistatementToolTip.ReshowDelay = 100;
            // 
            // DepositToolTip
            // 
            this.DepositToolTip.AllowLinksHandling = true;
            this.DepositToolTip.AutoPopDelay = 3000;
            this.DepositToolTip.InitialDelay = 500;
            this.DepositToolTip.MaximumSize = new System.Drawing.Size(0, 0);
            this.DepositToolTip.ReshowDelay = 100;
            // 
            // LogoutToolTip
            // 
            this.LogoutToolTip.AllowLinksHandling = true;
            this.LogoutToolTip.AutoPopDelay = 3000;
            this.LogoutToolTip.InitialDelay = 500;
            this.LogoutToolTip.MaximumSize = new System.Drawing.Size(0, 0);
            this.LogoutToolTip.ReshowDelay = 100;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(53)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(350, 407);
            this.Controls.Add(this.sidepanel);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Dashboard";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.mainpanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.sidepanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel sidepanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2Button Logoutbtn;
        private Guna.UI2.WinForms.Guna2Button Ministatementbtn;
        private Guna.UI2.WinForms.Guna2Button Depositbtn;
        private Guna.UI2.WinForms.Guna2Button Withdrawbtn;
        private Guna.UI2.WinForms.Guna2Button Accountbtn;
        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2HtmlToolTip AccountToolTip;
        private Guna.UI2.WinForms.Guna2HtmlToolTip WithdrawToolTip;
        private Guna.UI2.WinForms.Guna2HtmlToolTip LogoutToolTip;
        private Guna.UI2.WinForms.Guna2HtmlToolTip DepositToolTip;
        private Guna.UI2.WinForms.Guna2HtmlToolTip MinistatementToolTip;
    }
}

