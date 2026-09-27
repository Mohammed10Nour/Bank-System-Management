namespace Bank.Accounts
{
    partial class frmAccountInfo
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
            this.ctrlAccountCardInfo1 = new Bank.Accounts.Controls.ctrlAccountCardInfo();
            this.ctrlAccountTransactionInfo1 = new Bank.Accounts.Controls.ctrlAccountTransactionInfo();
            this.SuspendLayout();
            // 
            // ctrlAccountCardInfo1
            // 
            this.ctrlAccountCardInfo1.Account = null;
            this.ctrlAccountCardInfo1.AccountID = 0;
            this.ctrlAccountCardInfo1.AccountName = null;
            this.ctrlAccountCardInfo1.AccountNumber = null;
            this.ctrlAccountCardInfo1.Location = new System.Drawing.Point(12, 12);
            this.ctrlAccountCardInfo1.Name = "ctrlAccountCardInfo1";
            this.ctrlAccountCardInfo1.Size = new System.Drawing.Size(905, 468);
            this.ctrlAccountCardInfo1.TabIndex = 0;
            // 
            // ctrlAccountTransactionInfo1
            // 
            this.ctrlAccountTransactionInfo1.Account = null;
            this.ctrlAccountTransactionInfo1.AccountID = 0;
            this.ctrlAccountTransactionInfo1.Location = new System.Drawing.Point(13, 492);
            this.ctrlAccountTransactionInfo1.Name = "ctrlAccountTransactionInfo1";
            this.ctrlAccountTransactionInfo1.Size = new System.Drawing.Size(905, 152);
            this.ctrlAccountTransactionInfo1.TabIndex = 1;
            // 
            // frmAccountInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(930, 646);
            this.Controls.Add(this.ctrlAccountTransactionInfo1);
            this.Controls.Add(this.ctrlAccountCardInfo1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAccountInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account Info";
            this.Load += new System.EventHandler(this.frmAccountInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ctrlAccountCardInfo ctrlAccountCardInfo1;
        private Controls.ctrlAccountTransactionInfo ctrlAccountTransactionInfo1;
    }
}