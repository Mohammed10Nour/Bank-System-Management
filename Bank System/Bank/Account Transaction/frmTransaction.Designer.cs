namespace Bank.Account_Transaction
{
    partial class frmWithDraw_Deposit
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
            this.lblTransactionName = new System.Windows.Forms.Label();
            this.pbImageTransaction = new System.Windows.Forms.PictureBox();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.gbDeposit = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtDeposit = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbInternalTransfer = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtAccountNumberForInternal = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtInternal = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gbExternalTransfer = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtIBAM = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAccountNumberForExternal = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtExteranal = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbWithDraw = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtWithdraw = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAmountWithDraw = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.lblFees = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ctrlAccountTransactionInfo1 = new Bank.Accounts.Controls.ctrlAccountTransactionInfo();
            this.ctrlAccountCardInfoWithFilter1 = new Bank.Accounts.Controls.ctrlAccountCardInfoWithFilter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbImageTransaction)).BeginInit();
            this.gbDeposit.SuspendLayout();
            this.gbInternalTransfer.SuspendLayout();
            this.gbExternalTransfer.SuspendLayout();
            this.gbWithDraw.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTransactionName
            // 
            this.lblTransactionName.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactionName.ForeColor = System.Drawing.Color.Red;
            this.lblTransactionName.Location = new System.Drawing.Point(243, 6);
            this.lblTransactionName.Name = "lblTransactionName";
            this.lblTransactionName.Size = new System.Drawing.Size(1362, 48);
            this.lblTransactionName.TabIndex = 5;
            this.lblTransactionName.Text = "Freeze Account";
            this.lblTransactionName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pbImageTransaction
            // 
            this.pbImageTransaction.Image = global::Bank.Properties.Resources.left_right;
            this.pbImageTransaction.Location = new System.Drawing.Point(1624, 0);
            this.pbImageTransaction.Name = "pbImageTransaction";
            this.pbImageTransaction.Size = new System.Drawing.Size(183, 94);
            this.pbImageTransaction.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImageTransaction.TabIndex = 3;
            this.pbImageTransaction.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BorderColor = System.Drawing.Color.White;
            this.btnSave.BorderRadius = 12;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.Navy;
            this.btnSave.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverState.FillColor = System.Drawing.Color.Blue;
            this.btnSave.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(964, 871);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSave.ShadowDecoration.Depth = 60;
            this.btnSave.ShadowDecoration.Enabled = true;
            this.btnSave.Size = new System.Drawing.Size(114, 58);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "SAVE";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gbDeposit
            // 
            this.gbDeposit.BorderColor = System.Drawing.Color.Black;
            this.gbDeposit.BorderRadius = 5;
            this.gbDeposit.Controls.Add(this.txtDeposit);
            this.gbDeposit.Controls.Add(this.label4);
            this.gbDeposit.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gbDeposit.CustomBorderThickness = new System.Windows.Forms.Padding(2, 35, 2, 2);
            this.gbDeposit.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDeposit.ForeColor = System.Drawing.Color.Yellow;
            this.gbDeposit.Location = new System.Drawing.Point(1130, 76);
            this.gbDeposit.Name = "gbDeposit";
            this.gbDeposit.Size = new System.Drawing.Size(422, 91);
            this.gbDeposit.TabIndex = 21;
            this.gbDeposit.Text = "Deposit";
            // 
            // txtDeposit
            // 
            this.txtDeposit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDeposit.DefaultText = "";
            this.txtDeposit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDeposit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDeposit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDeposit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDeposit.FillColor = System.Drawing.Color.Black;
            this.txtDeposit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDeposit.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeposit.ForeColor = System.Drawing.Color.White;
            this.txtDeposit.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDeposit.Location = new System.Drawing.Point(21, 50);
            this.txtDeposit.Margin = new System.Windows.Forms.Padding(2, 6, 2, 6);
            this.txtDeposit.Name = "txtDeposit";
            this.txtDeposit.PlaceholderText = "";
            this.txtDeposit.SelectedText = "";
            this.txtDeposit.Size = new System.Drawing.Size(155, 34);
            this.txtDeposit.TabIndex = 5;
            this.txtDeposit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AllTexts_KeyPress);
            this.txtDeposit.Validating += new System.ComponentModel.CancelEventHandler(this.AllTexts_Validating);
            this.txtDeposit.Validated += new System.EventHandler(this.ValidateAmount_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(181, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(235, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = ": أدخل المبلغ لإيداعه في حسابك";
            // 
            // gbInternalTransfer
            // 
            this.gbInternalTransfer.BorderColor = System.Drawing.Color.Black;
            this.gbInternalTransfer.BorderRadius = 5;
            this.gbInternalTransfer.Controls.Add(this.txtAccountNumberForInternal);
            this.gbInternalTransfer.Controls.Add(this.label5);
            this.gbInternalTransfer.Controls.Add(this.txtInternal);
            this.gbInternalTransfer.Controls.Add(this.label6);
            this.gbInternalTransfer.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gbInternalTransfer.CustomBorderThickness = new System.Windows.Forms.Padding(2, 35, 2, 2);
            this.gbInternalTransfer.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInternalTransfer.ForeColor = System.Drawing.Color.Yellow;
            this.gbInternalTransfer.Location = new System.Drawing.Point(1130, 348);
            this.gbInternalTransfer.Name = "gbInternalTransfer";
            this.gbInternalTransfer.Size = new System.Drawing.Size(422, 221);
            this.gbInternalTransfer.TabIndex = 22;
            this.gbInternalTransfer.Text = "Internal Transfer";
            // 
            // txtAccountNumberForInternal
            // 
            this.txtAccountNumberForInternal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAccountNumberForInternal.DefaultText = "";
            this.txtAccountNumberForInternal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAccountNumberForInternal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAccountNumberForInternal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAccountNumberForInternal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAccountNumberForInternal.FillColor = System.Drawing.Color.Black;
            this.txtAccountNumberForInternal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAccountNumberForInternal.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountNumberForInternal.ForeColor = System.Drawing.Color.White;
            this.txtAccountNumberForInternal.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAccountNumberForInternal.Location = new System.Drawing.Point(8, 125);
            this.txtAccountNumberForInternal.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtAccountNumberForInternal.Name = "txtAccountNumberForInternal";
            this.txtAccountNumberForInternal.PlaceholderText = "";
            this.txtAccountNumberForInternal.SelectedText = "";
            this.txtAccountNumberForInternal.Size = new System.Drawing.Size(155, 34);
            this.txtAccountNumberForInternal.TabIndex = 11;
            this.txtAccountNumberForInternal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AllTexts_KeyPress);
            this.txtAccountNumberForInternal.Validating += new System.ComponentModel.CancelEventHandler(this.txtAccountNumberForInternal_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(54, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(339, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = ": أدخل رقم الحساب الذي تريد تحويل المبلغ إليه";
            // 
            // txtInternal
            // 
            this.txtInternal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInternal.DefaultText = "";
            this.txtInternal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtInternal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtInternal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInternal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInternal.FillColor = System.Drawing.Color.Black;
            this.txtInternal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInternal.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInternal.ForeColor = System.Drawing.Color.White;
            this.txtInternal.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInternal.Location = new System.Drawing.Point(8, 49);
            this.txtInternal.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtInternal.Name = "txtInternal";
            this.txtInternal.PlaceholderText = "";
            this.txtInternal.SelectedText = "";
            this.txtInternal.Size = new System.Drawing.Size(155, 34);
            this.txtInternal.TabIndex = 9;
            this.txtInternal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AllTexts_KeyPress);
            this.txtInternal.Validating += new System.ComponentModel.CancelEventHandler(this.AllTexts_Validating);
            this.txtInternal.Validated += new System.EventHandler(this.ValidateAmount_Validated);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(169, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(224, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = ": أدخل المبلغ الذي تريد تحويله";
            // 
            // gbExternalTransfer
            // 
            this.gbExternalTransfer.BorderColor = System.Drawing.Color.Black;
            this.gbExternalTransfer.BorderRadius = 5;
            this.gbExternalTransfer.Controls.Add(this.txtIBAM);
            this.gbExternalTransfer.Controls.Add(this.label8);
            this.gbExternalTransfer.Controls.Add(this.txtAccountNumberForExternal);
            this.gbExternalTransfer.Controls.Add(this.label3);
            this.gbExternalTransfer.Controls.Add(this.txtExteranal);
            this.gbExternalTransfer.Controls.Add(this.label2);
            this.gbExternalTransfer.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gbExternalTransfer.CustomBorderThickness = new System.Windows.Forms.Padding(2, 35, 2, 2);
            this.gbExternalTransfer.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbExternalTransfer.ForeColor = System.Drawing.Color.Yellow;
            this.gbExternalTransfer.Location = new System.Drawing.Point(1130, 591);
            this.gbExternalTransfer.Name = "gbExternalTransfer";
            this.gbExternalTransfer.Size = new System.Drawing.Size(422, 221);
            this.gbExternalTransfer.TabIndex = 23;
            this.gbExternalTransfer.Text = "External Transfer";
            // 
            // txtIBAM
            // 
            this.txtIBAM.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIBAM.DefaultText = "";
            this.txtIBAM.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIBAM.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIBAM.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIBAM.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIBAM.FillColor = System.Drawing.Color.Black;
            this.txtIBAM.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIBAM.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIBAM.ForeColor = System.Drawing.Color.White;
            this.txtIBAM.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIBAM.Location = new System.Drawing.Point(234, 107);
            this.txtIBAM.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtIBAM.Name = "txtIBAM";
            this.txtIBAM.PlaceholderText = "";
            this.txtIBAM.SelectedText = "";
            this.txtIBAM.Size = new System.Drawing.Size(155, 34);
            this.txtIBAM.TabIndex = 9;
            this.txtIBAM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AllTexts_KeyPress);
            this.txtIBAM.Validating += new System.ComponentModel.CancelEventHandler(this.AllTexts_Validating);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(16, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(224, 34);
            this.label8.TabIndex = 8;
            this.label8.Text = "Enter the Bank IBAM:";
            // 
            // txtAccountNumberForExternal
            // 
            this.txtAccountNumberForExternal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAccountNumberForExternal.DefaultText = "";
            this.txtAccountNumberForExternal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAccountNumberForExternal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAccountNumberForExternal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAccountNumberForExternal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAccountNumberForExternal.FillColor = System.Drawing.Color.Black;
            this.txtAccountNumberForExternal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAccountNumberForExternal.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountNumberForExternal.ForeColor = System.Drawing.Color.White;
            this.txtAccountNumberForExternal.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAccountNumberForExternal.Location = new System.Drawing.Point(21, 179);
            this.txtAccountNumberForExternal.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtAccountNumberForExternal.Name = "txtAccountNumberForExternal";
            this.txtAccountNumberForExternal.PlaceholderText = "";
            this.txtAccountNumberForExternal.SelectedText = "";
            this.txtAccountNumberForExternal.Size = new System.Drawing.Size(155, 34);
            this.txtAccountNumberForExternal.TabIndex = 7;
            this.txtAccountNumberForExternal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AllTexts_KeyPress);
            this.txtAccountNumberForExternal.Validating += new System.ComponentModel.CancelEventHandler(this.AllTexts_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(78, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(339, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = ": أدخل رقم الحساب الذي تريد تحويل المبلغ إليه";
            // 
            // txtExteranal
            // 
            this.txtExteranal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtExteranal.DefaultText = "";
            this.txtExteranal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtExteranal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtExteranal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtExteranal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtExteranal.FillColor = System.Drawing.Color.Black;
            this.txtExteranal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtExteranal.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExteranal.ForeColor = System.Drawing.Color.White;
            this.txtExteranal.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtExteranal.Location = new System.Drawing.Point(21, 50);
            this.txtExteranal.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtExteranal.Name = "txtExteranal";
            this.txtExteranal.PlaceholderText = "";
            this.txtExteranal.SelectedText = "";
            this.txtExteranal.Size = new System.Drawing.Size(155, 34);
            this.txtExteranal.TabIndex = 5;
            this.txtExteranal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AllTexts_KeyPress);
            this.txtExteranal.Validating += new System.ComponentModel.CancelEventHandler(this.AllTexts_Validating);
            this.txtExteranal.Validated += new System.EventHandler(this.ValidateAmount_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(193, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = ": أدخل المبلغ الذي تريد تحويله";
            // 
            // gbWithDraw
            // 
            this.gbWithDraw.BorderColor = System.Drawing.Color.Black;
            this.gbWithDraw.BorderRadius = 5;
            this.gbWithDraw.Controls.Add(this.txtWithdraw);
            this.gbWithDraw.Controls.Add(this.txtAmountWithDraw);
            this.gbWithDraw.Controls.Add(this.label1);
            this.gbWithDraw.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gbWithDraw.CustomBorderThickness = new System.Windows.Forms.Padding(2, 35, 2, 2);
            this.gbWithDraw.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbWithDraw.ForeColor = System.Drawing.Color.Yellow;
            this.gbWithDraw.Location = new System.Drawing.Point(1130, 211);
            this.gbWithDraw.Name = "gbWithDraw";
            this.gbWithDraw.Size = new System.Drawing.Size(422, 91);
            this.gbWithDraw.TabIndex = 24;
            this.gbWithDraw.Text = "WithDraw";
            // 
            // txtWithdraw
            // 
            this.txtWithdraw.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtWithdraw.DefaultText = "";
            this.txtWithdraw.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtWithdraw.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtWithdraw.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtWithdraw.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtWithdraw.FillColor = System.Drawing.Color.Black;
            this.txtWithdraw.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtWithdraw.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWithdraw.ForeColor = System.Drawing.Color.White;
            this.txtWithdraw.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtWithdraw.Location = new System.Drawing.Point(21, 50);
            this.txtWithdraw.Margin = new System.Windows.Forms.Padding(2, 6, 2, 6);
            this.txtWithdraw.Name = "txtWithdraw";
            this.txtWithdraw.PlaceholderText = "";
            this.txtWithdraw.SelectedText = "";
            this.txtWithdraw.Size = new System.Drawing.Size(155, 34);
            this.txtWithdraw.TabIndex = 6;
            this.txtWithdraw.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AllTexts_KeyPress);
            this.txtWithdraw.Validating += new System.ComponentModel.CancelEventHandler(this.AllTexts_Validating);
            this.txtWithdraw.Validated += new System.EventHandler(this.ValidateAmount_Validated);
            // 
            // txtAmountWithDraw
            // 
            this.txtAmountWithDraw.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAmountWithDraw.DefaultText = "";
            this.txtAmountWithDraw.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAmountWithDraw.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAmountWithDraw.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAmountWithDraw.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAmountWithDraw.FillColor = System.Drawing.Color.Black;
            this.txtAmountWithDraw.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAmountWithDraw.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountWithDraw.ForeColor = System.Drawing.Color.White;
            this.txtAmountWithDraw.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAmountWithDraw.Location = new System.Drawing.Point(-271, -17);
            this.txtAmountWithDraw.Margin = new System.Windows.Forms.Padding(2, 6, 2, 6);
            this.txtAmountWithDraw.Name = "txtAmountWithDraw";
            this.txtAmountWithDraw.PlaceholderText = "";
            this.txtAmountWithDraw.SelectedText = "";
            this.txtAmountWithDraw.Size = new System.Drawing.Size(159, 33);
            this.txtAmountWithDraw.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(178, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = ": أدخل المبلغ لسحبه من حسابك";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.LightGray;
            this.guna2Panel1.Controls.Add(this.label7);
            this.guna2Panel1.Controls.Add(this.lblFees);
            this.guna2Panel1.Location = new System.Drawing.Point(1126, 871);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.BorderRadius = 0;
            this.guna2Panel1.ShadowDecoration.Depth = 100;
            this.guna2Panel1.ShadowDecoration.Enabled = true;
            this.guna2Panel1.Size = new System.Drawing.Size(426, 58);
            this.guna2Panel1.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(172, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 40);
            this.label7.TabIndex = 19;
            this.label7.Text = ":رسوم الطلب";
            // 
            // lblFees
            // 
            this.lblFees.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFees.Location = new System.Drawing.Point(58, 9);
            this.lblFees.Name = "lblFees";
            this.lblFees.Size = new System.Drawing.Size(108, 40);
            this.lblFees.TabIndex = 18;
            this.lblFees.Text = "label1";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(402, 41);
            this.label9.TabIndex = 27;
            this.label9.Text = "Search About Your Account:";
            // 
            // ctrlAccountTransactionInfo1
            // 
            this.ctrlAccountTransactionInfo1.Account = null;
            this.ctrlAccountTransactionInfo1.AccountID = 0;
            this.ctrlAccountTransactionInfo1.Location = new System.Drawing.Point(12, 569);
            this.ctrlAccountTransactionInfo1.Name = "ctrlAccountTransactionInfo1";
            this.ctrlAccountTransactionInfo1.Size = new System.Drawing.Size(876, 159);
            this.ctrlAccountTransactionInfo1.TabIndex = 6;
            // 
            // ctrlAccountCardInfoWithFilter1
            // 
            this.ctrlAccountCardInfoWithFilter1.AccountID = -1;
            this.ctrlAccountCardInfoWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlAccountCardInfoWithFilter1.FilterValue = true;
            this.ctrlAccountCardInfoWithFilter1.Location = new System.Drawing.Point(12, 90);
            this.ctrlAccountCardInfoWithFilter1.Name = "ctrlAccountCardInfoWithFilter1";
            this.ctrlAccountCardInfoWithFilter1.Size = new System.Drawing.Size(876, 481);
            this.ctrlAccountCardInfoWithFilter1.TabIndex = 0;
            this.ctrlAccountCardInfoWithFilter1.OnSelectedAccount += new System.Action<int>(this.ctrlAccountCardInfoWithFilter1_OnSelectedAccount);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmWithDraw_Deposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1832, 1055);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.gbWithDraw);
            this.Controls.Add(this.gbExternalTransfer);
            this.Controls.Add(this.gbInternalTransfer);
            this.Controls.Add(this.gbDeposit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.ctrlAccountTransactionInfo1);
            this.Controls.Add(this.lblTransactionName);
            this.Controls.Add(this.pbImageTransaction);
            this.Controls.Add(this.ctrlAccountCardInfoWithFilter1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmWithDraw_Deposit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "WithDraw And Deposit";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmWithDraw_Deposit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImageTransaction)).EndInit();
            this.gbDeposit.ResumeLayout(false);
            this.gbDeposit.PerformLayout();
            this.gbInternalTransfer.ResumeLayout(false);
            this.gbInternalTransfer.PerformLayout();
            this.gbExternalTransfer.ResumeLayout(false);
            this.gbExternalTransfer.PerformLayout();
            this.gbWithDraw.ResumeLayout(false);
            this.gbWithDraw.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Accounts.Controls.ctrlAccountCardInfoWithFilter ctrlAccountCardInfoWithFilter1;
        private System.Windows.Forms.Label lblTransactionName;
        private System.Windows.Forms.PictureBox pbImageTransaction;
        private Accounts.Controls.ctrlAccountTransactionInfo ctrlAccountTransactionInfo1;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2GroupBox gbDeposit;
        private Guna.UI2.WinForms.Guna2GroupBox gbInternalTransfer;
        private Guna.UI2.WinForms.Guna2GroupBox gbExternalTransfer;
        private Guna.UI2.WinForms.Guna2GroupBox gbWithDraw;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtAmountWithDraw;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtAccountNumberForExternal;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtExteranal;
        private Guna.UI2.WinForms.Guna2TextBox txtDeposit;
        private Guna.UI2.WinForms.Guna2TextBox txtAccountNumberForInternal;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtInternal;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label lblFees;
        private Guna.UI2.WinForms.Guna2TextBox txtIBAM;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox txtWithdraw;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}