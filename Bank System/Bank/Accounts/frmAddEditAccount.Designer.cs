namespace Bank.Accounts
{
    partial class frmAddEditAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEditAccount));
            this.pnlHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.pbImageTitle = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.txtBalance = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cbAccountStatus = new System.Windows.Forms.ComboBox();
            this.cbAccountType = new System.Windows.Forms.ComboBox();
            this.txtAccountNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblUpdateAtDate = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2HtmlLabel13 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel17 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblAccountID = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel12 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFees = new System.Windows.Forms.Label();
            this.ctrlClientCardInfoWithFilter1 = new Bank.Client.Controls.ctrlClientCardInfoWithFilter();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageTitle)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.AutoSize = true;
            this.pnlHeader.BackColor = System.Drawing.Color.Transparent;
            this.pnlHeader.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.pnlHeader.BorderRadius = 20;
            this.pnlHeader.BorderThickness = 1;
            this.pnlHeader.Controls.Add(this.pbImageTitle);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnlHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlHeader.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.pnlHeader.Location = new System.Drawing.Point(14, 21);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(2);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.ShadowDecoration.BorderRadius = 20;
            this.pnlHeader.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlHeader.ShadowDecoration.Depth = 60;
            this.pnlHeader.ShadowDecoration.Enabled = true;
            this.pnlHeader.Size = new System.Drawing.Size(1082, 104);
            this.pnlHeader.TabIndex = 6;
            // 
            // pbImageTitle
            // 
            this.pbImageTitle.FillColor = System.Drawing.Color.Black;
            this.pbImageTitle.Image = ((System.Drawing.Image)(resources.GetObject("pbImageTitle.Image")));
            this.pbImageTitle.ImageRotate = 0F;
            this.pbImageTitle.Location = new System.Drawing.Point(969, 2);
            this.pbImageTitle.Margin = new System.Windows.Forms.Padding(2);
            this.pbImageTitle.Name = "pbImageTitle";
            this.pbImageTitle.Size = new System.Drawing.Size(100, 100);
            this.pbImageTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbImageTitle.TabIndex = 7;
            this.pbImageTitle.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Maroon;
            this.lblTitle.Location = new System.Drawing.Point(573, 17);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(393, 60);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "إضافة حساب جديد";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.guna2Panel2.BorderThickness = 1;
            this.guna2Panel2.Controls.Add(this.txtBalance);
            this.guna2Panel2.Controls.Add(this.pictureBox2);
            this.guna2Panel2.Controls.Add(this.cbAccountStatus);
            this.guna2Panel2.Controls.Add(this.cbAccountType);
            this.guna2Panel2.Controls.Add(this.txtAccountNumber);
            this.guna2Panel2.Controls.Add(this.lblUpdateAtDate);
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel3);
            this.guna2Panel2.Controls.Add(this.pictureBox5);
            this.guna2Panel2.Controls.Add(this.pictureBox6);
            this.guna2Panel2.Controls.Add(this.pictureBox7);
            this.guna2Panel2.Controls.Add(this.pictureBox4);
            this.guna2Panel2.Controls.Add(this.pictureBox1);
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel13);
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel2);
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel5);
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel17);
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel2.Controls.Add(this.lblAccountID);
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel4);
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel6);
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel7);
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel12);
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.guna2Panel2.Location = new System.Drawing.Point(795, 175);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Padding = new System.Windows.Forms.Padding(20);
            this.guna2Panel2.ShadowDecoration.Color = System.Drawing.Color.Maroon;
            this.guna2Panel2.ShadowDecoration.Depth = 60;
            this.guna2Panel2.ShadowDecoration.Enabled = true;
            this.guna2Panel2.Size = new System.Drawing.Size(322, 528);
            this.guna2Panel2.TabIndex = 8;
            // 
            // txtBalance
            // 
            this.txtBalance.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBalance.DefaultText = "";
            this.txtBalance.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBalance.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBalance.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBalance.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBalance.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBalance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalance.ForeColor = System.Drawing.Color.Maroon;
            this.txtBalance.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBalance.Location = new System.Drawing.Point(111, 299);
            this.txtBalance.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.PlaceholderForeColor = System.Drawing.Color.Maroon;
            this.txtBalance.PlaceholderText = "";
            this.txtBalance.SelectedText = "";
            this.txtBalance.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtBalance.ShadowDecoration.Enabled = true;
            this.txtBalance.Size = new System.Drawing.Size(177, 31);
            this.txtBalance.TabIndex = 198;
            this.txtBalance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBalance_KeyPress_1);
            this.txtBalance.Validating += new System.ComponentModel.CancelEventHandler(this.txtBalance_Validating);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(6, 411);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 197;
            this.pictureBox2.TabStop = false;
            // 
            // cbAccountStatus
            // 
            this.cbAccountStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbAccountStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cbAccountStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAccountStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbAccountStatus.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAccountStatus.ForeColor = System.Drawing.Color.Black;
            this.cbAccountStatus.FormattingEnabled = true;
            this.cbAccountStatus.Items.AddRange(new object[] {
            "Active",
            "Closed",
            "Frozen"});
            this.cbAccountStatus.Location = new System.Drawing.Point(130, 389);
            this.cbAccountStatus.Name = "cbAccountStatus";
            this.cbAccountStatus.Size = new System.Drawing.Size(177, 31);
            this.cbAccountStatus.TabIndex = 196;
            // 
            // cbAccountType
            // 
            this.cbAccountType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbAccountType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cbAccountType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAccountType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbAccountType.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAccountType.ForeColor = System.Drawing.Color.Black;
            this.cbAccountType.FormattingEnabled = true;
            this.cbAccountType.Items.AddRange(new object[] {
            "BASIC SAVINGS",
            "PREMIUM SAVINGS",
            "GOLD SAVINGS "});
            this.cbAccountType.Location = new System.Drawing.Point(130, 236);
            this.cbAccountType.Name = "cbAccountType";
            this.cbAccountType.Size = new System.Drawing.Size(169, 31);
            this.cbAccountType.TabIndex = 195;
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAccountNumber.DefaultText = "";
            this.txtAccountNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAccountNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAccountNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAccountNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAccountNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAccountNumber.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtAccountNumber.ForeColor = System.Drawing.Color.Maroon;
            this.txtAccountNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAccountNumber.Location = new System.Drawing.Point(111, 155);
            this.txtAccountNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.PlaceholderForeColor = System.Drawing.Color.Maroon;
            this.txtAccountNumber.PlaceholderText = "";
            this.txtAccountNumber.SelectedText = "";
            this.txtAccountNumber.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtAccountNumber.ShadowDecoration.Enabled = true;
            this.txtAccountNumber.Size = new System.Drawing.Size(177, 31);
            this.txtAccountNumber.TabIndex = 193;
            this.txtAccountNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAccountNumber_KeyPress);
            this.txtAccountNumber.Validating += new System.ComponentModel.CancelEventHandler(this.txtAccountNumber_Validating);
            // 
            // lblUpdateAtDate
            // 
            this.lblUpdateAtDate.AutoSize = false;
            this.lblUpdateAtDate.BackColor = System.Drawing.Color.Transparent;
            this.lblUpdateAtDate.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateAtDate.ForeColor = System.Drawing.Color.Maroon;
            this.lblUpdateAtDate.Location = new System.Drawing.Point(18, 455);
            this.lblUpdateAtDate.Name = "lblUpdateAtDate";
            this.lblUpdateAtDate.Size = new System.Drawing.Size(270, 59);
            this.lblUpdateAtDate.TabIndex = 192;
            this.lblUpdateAtDate.Text = "????";
            this.lblUpdateAtDate.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.AutoSize = false;
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(39, 343);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(205, 25);
            this.guna2HtmlLabel3.TabIndex = 189;
            this.guna2HtmlLabel3.Text = "Account Status:";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(6, 115);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(28, 38);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 179;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(6, 182);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(28, 36);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 184;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(6, 258);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(28, 34);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 183;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(6, 334);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(28, 34);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 181;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 178;
            this.pictureBox1.TabStop = false;
            // 
            // guna2HtmlLabel13
            // 
            this.guna2HtmlLabel13.AutoSize = false;
            this.guna2HtmlLabel13.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel13.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel13.ForeColor = System.Drawing.Color.DarkGreen;
            this.guna2HtmlLabel13.Location = new System.Drawing.Point(21, 12);
            this.guna2HtmlLabel13.Name = "guna2HtmlLabel13";
            this.guna2HtmlLabel13.Size = new System.Drawing.Size(323, 26);
            this.guna2HtmlLabel13.TabIndex = 177;
            this.guna2HtmlLabel13.Text = "The Account Information : ";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.AutoSize = false;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Stencil", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.Gold;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(18, 36);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(283, 28);
            this.guna2HtmlLabel2.TabIndex = 176;
            this.guna2HtmlLabel2.Text = "---------------------------------------------------------------------------------" +
    "-------------------------------------------------------------";
            this.guna2HtmlLabel2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixel;
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.AutoSize = false;
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(40, 70);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(119, 26);
            this.guna2HtmlLabel5.TabIndex = 158;
            this.guna2HtmlLabel5.Text = "Account ID : ";
            // 
            // guna2HtmlLabel17
            // 
            this.guna2HtmlLabel17.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel17.Location = new System.Drawing.Point(124, 80);
            this.guna2HtmlLabel17.Name = "guna2HtmlLabel17";
            this.guna2HtmlLabel17.Size = new System.Drawing.Size(3, 2);
            this.guna2HtmlLabel17.TabIndex = 167;
            this.guna2HtmlLabel17.Text = null;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(40, 115);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(204, 38);
            this.guna2HtmlLabel1.TabIndex = 154;
            this.guna2HtmlLabel1.Text = "Account Number:";
            this.guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAccountID
            // 
            this.lblAccountID.AutoSize = false;
            this.lblAccountID.BackColor = System.Drawing.Color.Transparent;
            this.lblAccountID.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountID.ForeColor = System.Drawing.Color.Maroon;
            this.lblAccountID.Location = new System.Drawing.Point(165, 70);
            this.lblAccountID.Name = "lblAccountID";
            this.lblAccountID.Size = new System.Drawing.Size(136, 31);
            this.lblAccountID.TabIndex = 170;
            this.lblAccountID.Text = "????";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.AutoSize = false;
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(40, 411);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(155, 38);
            this.guna2HtmlLabel4.TabIndex = 157;
            this.guna2HtmlLabel4.Text = "Update At Date:";
            this.guna2HtmlLabel4.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.AutoSize = false;
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(40, 182);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(145, 38);
            this.guna2HtmlLabel6.TabIndex = 159;
            this.guna2HtmlLabel6.Text = "Account Type:";
            this.guna2HtmlLabel6.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.AutoSize = false;
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(40, 258);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(102, 34);
            this.guna2HtmlLabel7.TabIndex = 163;
            this.guna2HtmlLabel7.Text = "Balance:";
            this.guna2HtmlLabel7.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2HtmlLabel12
            // 
            this.guna2HtmlLabel12.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel12.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel12.Location = new System.Drawing.Point(603, 291);
            this.guna2HtmlLabel12.Name = "guna2HtmlLabel12";
            this.guna2HtmlLabel12.Size = new System.Drawing.Size(3, 2);
            this.guna2HtmlLabel12.TabIndex = 164;
            this.guna2HtmlLabel12.Text = null;
            // 
            // btnSave
            // 
            this.btnSave.Animated = true;
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BorderColor = System.Drawing.Color.White;
            this.btnSave.BorderRadius = 12;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSave.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSave.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(971, 709);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSave.ShadowDecoration.Depth = 60;
            this.btnSave.ShadowDecoration.Enabled = true;
            this.btnSave.Size = new System.Drawing.Size(146, 50);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.LightGray;
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.lblFees);
            this.guna2Panel1.Location = new System.Drawing.Point(128, 682);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.BorderRadius = 0;
            this.guna2Panel1.ShadowDecoration.Depth = 100;
            this.guna2Panel1.ShadowDecoration.Enabled = true;
            this.guna2Panel1.Size = new System.Drawing.Size(566, 81);
            this.guna2Panel1.TabIndex = 18;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(206, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(308, 43);
            this.label2.TabIndex = 19;
            this.label2.Text = ":رسوم إنشاء حساب جديد";
            // 
            // lblFees
            // 
            this.lblFees.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFees.Location = new System.Drawing.Point(105, 18);
            this.lblFees.Name = "lblFees";
            this.lblFees.Size = new System.Drawing.Size(108, 40);
            this.lblFees.TabIndex = 18;
            this.lblFees.Text = "label1";
            // 
            // ctrlClientCardInfoWithFilter1
            // 
            this.ctrlClientCardInfoWithFilter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ctrlClientCardInfoWithFilter1.ClientID = -1;
            this.ctrlClientCardInfoWithFilter1.FilterEnabled = true;
            this.ctrlClientCardInfoWithFilter1.Location = new System.Drawing.Point(14, 175);
            this.ctrlClientCardInfoWithFilter1.Name = "ctrlClientCardInfoWithFilter1";
            this.ctrlClientCardInfoWithFilter1.NationalNo = "";
            this.ctrlClientCardInfoWithFilter1.Size = new System.Drawing.Size(775, 528);
            this.ctrlClientCardInfoWithFilter1.TabIndex = 7;
            this.ctrlClientCardInfoWithFilter1.OnSelectedClient += new System.Action<int>(this.ctrlClientCardInfoWithFilter1_OnSelectedClient_1);
            // 
            // frmAddEditAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1129, 771);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.ctrlClientCardInfoWithFilter1);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddEditAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Edit Account";
            this.Load += new System.EventHandler(this.frmAddEditAccount_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageTitle)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private Guna.UI2.WinForms.Guna2PictureBox pbImageTitle;
        private System.Windows.Forms.Label lblTitle;
        private Client.Controls.ctrlClientCardInfoWithFilter ctrlClientCardInfoWithFilter1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel13;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel17;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblAccountID;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel12;
        private Guna.UI2.WinForms.Guna2TextBox txtAccountNumber;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblUpdateAtDate;
        private System.Windows.Forms.ComboBox cbAccountType;
        private System.Windows.Forms.ComboBox cbAccountStatus;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2TextBox txtBalance;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFees;
    }
}