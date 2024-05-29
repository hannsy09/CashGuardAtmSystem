namespace Cash_Guard_System
{
    partial class Account
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
            this.label1 = new System.Windows.Forms.Label();
            this.AccountBalance = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtChangePin = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtConfirmPin = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.Label();
            this.Confirmbtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CheckBox1 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account";
            // 
            // AccountBalance
            // 
            this.AccountBalance.AutoSize = true;
            this.AccountBalance.ForeColor = System.Drawing.Color.White;
            this.AccountBalance.Location = new System.Drawing.Point(135, 92);
            this.AccountBalance.Name = "AccountBalance";
            this.AccountBalance.Size = new System.Drawing.Size(119, 17);
            this.AccountBalance.TabIndex = 1;
            this.AccountBalance.Text = "Account Balance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(21, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Change Pin:";
            // 
            // txtChangePin
            // 
            this.txtChangePin.BorderRadius = 5;
            this.txtChangePin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtChangePin.DefaultText = "";
            this.txtChangePin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtChangePin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtChangePin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtChangePin.DisabledState.Parent = this.txtChangePin;
            this.txtChangePin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtChangePin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtChangePin.FocusedState.Parent = this.txtChangePin;
            this.txtChangePin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtChangePin.HoverState.Parent = this.txtChangePin;
            this.txtChangePin.Location = new System.Drawing.Point(24, 181);
            this.txtChangePin.Margin = new System.Windows.Forms.Padding(4);
            this.txtChangePin.Name = "txtChangePin";
            this.txtChangePin.PasswordChar = '\0';
            this.txtChangePin.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtChangePin.PlaceholderText = "";
            this.txtChangePin.SelectedText = "";
            this.txtChangePin.ShadowDecoration.Parent = this.txtChangePin;
            this.txtChangePin.Size = new System.Drawing.Size(230, 20);
            this.txtChangePin.TabIndex = 3;
            this.txtChangePin.UseSystemPasswordChar = true;
            // 
            // txtConfirmPin
            // 
            this.txtConfirmPin.BorderRadius = 5;
            this.txtConfirmPin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConfirmPin.DefaultText = "";
            this.txtConfirmPin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtConfirmPin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtConfirmPin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConfirmPin.DisabledState.Parent = this.txtConfirmPin;
            this.txtConfirmPin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConfirmPin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtConfirmPin.FocusedState.Parent = this.txtConfirmPin;
            this.txtConfirmPin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtConfirmPin.HoverState.Parent = this.txtConfirmPin;
            this.txtConfirmPin.Location = new System.Drawing.Point(24, 251);
            this.txtConfirmPin.Margin = new System.Windows.Forms.Padding(5);
            this.txtConfirmPin.Name = "txtConfirmPin";
            this.txtConfirmPin.PasswordChar = '\0';
            this.txtConfirmPin.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtConfirmPin.PlaceholderText = "";
            this.txtConfirmPin.SelectedText = "";
            this.txtConfirmPin.ShadowDecoration.Parent = this.txtConfirmPin;
            this.txtConfirmPin.Size = new System.Drawing.Size(230, 21);
            this.txtConfirmPin.TabIndex = 5;
            this.txtConfirmPin.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(21, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Confirm Pin:";
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.ForeColor = System.Drawing.Color.White;
            this.FirstName.Location = new System.Drawing.Point(21, 92);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(48, 17);
            this.FirstName.TabIndex = 6;
            this.FirstName.Text = "Name";
            // 
            // Confirmbtn
            // 
            this.Confirmbtn.BorderRadius = 5;
            this.Confirmbtn.CheckedState.Parent = this.Confirmbtn;
            this.Confirmbtn.CustomImages.Parent = this.Confirmbtn;
            this.Confirmbtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirmbtn.ForeColor = System.Drawing.Color.White;
            this.Confirmbtn.HoverState.Parent = this.Confirmbtn;
            this.Confirmbtn.Location = new System.Drawing.Point(105, 324);
            this.Confirmbtn.Name = "Confirmbtn";
            this.Confirmbtn.ShadowDecoration.Parent = this.Confirmbtn;
            this.Confirmbtn.Size = new System.Drawing.Size(70, 22);
            this.Confirmbtn.TabIndex = 7;
            this.Confirmbtn.Text = "Confirm";
            this.Confirmbtn.Click += new System.EventHandler(this.Confirmbtn_Click);
            // 
            // guna2CheckBox1
            // 
            this.guna2CheckBox1.AutoSize = true;
            this.guna2CheckBox1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox1.CheckedState.BorderRadius = 2;
            this.guna2CheckBox1.CheckedState.BorderThickness = 0;
            this.guna2CheckBox1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2CheckBox1.ForeColor = System.Drawing.Color.White;
            this.guna2CheckBox1.Location = new System.Drawing.Point(24, 289);
            this.guna2CheckBox1.Name = "guna2CheckBox1";
            this.guna2CheckBox1.Size = new System.Drawing.Size(76, 20);
            this.guna2CheckBox1.TabIndex = 10;
            this.guna2CheckBox1.Text = "Show Pin";
            this.guna2CheckBox1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CheckBox1.UncheckedState.BorderRadius = 2;
            this.guna2CheckBox1.UncheckedState.BorderThickness = 0;
            this.guna2CheckBox1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CheckBox1.UseVisualStyleBackColor = true;
            this.guna2CheckBox1.CheckedChanged += new System.EventHandler(this.guna2CheckBox1_CheckedChanged);
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(281, 387);
            this.Controls.Add(this.guna2CheckBox1);
            this.Controls.Add(this.Confirmbtn);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.txtConfirmPin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtChangePin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AccountBalance);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Account";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Account";
            this.Load += new System.EventHandler(this.Account_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label AccountBalance;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtChangePin;
        private Guna.UI2.WinForms.Guna2TextBox txtConfirmPin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label FirstName;
        private Guna.UI2.WinForms.Guna2Button Confirmbtn;
        private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox1;
    }
}
