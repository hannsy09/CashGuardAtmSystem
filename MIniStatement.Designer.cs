
namespace Cash_Guard_System
{
    partial class MIniStatement
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
            this.label1 = new System.Windows.Forms.Label();
            this.MinistatementDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.accnum = new System.Windows.Forms.Label();
            this.Type = new System.Windows.Forms.Label();
            this.Amount = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MinistatementDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mini Statement";
            // 
            // MinistatementDGV
            // 
            this.MinistatementDGV.AllowUserToAddRows = false;
            this.MinistatementDGV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.MinistatementDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.MinistatementDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MinistatementDGV.BackgroundColor = System.Drawing.Color.White;
            this.MinistatementDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MinistatementDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.MinistatementDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MinistatementDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.MinistatementDGV.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MinistatementDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.MinistatementDGV.EnableHeadersVisualStyles = false;
            this.MinistatementDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.MinistatementDGV.Location = new System.Drawing.Point(12, 84);
            this.MinistatementDGV.Name = "MinistatementDGV";
            this.MinistatementDGV.ReadOnly = true;
            this.MinistatementDGV.RowHeadersVisible = false;
            this.MinistatementDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MinistatementDGV.Size = new System.Drawing.Size(254, 233);
            this.MinistatementDGV.TabIndex = 4;
            this.MinistatementDGV.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.MinistatementDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.MinistatementDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.MinistatementDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.MinistatementDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.MinistatementDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.MinistatementDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.MinistatementDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.MinistatementDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.MinistatementDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.MinistatementDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinistatementDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.MinistatementDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.MinistatementDGV.ThemeStyle.HeaderStyle.Height = 4;
            this.MinistatementDGV.ThemeStyle.ReadOnly = true;
            this.MinistatementDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.MinistatementDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.MinistatementDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinistatementDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.MinistatementDGV.ThemeStyle.RowsStyle.Height = 22;
            this.MinistatementDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.MinistatementDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // accnum
            // 
            this.accnum.AutoSize = true;
            this.accnum.ForeColor = System.Drawing.Color.White;
            this.accnum.Location = new System.Drawing.Point(9, 64);
            this.accnum.Name = "accnum";
            this.accnum.Size = new System.Drawing.Size(64, 17);
            this.accnum.TabIndex = 5;
            this.accnum.Text = "AccNum";
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.ForeColor = System.Drawing.Color.White;
            this.Type.Location = new System.Drawing.Point(90, 64);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(36, 17);
            this.Type.TabIndex = 6;
            this.Type.Text = "Type";
            this.Type.Click += new System.EventHandler(this.label2_Click);
            // 
            // Amount
            // 
            this.Amount.AutoSize = true;
            this.Amount.ForeColor = System.Drawing.Color.White;
            this.Amount.Location = new System.Drawing.Point(149, 64);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(60, 17);
            this.Amount.TabIndex = 7;
            this.Amount.Text = "Amount";
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.ForeColor = System.Drawing.Color.White;
            this.Date.Location = new System.Drawing.Point(226, 64);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(40, 17);
            this.Date.TabIndex = 8;
            this.Date.Text = "Date";
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
            this.guna2GradientButton1.Location = new System.Drawing.Point(108, 323);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.ShadowDecoration.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Size = new System.Drawing.Size(55, 22);
            this.guna2GradientButton1.TabIndex = 17;
            this.guna2GradientButton1.Text = "Full View";
            this.guna2GradientButton1.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this.MinistatementDGV;
            // 
            // MIniStatement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(265, 348);
            this.Controls.Add(this.guna2GradientButton1);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.accnum);
            this.Controls.Add(this.MinistatementDGV);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MIniStatement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MIniStatement";
            this.Load += new System.EventHandler(this.MIniStatement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MinistatementDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView MinistatementDGV;
        private System.Windows.Forms.Label accnum;
        private System.Windows.Forms.Label Type;
        private System.Windows.Forms.Label Amount;
        private System.Windows.Forms.Label Date;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}