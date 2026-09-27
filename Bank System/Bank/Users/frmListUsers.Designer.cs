namespace Bank.Users
{
    partial class frmListUsers
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
            this.pnlHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddNewUser = new Guna.UI2.WinForms.Guna2Button();
            this.dgvAllUsers = new Guna.UI2.WinForms.Guna2DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editUserItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showUserInfoItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteUserItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtFilterValue = new System.Windows.Forms.TextBox();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbFilterByIsAdmin = new System.Windows.Forms.ComboBox();
            this.cbFilterByIsActive = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllUsers)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Transparent;
            this.pnlHeader.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.pnlHeader.BorderRadius = 20;
            this.pnlHeader.BorderThickness = 1;
            this.pnlHeader.Controls.Add(this.label3);
            this.pnlHeader.Controls.Add(this.label2);
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pnlHeader.Location = new System.Drawing.Point(12, 44);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.ShadowDecoration.Depth = 5;
            this.pnlHeader.ShadowDecoration.Enabled = true;
            this.pnlHeader.Size = new System.Drawing.Size(724, 98);
            this.pnlHeader.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(409, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 54);
            this.label3.TabIndex = 2;
            this.label3.Text = "المستخدمين";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(17, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "عرض وتعديل بيانات المستخدمين";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(609, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "إدارة";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.BorderRadius = 10;
            this.btnAddNewUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNewUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddNewUser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAddNewUser.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewUser.ForeColor = System.Drawing.Color.White;
            this.btnAddNewUser.Location = new System.Drawing.Point(663, 6);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Size = new System.Drawing.Size(204, 40);
            this.btnAddNewUser.TabIndex = 1;
            this.btnAddNewUser.Text = "إضافة مستخدم جديد ✚";
            this.btnAddNewUser.Click += new System.EventHandler(this.btnAddNewUser_Click);
            // 
            // dgvAllUsers
            // 
            this.dgvAllUsers.AllowUserToAddRows = false;
            this.dgvAllUsers.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvAllUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAllUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.dgvAllUsers.BackgroundColor = System.Drawing.Color.Black;
            this.dgvAllUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAllUsers.ColumnHeadersHeight = 45;
            this.dgvAllUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvAllUsers.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAllUsers.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAllUsers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.dgvAllUsers.Location = new System.Drawing.Point(59, 266);
            this.dgvAllUsers.Name = "dgvAllUsers";
            this.dgvAllUsers.ReadOnly = true;
            this.dgvAllUsers.RowHeadersVisible = false;
            this.dgvAllUsers.RowHeadersWidth = 51;
            this.dgvAllUsers.RowTemplate.DividerHeight = 2;
            this.dgvAllUsers.RowTemplate.Height = 36;
            this.dgvAllUsers.Size = new System.Drawing.Size(785, 304);
            this.dgvAllUsers.TabIndex = 12;
            this.dgvAllUsers.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAllUsers.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvAllUsers.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvAllUsers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvAllUsers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvAllUsers.ThemeStyle.BackColor = System.Drawing.Color.Black;
            this.dgvAllUsers.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.dgvAllUsers.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Black;
            this.dgvAllUsers.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvAllUsers.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAllUsers.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvAllUsers.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvAllUsers.ThemeStyle.HeaderStyle.Height = 45;
            this.dgvAllUsers.ThemeStyle.ReadOnly = true;
            this.dgvAllUsers.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAllUsers.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAllUsers.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAllUsers.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvAllUsers.ThemeStyle.RowsStyle.Height = 36;
            this.dgvAllUsers.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvAllUsers.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI Variable Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editUserItem,
            this.showUserInfoItem,
            this.deleteUserItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(280, 112);
            // 
            // editUserItem
            // 
            this.editUserItem.Image = global::Bank.Properties.Resources.icons8_edit_30;
            this.editUserItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editUserItem.Name = "editUserItem";
            this.editUserItem.Size = new System.Drawing.Size(279, 36);
            this.editUserItem.Text = "Edit User";
            this.editUserItem.Click += new System.EventHandler(this.editUserItem_Click);
            // 
            // showUserInfoItem
            // 
            this.showUserInfoItem.Image = global::Bank.Properties.Resources.icons8_contact_details_30;
            this.showUserInfoItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showUserInfoItem.Name = "showUserInfoItem";
            this.showUserInfoItem.Size = new System.Drawing.Size(279, 36);
            this.showUserInfoItem.Text = "Show User Information";
            this.showUserInfoItem.Click += new System.EventHandler(this.showUserInfoItem_Click);
            // 
            // deleteUserItem
            // 
            this.deleteUserItem.Image = global::Bank.Properties.Resources.icons8_delete_30;
            this.deleteUserItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteUserItem.Name = "deleteUserItem";
            this.deleteUserItem.Size = new System.Drawing.Size(279, 36);
            this.deleteUserItem.Text = "Delete User";
            this.deleteUserItem.Click += new System.EventHandler(this.deleteUserItem_Click);
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.txtFilterValue.BackColor = System.Drawing.Color.Gainsboro;
            this.txtFilterValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilterValue.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtFilterValue.Location = new System.Drawing.Point(228, 14);
            this.txtFilterValue.Multiline = true;
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.Size = new System.Drawing.Size(202, 31);
            this.txtFilterValue.TabIndex = 9;
            this.txtFilterValue.Visible = false;
            this.txtFilterValue.TextChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
            this.txtFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterValue_KeyPress);
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbFilterBy.BackColor = System.Drawing.Color.Gainsboro;
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBy.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbFilterBy.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Items.AddRange(new object[] {
            "None",
            "User ID",
            "Full Name",
            "User Name",
            "Is Active",
            "User Role"});
            this.cbFilterBy.Location = new System.Drawing.Point(9, 14);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(203, 31);
            this.cbFilterBy.TabIndex = 8;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbFilterByIsAdmin);
            this.panel1.Controls.Add(this.cbFilterByIsActive);
            this.panel1.Controls.Add(this.txtFilterValue);
            this.panel1.Controls.Add(this.cbFilterBy);
            this.panel1.Controls.Add(this.btnAddNewUser);
            this.panel1.Location = new System.Drawing.Point(14, 192);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(6);
            this.panel1.Size = new System.Drawing.Size(896, 57);
            this.panel1.TabIndex = 13;
            // 
            // cbFilterByIsAdmin
            // 
            this.cbFilterByIsAdmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbFilterByIsAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.cbFilterByIsAdmin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterByIsAdmin.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbFilterByIsAdmin.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterByIsAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbFilterByIsAdmin.FormattingEnabled = true;
            this.cbFilterByIsAdmin.Items.AddRange(new object[] {
            "All",
            "Admin User",
            "Regular User"});
            this.cbFilterByIsAdmin.Location = new System.Drawing.Point(228, 13);
            this.cbFilterByIsAdmin.Name = "cbFilterByIsAdmin";
            this.cbFilterByIsAdmin.Size = new System.Drawing.Size(143, 31);
            this.cbFilterByIsAdmin.TabIndex = 11;
            this.cbFilterByIsAdmin.Visible = false;
            this.cbFilterByIsAdmin.SelectedIndexChanged += new System.EventHandler(this.cbFilterByIsAdmin_SelectedIndexChanged);
            // 
            // cbFilterByIsActive
            // 
            this.cbFilterByIsActive.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbFilterByIsActive.BackColor = System.Drawing.Color.Gainsboro;
            this.cbFilterByIsActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterByIsActive.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbFilterByIsActive.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterByIsActive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbFilterByIsActive.FormattingEnabled = true;
            this.cbFilterByIsActive.Items.AddRange(new object[] {
            "All",
            "Is Active",
            "Is Not Active"});
            this.cbFilterByIsActive.Location = new System.Drawing.Point(228, 15);
            this.cbFilterByIsActive.Name = "cbFilterByIsActive";
            this.cbFilterByIsActive.Size = new System.Drawing.Size(143, 31);
            this.cbFilterByIsActive.TabIndex = 10;
            this.cbFilterByIsActive.Visible = false;
            this.cbFilterByIsActive.SelectedIndexChanged += new System.EventHandler(this.cbFilterByIsActive_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = global::Bank.Properties.Resources.icons8_users_96;
            this.pictureBox1.Location = new System.Drawing.Point(742, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // frmListUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(922, 582);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.dgvAllUsers);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmListUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List Users";
            this.Load += new System.EventHandler(this.frmListUsers_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllUsers)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnAddNewUser;
        private Guna.UI2.WinForms.Guna2DataGridView dgvAllUsers;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editUserItem;
        private System.Windows.Forms.ToolStripMenuItem showUserInfoItem;
        private System.Windows.Forms.ToolStripMenuItem deleteUserItem;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbFilterByIsAdmin;
        private System.Windows.Forms.ComboBox cbFilterByIsActive;
    }
}