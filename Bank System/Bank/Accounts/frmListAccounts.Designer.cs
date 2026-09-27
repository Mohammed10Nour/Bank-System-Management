namespace Bank.Accounts
{
    partial class frmListAccounts
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
            this.dgvAllAccounts = new Guna.UI2.WinForms.Guna2DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.showAccountInformation = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.txtFilterValue = new System.Windows.Forms.TextBox();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbFilterByAccountState = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllAccounts)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAllAccounts
            // 
            this.dgvAllAccounts.AllowUserToAddRows = false;
            this.dgvAllAccounts.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvAllAccounts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAllAccounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.dgvAllAccounts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllAccounts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAllAccounts.ColumnHeadersHeight = 45;
            this.dgvAllAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvAllAccounts.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAllAccounts.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAllAccounts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.dgvAllAccounts.Location = new System.Drawing.Point(21, 254);
            this.dgvAllAccounts.Name = "dgvAllAccounts";
            this.dgvAllAccounts.ReadOnly = true;
            this.dgvAllAccounts.RowHeadersVisible = false;
            this.dgvAllAccounts.RowHeadersWidth = 51;
            this.dgvAllAccounts.RowTemplate.DividerHeight = 2;
            this.dgvAllAccounts.RowTemplate.Height = 36;
            this.dgvAllAccounts.Size = new System.Drawing.Size(1106, 396);
            this.dgvAllAccounts.TabIndex = 12;
            this.dgvAllAccounts.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAllAccounts.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvAllAccounts.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvAllAccounts.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvAllAccounts.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvAllAccounts.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvAllAccounts.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.dgvAllAccounts.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Black;
            this.dgvAllAccounts.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvAllAccounts.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAllAccounts.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvAllAccounts.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvAllAccounts.ThemeStyle.HeaderStyle.Height = 45;
            this.dgvAllAccounts.ThemeStyle.ReadOnly = true;
            this.dgvAllAccounts.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAllAccounts.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAllAccounts.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAllAccounts.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvAllAccounts.ThemeStyle.RowsStyle.Height = 36;
            this.dgvAllAccounts.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvAllAccounts.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI Variable Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editAccount,
            this.showAccountInformation,
            this.deleteAccount});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(310, 112);
            // 
            // editAccount
            // 
            this.editAccount.Image = global::Bank.Properties.Resources.icons8_edit_30;
            this.editAccount.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editAccount.Name = "editAccount";
            this.editAccount.Size = new System.Drawing.Size(309, 36);
            this.editAccount.Text = "Edit Account";
            this.editAccount.Click += new System.EventHandler(this.editAccount_Click);
            // 
            // showAccountInformation
            // 
            this.showAccountInformation.Image = global::Bank.Properties.Resources.icons8_contact_details_30;
            this.showAccountInformation.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showAccountInformation.Name = "showAccountInformation";
            this.showAccountInformation.Size = new System.Drawing.Size(309, 36);
            this.showAccountInformation.Text = "Show Account Information";
            this.showAccountInformation.Click += new System.EventHandler(this.showAccountInformation_Click);
            // 
            // deleteAccount
            // 
            this.deleteAccount.Image = global::Bank.Properties.Resources.icons8_delete_30;
            this.deleteAccount.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteAccount.Name = "deleteAccount";
            this.deleteAccount.Size = new System.Drawing.Size(309, 36);
            this.deleteAccount.Text = "Delete Account";
            this.deleteAccount.Click += new System.EventHandler(this.deleteAccount_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Simple Indust Outline", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(14, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(410, 102);
            this.label3.TabIndex = 2;
            this.label3.Text = "Accounts";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Blue;
            this.guna2Button1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2Button1.Location = new System.Drawing.Point(885, 5);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2Button1.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2Button1.ShadowDecoration.Depth = 20;
            this.guna2Button1.ShadowDecoration.Enabled = true;
            this.guna2Button1.Size = new System.Drawing.Size(199, 40);
            this.guna2Button1.TabIndex = 1;
            this.guna2Button1.Text = "إضافة حساب جديد ➕";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.txtFilterValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txtFilterValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilterValue.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtFilterValue.Location = new System.Drawing.Point(247, 15);
            this.txtFilterValue.Multiline = true;
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.Size = new System.Drawing.Size(202, 31);
            this.txtFilterValue.TabIndex = 9;
            this.txtFilterValue.TextChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
            this.txtFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterValue_KeyPress);
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbFilterBy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBy.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbFilterBy.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Items.AddRange(new object[] {
            "None",
            "Account ID",
            "Account Number",
            "Client Name",
            "Account Name",
            "Account State"});
            this.cbFilterBy.Location = new System.Drawing.Point(20, 14);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(213, 31);
            this.cbFilterBy.TabIndex = 8;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbFilterByAccountState);
            this.panel1.Controls.Add(this.txtFilterValue);
            this.panel1.Controls.Add(this.cbFilterBy);
            this.panel1.Controls.Add(this.guna2Button1);
            this.panel1.Location = new System.Drawing.Point(12, 170);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(6);
            this.panel1.Size = new System.Drawing.Size(1095, 57);
            this.panel1.TabIndex = 13;
            // 
            // cbFilterByAccountState
            // 
            this.cbFilterByAccountState.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbFilterByAccountState.BackColor = System.Drawing.Color.Gainsboro;
            this.cbFilterByAccountState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterByAccountState.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbFilterByAccountState.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterByAccountState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbFilterByAccountState.FormattingEnabled = true;
            this.cbFilterByAccountState.Items.AddRange(new object[] {
            "All",
            "Active",
            "Frozen",
            "Closed"});
            this.cbFilterByAccountState.Location = new System.Drawing.Point(239, 15);
            this.cbFilterByAccountState.Name = "cbFilterByAccountState";
            this.cbFilterByAccountState.Size = new System.Drawing.Size(143, 31);
            this.cbFilterByAccountState.TabIndex = 11;
            this.cbFilterByAccountState.Visible = false;
            this.cbFilterByAccountState.SelectedIndexChanged += new System.EventHandler(this.cbFilterByAccountState_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Image = global::Bank.Properties.Resources.icons8_accounting_100;
            this.pictureBox1.Location = new System.Drawing.Point(419, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderRadius = 2;
            this.guna2Panel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.pictureBox1);
            this.guna2Panel1.Location = new System.Drawing.Point(295, 12);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.BorderRadius = 10;
            this.guna2Panel1.ShadowDecoration.Depth = 50;
            this.guna2Panel1.ShadowDecoration.Enabled = true;
            this.guna2Panel1.Size = new System.Drawing.Size(578, 114);
            this.guna2Panel1.TabIndex = 14;
            // 
            // frmListAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1135, 662);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.dgvAllAccounts);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmListAccounts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List Accounts";
            this.Load += new System.EventHandler(this.frmListAccounts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllAccounts)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvAllAccounts;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editAccount;
        private System.Windows.Forms.ToolStripMenuItem showAccountInformation;
        private System.Windows.Forms.ToolStripMenuItem deleteAccount;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.ComboBox cbFilterByAccountState;
    }
}