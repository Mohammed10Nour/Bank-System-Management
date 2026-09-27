namespace Bank.Applications
{
    partial class frmApplicationTypes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvAllApplicationTypes = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllApplicationTypes)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Blue;
            this.guna2Panel1.Controls.Add(this.guna2Panel2);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(789, 153);
            this.guna2Panel1.TabIndex = 16;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.BorderRadius = 20;
            this.guna2Panel2.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.guna2Panel2.Controls.Add(this.pictureBox1);
            this.guna2Panel2.Controls.Add(this.lblTitle);
            this.guna2Panel2.FillColor = System.Drawing.Color.Green;
            this.guna2Panel2.Location = new System.Drawing.Point(29, 29);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Enabled = true;
            this.guna2Panel2.Size = new System.Drawing.Size(748, 103);
            this.guna2Panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bank.Properties.Resources.icons8_services_100;
            this.pictureBox1.Location = new System.Drawing.Point(634, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 94);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft YaHei", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(64, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(601, 76);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "جميع الطلبات التي يقدمها النظام";
            // 
            // dgvAllApplicationTypes
            // 
            this.dgvAllApplicationTypes.AllowUserToAddRows = false;
            this.dgvAllApplicationTypes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvAllApplicationTypes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAllApplicationTypes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.dgvAllApplicationTypes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvAllApplicationTypes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllApplicationTypes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAllApplicationTypes.ColumnHeadersHeight = 45;
            this.dgvAllApplicationTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAllApplicationTypes.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAllApplicationTypes.GridColor = System.Drawing.Color.Navy;
            this.dgvAllApplicationTypes.Location = new System.Drawing.Point(-1, 150);
            this.dgvAllApplicationTypes.Name = "dgvAllApplicationTypes";
            this.dgvAllApplicationTypes.ReadOnly = true;
            this.dgvAllApplicationTypes.RowHeadersVisible = false;
            this.dgvAllApplicationTypes.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvAllApplicationTypes.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAllApplicationTypes.RowTemplate.DividerHeight = 2;
            this.dgvAllApplicationTypes.RowTemplate.Height = 36;
            this.dgvAllApplicationTypes.Size = new System.Drawing.Size(790, 587);
            this.dgvAllApplicationTypes.TabIndex = 15;
            this.dgvAllApplicationTypes.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAllApplicationTypes.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvAllApplicationTypes.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvAllApplicationTypes.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvAllApplicationTypes.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvAllApplicationTypes.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvAllApplicationTypes.ThemeStyle.GridColor = System.Drawing.Color.Navy;
            this.dgvAllApplicationTypes.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Black;
            this.dgvAllApplicationTypes.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvAllApplicationTypes.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAllApplicationTypes.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvAllApplicationTypes.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvAllApplicationTypes.ThemeStyle.HeaderStyle.Height = 45;
            this.dgvAllApplicationTypes.ThemeStyle.ReadOnly = true;
            this.dgvAllApplicationTypes.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAllApplicationTypes.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAllApplicationTypes.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAllApplicationTypes.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvAllApplicationTypes.ThemeStyle.RowsStyle.Height = 36;
            this.dgvAllApplicationTypes.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Black;
            this.dgvAllApplicationTypes.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // frmApplicationTypes2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 737);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.dgvAllApplicationTypes);
            this.Name = "frmApplicationTypes2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmApplicationTypes2";
            this.Load += new System.EventHandler(this.frmApplicationTypes2_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllApplicationTypes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2DataGridView dgvAllApplicationTypes;
    }
}