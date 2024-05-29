
namespace Cash_Guard_System
{
    partial class FullViewMinistatement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FullViewMinistatement));
            this.Date = new System.Windows.Forms.Label();
            this.Amount = new System.Windows.Forms.Label();
            this.Type = new System.Windows.Forms.Label();
            this.accnum = new System.Windows.Forms.Label();
            this.Fullview = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.Nametxt = new System.Windows.Forms.Label();
            this.Balancetxt = new System.Windows.Forms.Label();
            this.DateNow = new Guna.UI2.WinForms.Guna2DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.Fullview)).BeginInit();
            this.SuspendLayout();
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.ForeColor = System.Drawing.Color.White;
            this.Date.Location = new System.Drawing.Point(654, 90);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(30, 13);
            this.Date.TabIndex = 14;
            this.Date.Text = "Date";
            // 
            // Amount
            // 
            this.Amount.AutoSize = true;
            this.Amount.ForeColor = System.Drawing.Color.White;
            this.Amount.Location = new System.Drawing.Point(457, 90);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(43, 13);
            this.Amount.TabIndex = 13;
            this.Amount.Text = "Amount";
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.ForeColor = System.Drawing.Color.White;
            this.Type.Location = new System.Drawing.Point(236, 90);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(31, 13);
            this.Type.TabIndex = 12;
            this.Type.Text = "Type";
            // 
            // accnum
            // 
            this.accnum.AutoSize = true;
            this.accnum.ForeColor = System.Drawing.Color.White;
            this.accnum.Location = new System.Drawing.Point(33, 90);
            this.accnum.Name = "accnum";
            this.accnum.Size = new System.Drawing.Size(87, 13);
            this.accnum.TabIndex = 11;
            this.accnum.Text = "Account Number";
            // 
            // Fullview
            // 
            this.Fullview.AllowUserToAddRows = false;
            this.Fullview.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.Fullview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Fullview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Fullview.BackgroundColor = System.Drawing.Color.White;
            this.Fullview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Fullview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Fullview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Fullview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Fullview.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Fullview.DefaultCellStyle = dataGridViewCellStyle3;
            this.Fullview.EnableHeadersVisualStyles = false;
            this.Fullview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Fullview.Location = new System.Drawing.Point(12, 122);
            this.Fullview.Name = "Fullview";
            this.Fullview.ReadOnly = true;
            this.Fullview.RowHeadersVisible = false;
            this.Fullview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Fullview.Size = new System.Drawing.Size(737, 253);
            this.Fullview.TabIndex = 10;
            this.Fullview.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.Fullview.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.Fullview.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.Fullview.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.Fullview.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.Fullview.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.Fullview.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.Fullview.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Fullview.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Fullview.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Fullview.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fullview.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.Fullview.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.Fullview.ThemeStyle.HeaderStyle.Height = 4;
            this.Fullview.ThemeStyle.ReadOnly = true;
            this.Fullview.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.Fullview.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Fullview.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fullview.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.Fullview.ThemeStyle.RowsStyle.Height = 22;
            this.Fullview.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Fullview.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(339, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mini Statement";
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.BorderRadius = 5;
            this.guna2GradientButton1.CheckedState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.CustomImages.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(117)))), ((int)(((byte)(230)))));
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(27)))), ((int)(((byte)(121)))));
            this.guna2GradientButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.HoverState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Location = new System.Drawing.Point(352, 396);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.ShadowDecoration.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Size = new System.Drawing.Size(55, 22);
            this.guna2GradientButton1.TabIndex = 16;
            this.guna2GradientButton1.Text = "Back";
            this.guna2GradientButton1.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 20;
            this.guna2Elipse2.TargetControl = this.Fullview;
            // 
            // guna2Button1
            // 
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(681, 32);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(68, 21);
            this.guna2Button1.TabIndex = 18;
            this.guna2Button1.Text = "Print";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 5;
            this.guna2Elipse3.TargetControl = this.guna2Button1;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Nametxt
            // 
            this.Nametxt.AutoSize = true;
            this.Nametxt.ForeColor = System.Drawing.Color.White;
            this.Nametxt.Location = new System.Drawing.Point(33, 40);
            this.Nametxt.Name = "Nametxt";
            this.Nametxt.Size = new System.Drawing.Size(35, 13);
            this.Nametxt.TabIndex = 19;
            this.Nametxt.Text = "Name";
            // 
            // Balancetxt
            // 
            this.Balancetxt.AutoSize = true;
            this.Balancetxt.ForeColor = System.Drawing.Color.White;
            this.Balancetxt.Location = new System.Drawing.Point(186, 40);
            this.Balancetxt.Name = "Balancetxt";
            this.Balancetxt.Size = new System.Drawing.Size(46, 13);
            this.Balancetxt.TabIndex = 20;
            this.Balancetxt.Text = "Balance";
            // 
            // DateNow
            // 
            this.DateNow.CheckedState.Parent = this.DateNow;
            this.DateNow.FillColor = System.Drawing.Color.Transparent;
            this.DateNow.ForeColor = System.Drawing.Color.White;
            this.DateNow.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateNow.HoverState.Parent = this.DateNow;
            this.DateNow.Location = new System.Drawing.Point(460, 33);
            this.DateNow.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateNow.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateNow.Name = "DateNow";
            this.DateNow.ShadowDecoration.Parent = this.DateNow;
            this.DateNow.Size = new System.Drawing.Size(184, 20);
            this.DateNow.TabIndex = 21;
            this.DateNow.Value = new System.DateTime(2024, 5, 29, 1, 39, 57, 407);
            // 
            // FullViewMinistatement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(761, 450);
            this.Controls.Add(this.DateNow);
            this.Controls.Add(this.Balancetxt);
            this.Controls.Add(this.Nametxt);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.guna2GradientButton1);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.accnum);
            this.Controls.Add(this.Fullview);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FullViewMinistatement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FullViewMinistatement";
            this.Load += new System.EventHandler(this.FullViewMinistatement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Fullview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Label Amount;
        private System.Windows.Forms.Label Type;
        private System.Windows.Forms.Label accnum;
        private Guna.UI2.WinForms.Guna2DataGridView Fullview;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateNow;
        private System.Windows.Forms.Label Balancetxt;
        private System.Windows.Forms.Label Nametxt;
    }
}