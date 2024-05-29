using System;
namespace Cash_Guard_System
{
    partial class Withdraw
    {
        
        private System.ComponentModel.IContainer components = null;

       
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void Withdraw_Load(object sender, EventArgs e)
        {
            
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
            this.txtAmount = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtConfirmAmount = new Guna.UI2.WinForms.Guna2TextBox();
            this.Withdrawbtn = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Withdraw";
            // 
            // AccountBalance
            // 
            this.AccountBalance.AutoSize = true;
            this.AccountBalance.ForeColor = System.Drawing.Color.White;
            this.AccountBalance.Location = new System.Drawing.Point(51, 86);
            this.AccountBalance.Name = "AccountBalance";
            this.AccountBalance.Size = new System.Drawing.Size(119, 17);
            this.AccountBalance.TabIndex = 2;
            this.AccountBalance.Text = "Account Balance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(21, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Enter Amount:";
            // 
            // txtAmount
            // 
            this.txtAmount.BorderRadius = 5;
            this.txtAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAmount.DefaultText = "";
            this.txtAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAmount.DisabledState.Parent = this.txtAmount;
            this.txtAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAmount.FocusedState.Parent = this.txtAmount;
            this.txtAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAmount.HoverState.Parent = this.txtAmount;
            this.txtAmount.Location = new System.Drawing.Point(24, 194);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.PasswordChar = '\0';
            this.txtAmount.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtAmount.PlaceholderText = "";
            this.txtAmount.SelectedText = "";
            this.txtAmount.ShadowDecoration.Parent = this.txtAmount;
            this.txtAmount.Size = new System.Drawing.Size(229, 21);
            this.txtAmount.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(21, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Confirm Amount:";
            // 
            // txtConfirmAmount
            // 
            this.txtConfirmAmount.BorderRadius = 5;
            this.txtConfirmAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConfirmAmount.DefaultText = "";
            this.txtConfirmAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtConfirmAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtConfirmAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConfirmAmount.DisabledState.Parent = this.txtConfirmAmount;
            this.txtConfirmAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConfirmAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtConfirmAmount.FocusedState.Parent = this.txtConfirmAmount;
            this.txtConfirmAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtConfirmAmount.HoverState.Parent = this.txtConfirmAmount;
            this.txtConfirmAmount.Location = new System.Drawing.Point(24, 278);
            this.txtConfirmAmount.Margin = new System.Windows.Forms.Padding(5);
            this.txtConfirmAmount.Name = "txtConfirmAmount";
            this.txtConfirmAmount.PasswordChar = '\0';
            this.txtConfirmAmount.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtConfirmAmount.PlaceholderText = "";
            this.txtConfirmAmount.SelectedText = "";
            this.txtConfirmAmount.ShadowDecoration.Parent = this.txtConfirmAmount;
            this.txtConfirmAmount.Size = new System.Drawing.Size(229, 21);
            this.txtConfirmAmount.TabIndex = 6;
            // 
            // Withdrawbtn
            // 
            this.Withdrawbtn.BorderRadius = 5;
            this.Withdrawbtn.CheckedState.Parent = this.Withdrawbtn;
            this.Withdrawbtn.CustomImages.Parent = this.Withdrawbtn;
            this.Withdrawbtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Withdrawbtn.ForeColor = System.Drawing.Color.White;
            this.Withdrawbtn.HoverState.Parent = this.Withdrawbtn;
            this.Withdrawbtn.Location = new System.Drawing.Point(101, 322);
            this.Withdrawbtn.Name = "Withdrawbtn";
            this.Withdrawbtn.ShadowDecoration.Parent = this.Withdrawbtn;
            this.Withdrawbtn.Size = new System.Drawing.Size(70, 22);
            this.Withdrawbtn.TabIndex = 8;
            this.Withdrawbtn.Text = "Withdraw";
            this.Withdrawbtn.Click += new System.EventHandler(this.Withdrawbtn_Click);
            // 
            // Withdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(281, 387);
            this.Controls.Add(this.Withdrawbtn);
            this.Controls.Add(this.txtConfirmAmount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AccountBalance);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Withdraw";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Withdraw";
            this.Load += new System.EventHandler(this.Withdraw_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label AccountBalance;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtAmount;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtConfirmAmount;
        private Guna.UI2.WinForms.Guna2Button Withdrawbtn;
    }
}