namespace Bank.Users
{
    partial class frmAddEditUser
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
            this.lblMain = new System.Windows.Forms.Label();
            this.lblSecondary = new System.Windows.Forms.Label();
            this.pnlHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.tcUserInfo = new System.Windows.Forms.TabPage();
            this.chlistPermission = new System.Windows.Forms.CheckedListBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblScorePassword = new System.Windows.Forms.Label();
            this.chboxIsActive = new System.Windows.Forms.CheckBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblUserID = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnEye = new Guna.UI2.WinForms.Guna2Button();
            this.txtConfirmPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tpClientInformation = new System.Windows.Forms.TabPage();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.ctrlClientCardInfoWithFilter1 = new Bank.Client.Controls.ctrlClientCardInfoWithFilter();
            this.tabControl = new Guna.UI2.WinForms.Guna2TabControl();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.tcUserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tpClientInformation.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.tabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMain
            // 
            this.lblMain.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMain.ForeColor = System.Drawing.Color.White;
            this.lblMain.Location = new System.Drawing.Point(504, 10);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(259, 42);
            this.lblMain.TabIndex = 6;
            this.lblMain.Text = "إضافة مستخدم جديد";
            this.lblMain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSecondary
            // 
            this.lblSecondary.AutoSize = true;
            this.lblSecondary.BackColor = System.Drawing.Color.Transparent;
            this.lblSecondary.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondary.ForeColor = System.Drawing.Color.Black;
            this.lblSecondary.Location = new System.Drawing.Point(22, 47);
            this.lblSecondary.Name = "lblSecondary";
            this.lblSecondary.Size = new System.Drawing.Size(315, 23);
            this.lblSecondary.TabIndex = 5;
            this.lblSecondary.Text = "أدخل بيانات المستخدم الجديد لإضافته في النظام";
            this.lblSecondary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlHeader
            // 
            this.pnlHeader.AutoSize = true;
            this.pnlHeader.BackColor = System.Drawing.Color.Transparent;
            this.pnlHeader.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.pnlHeader.BorderRadius = 20;
            this.pnlHeader.BorderThickness = 1;
            this.pnlHeader.Controls.Add(this.guna2PictureBox2);
            this.pnlHeader.Controls.Add(this.lblMain);
            this.pnlHeader.Controls.Add(this.lblSecondary);
            this.pnlHeader.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pnlHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlHeader.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.pnlHeader.Location = new System.Drawing.Point(12, 12);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.ShadowDecoration.Depth = 5;
            this.pnlHeader.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pnlHeader.Size = new System.Drawing.Size(831, 80);
            this.pnlHeader.TabIndex = 6;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Image = global::Bank.Properties.Resources.icons8_add_60;
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(769, 10);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(45, 42);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox2.TabIndex = 7;
            this.guna2PictureBox2.TabStop = false;
            // 
            // tcUserInfo
            // 
            this.tcUserInfo.Controls.Add(this.chlistPermission);
            this.tcUserInfo.Controls.Add(this.pictureBox4);
            this.tcUserInfo.Controls.Add(this.label2);
            this.tcUserInfo.Controls.Add(this.lblScorePassword);
            this.tcUserInfo.Controls.Add(this.chboxIsActive);
            this.tcUserInfo.Controls.Add(this.pictureBox3);
            this.tcUserInfo.Controls.Add(this.lblUserID);
            this.tcUserInfo.Controls.Add(this.pictureBox1);
            this.tcUserInfo.Controls.Add(this.label1);
            this.tcUserInfo.Controls.Add(this.btnSave);
            this.tcUserInfo.Controls.Add(this.btnEye);
            this.tcUserInfo.Controls.Add(this.txtConfirmPassword);
            this.tcUserInfo.Controls.Add(this.label11);
            this.tcUserInfo.Controls.Add(this.label6);
            this.tcUserInfo.Controls.Add(this.label4);
            this.tcUserInfo.Controls.Add(this.txtPassword);
            this.tcUserInfo.Controls.Add(this.txtUserName);
            this.tcUserInfo.Controls.Add(this.pictureBox9);
            this.tcUserInfo.Controls.Add(this.pictureBox5);
            this.tcUserInfo.Controls.Add(this.pictureBox2);
            this.tcUserInfo.Location = new System.Drawing.Point(4, 44);
            this.tcUserInfo.Name = "tcUserInfo";
            this.tcUserInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tcUserInfo.Size = new System.Drawing.Size(817, 466);
            this.tcUserInfo.TabIndex = 1;
            this.tcUserInfo.Text = "User Information";
            this.tcUserInfo.UseVisualStyleBackColor = true;
            // 
            // chlistPermission
            // 
            this.chlistPermission.FormattingEnabled = true;
            this.chlistPermission.Items.AddRange(new object[] {
            "Add and Edit Users",
            "Delete Users",
            "Show Users Information."});
            this.chlistPermission.Location = new System.Drawing.Point(322, 312);
            this.chlistPermission.Name = "chlistPermission";
            this.chlistPermission.Size = new System.Drawing.Size(223, 104);
            this.chlistPermission.TabIndex = 147;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Bank.Properties.Resources.icons8_user_rights_50;
            this.pictureBox4.Location = new System.Drawing.Point(262, 312);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(47, 41);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 146;
            this.pictureBox4.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 322);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 31);
            this.label2.TabIndex = 145;
            this.label2.Text = "Grant permissions:";
            // 
            // lblScorePassword
            // 
            this.lblScorePassword.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScorePassword.ForeColor = System.Drawing.Color.Red;
            this.lblScorePassword.Location = new System.Drawing.Point(408, 167);
            this.lblScorePassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScorePassword.Name = "lblScorePassword";
            this.lblScorePassword.Size = new System.Drawing.Size(137, 19);
            this.lblScorePassword.TabIndex = 144;
            this.lblScorePassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chboxIsActive
            // 
            this.chboxIsActive.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chboxIsActive.Location = new System.Drawing.Point(626, 312);
            this.chboxIsActive.Name = "chboxIsActive";
            this.chboxIsActive.Size = new System.Drawing.Size(150, 41);
            this.chboxIsActive.TabIndex = 143;
            this.chboxIsActive.Text = "Is Active ?";
            this.chboxIsActive.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Bank.Properties.Resources.icons8_active_50;
            this.pictureBox3.Location = new System.Drawing.Point(573, 312);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(47, 41);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 142;
            this.pictureBox3.TabStop = false;
            // 
            // lblUserID
            // 
            this.lblUserID.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.Location = new System.Drawing.Point(316, 47);
            this.lblUserID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(37, 41);
            this.lblUserID.TabIndex = 140;
            this.lblUserID.Text = "??";
            this.lblUserID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bank.Properties.Resources.icons8_contact_details_30;
            this.pictureBox1.Location = new System.Drawing.Point(262, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 139;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 34);
            this.label1.TabIndex = 138;
            this.label1.Text = "User ID:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSave
            // 
            this.btnSave.BorderRadius = 10;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.Black;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Variable Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(160)))), ((int)(((byte)(73)))));
            this.btnSave.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnSave.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSave.Location = new System.Drawing.Point(573, 382);
            this.btnSave.Name = "btnSave";
            this.btnSave.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            this.btnSave.ShadowDecoration.Depth = 15;
            this.btnSave.Size = new System.Drawing.Size(105, 45);
            this.btnSave.TabIndex = 137;
            this.btnSave.Text = "💾 حفظ ";
            this.btnSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEye
            // 
            this.btnEye.BorderColor = System.Drawing.Color.Blue;
            this.btnEye.BorderRadius = 30;
            this.btnEye.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEye.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEye.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEye.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEye.FillColor = System.Drawing.Color.Transparent;
            this.btnEye.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEye.ForeColor = System.Drawing.Color.Transparent;
            this.btnEye.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnEye.HoverState.ForeColor = System.Drawing.Color.Transparent;
            this.btnEye.Image = global::Bank.Properties.Resources.icons8_eye_48;
            this.btnEye.Location = new System.Drawing.Point(551, 255);
            this.btnEye.Name = "btnEye";
            this.btnEye.PressedColor = System.Drawing.Color.Transparent;
            this.btnEye.ShadowDecoration.BorderRadius = 60;
            this.btnEye.ShadowDecoration.Depth = 60;
            this.btnEye.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnEye.Size = new System.Drawing.Size(30, 30);
            this.btnEye.TabIndex = 136;
            this.btnEye.Click += new System.EventHandler(this.btnEye_Click);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BorderColor = System.Drawing.Color.Gray;
            this.txtConfirmPassword.BorderRadius = 10;
            this.txtConfirmPassword.BorderThickness = 2;
            this.txtConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConfirmPassword.DefaultText = "";
            this.txtConfirmPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtConfirmPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtConfirmPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConfirmPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConfirmPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txtConfirmPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtConfirmPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtConfirmPassword.Location = new System.Drawing.Point(315, 255);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.PlaceholderText = "";
            this.txtConfirmPassword.SelectedText = "";
            this.txtConfirmPassword.Size = new System.Drawing.Size(230, 30);
            this.txtConfirmPassword.TabIndex = 135;
            this.txtConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtConfirmPassword_Validating);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(16, 252);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(239, 31);
            this.label11.TabIndex = 133;
            this.label11.Text = "Confirm Password :";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(63, 180);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 40);
            this.label6.TabIndex = 130;
            this.label6.Text = "Password :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(102, 119);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 35);
            this.label4.TabIndex = 127;
            this.label4.Text = "User Name:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderColor = System.Drawing.Color.Gray;
            this.txtPassword.BorderRadius = 10;
            this.txtPassword.BorderThickness = 2;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Location = new System.Drawing.Point(315, 190);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.PlaceholderText = "";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(230, 30);
            this.txtPassword.TabIndex = 124;
            this.txtPassword.Tag = "UserName";
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassword_Validating);
            // 
            // txtUserName
            // 
            this.txtUserName.BorderColor = System.Drawing.Color.Gray;
            this.txtUserName.BorderRadius = 10;
            this.txtUserName.BorderThickness = 2;
            this.txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserName.DefaultText = "";
            this.txtUserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txtUserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtUserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserName.Location = new System.Drawing.Point(315, 126);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PlaceholderText = "";
            this.txtUserName.SelectedText = "";
            this.txtUserName.Size = new System.Drawing.Size(230, 30);
            this.txtUserName.TabIndex = 123;
            this.txtUserName.Tag = "Password";
            this.txtUserName.Validating += new System.ComponentModel.CancelEventHandler(this.txtUserName_Validating);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::Bank.Properties.Resources.icons8_show_password_60;
            this.pictureBox9.Location = new System.Drawing.Point(262, 252);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(47, 41);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 134;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Bank.Properties.Resources.icons8_password_50;
            this.pictureBox5.Location = new System.Drawing.Point(262, 181);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(47, 41);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 131;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Bank.Properties.Resources.icons8_name_tag_70;
            this.pictureBox2.Location = new System.Drawing.Point(262, 119);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 128;
            this.pictureBox2.TabStop = false;
            // 
            // tpClientInformation
            // 
            this.tpClientInformation.Controls.Add(this.guna2Panel1);
            this.tpClientInformation.Location = new System.Drawing.Point(4, 44);
            this.tpClientInformation.Name = "tpClientInformation";
            this.tpClientInformation.Padding = new System.Windows.Forms.Padding(3);
            this.tpClientInformation.Size = new System.Drawing.Size(817, 466);
            this.tpClientInformation.TabIndex = 0;
            this.tpClientInformation.Text = "Client Informatino";
            this.tpClientInformation.UseVisualStyleBackColor = true;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderRadius = 10;
            this.guna2Panel1.Controls.Add(this.ctrlClientCardInfoWithFilter1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Location = new System.Drawing.Point(3, 3);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Padding = new System.Windows.Forms.Padding(20);
            this.guna2Panel1.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.guna2Panel1.ShadowDecoration.CustomizableEdges.BottomLeft = false;
            this.guna2Panel1.ShadowDecoration.CustomizableEdges.BottomRight = false;
            this.guna2Panel1.ShadowDecoration.CustomizableEdges.TopLeft = false;
            this.guna2Panel1.ShadowDecoration.CustomizableEdges.TopRight = false;
            this.guna2Panel1.ShadowDecoration.Enabled = true;
            this.guna2Panel1.Size = new System.Drawing.Size(811, 460);
            this.guna2Panel1.TabIndex = 0;
            // 
            // ctrlClientCardInfoWithFilter1
            // 
            this.ctrlClientCardInfoWithFilter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ctrlClientCardInfoWithFilter1.ClientID = -1;
            this.ctrlClientCardInfoWithFilter1.FilterEnabled = true;
            this.ctrlClientCardInfoWithFilter1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlClientCardInfoWithFilter1.Location = new System.Drawing.Point(3, 3);
            this.ctrlClientCardInfoWithFilter1.Name = "ctrlClientCardInfoWithFilter1";
            this.ctrlClientCardInfoWithFilter1.NationalNo = "";
            this.ctrlClientCardInfoWithFilter1.Size = new System.Drawing.Size(805, 466);
            this.ctrlClientCardInfoWithFilter1.TabIndex = 0;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tpClientInformation);
            this.tabControl.Controls.Add(this.tcUserInfo);
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.ItemSize = new System.Drawing.Size(180, 40);
            this.tabControl.Location = new System.Drawing.Point(22, 127);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(825, 514);
            this.tabControl.TabButtonHoverState.BorderColor = System.Drawing.Color.Transparent;
            this.tabControl.TabButtonHoverState.FillColor = System.Drawing.Color.White;
            this.tabControl.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabControl.TabButtonHoverState.ForeColor = System.Drawing.Color.Black;
            this.tabControl.TabButtonHoverState.InnerColor = System.Drawing.Color.Black;
            this.tabControl.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tabControl.TabButtonIdleState.FillColor = System.Drawing.Color.White;
            this.tabControl.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabControl.TabButtonIdleState.ForeColor = System.Drawing.Color.Black;
            this.tabControl.TabButtonIdleState.InnerColor = System.Drawing.Color.Black;
            this.tabControl.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tabControl.TabButtonSelectedState.FillColor = System.Drawing.Color.Black;
            this.tabControl.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabControl.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tabControl.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tabControl.TabButtonSize = new System.Drawing.Size(180, 40);
            this.tabControl.TabButtonTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.tabControl.TabIndex = 1;
            this.tabControl.TabMenuBackColor = System.Drawing.Color.Transparent;
            this.tabControl.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnBack
            // 
            this.btnBack.BorderRadius = 10;
            this.btnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBack.FillColor = System.Drawing.Color.Red;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI Variable Display", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Image = global::Bank.Properties.Resources.icons8_back_50__1_;
            this.btnBack.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBack.ImageSize = new System.Drawing.Size(30, 30);
            this.btnBack.Location = new System.Drawing.Point(38, 649);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(132, 45);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            this.btnBack.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnBack.Visible = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.BorderRadius = 10;
            this.btnNext.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNext.FillColor = System.Drawing.Color.Red;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI Variable Display", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Image = global::Bank.Properties.Resources.icons8_next_64;
            this.btnNext.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnNext.ImageSize = new System.Drawing.Size(30, 30);
            this.btnNext.Location = new System.Drawing.Point(715, 649);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(132, 45);
            this.btnNext.TabIndex = 8;
            this.btnNext.Text = "Next";
            this.btnNext.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // frmAddEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(859, 700);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddEditUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New User";
            this.Load += new System.EventHandler(this.frmAddNewUser_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.tcUserInfo.ResumeLayout(false);
            this.tcUserInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tpClientInformation.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.Label lblSecondary;
        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private System.Windows.Forms.TabPage tcUserInfo;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnEye;
        private Guna.UI2.WinForms.Guna2TextBox txtConfirmPassword;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TabPage tpClientInformation;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Client.Controls.ctrlClientCardInfoWithFilter ctrlClientCardInfoWithFilter1;
        private Guna.UI2.WinForms.Guna2TabControl tabControl;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.CheckBox chboxIsActive;
        private System.Windows.Forms.Label lblScorePassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label2;
       // private System.Windows.Forms.ComboBox chPermission;
        private Guna.UI2.WinForms.Guna2TextBox txtUserName;
        private System.Windows.Forms.CheckedListBox chlistPermission;
    }
}