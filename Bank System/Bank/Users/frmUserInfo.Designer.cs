namespace Bank.Users
{
    partial class frmUserInfo
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.ctrlUserCardInfo1 = new Bank.Users.Controls.ctrlUserCardInfo();
            this.ctrlClientInfoCard1 = new Bank.Client.Controls.ctrlClientInfoCard();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.ctrlUserCardInfo1);
            this.guna2Panel1.Controls.Add(this.ctrlClientInfoCard1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(775, 653);
            this.guna2Panel1.TabIndex = 0;
            // 
            // ctrlUserCardInfo1
            // 
            this.ctrlUserCardInfo1.Location = new System.Drawing.Point(3, 395);
            this.ctrlUserCardInfo1.Name = "ctrlUserCardInfo1";
            this.ctrlUserCardInfo1.Size = new System.Drawing.Size(763, 252);
            this.ctrlUserCardInfo1.TabIndex = 1;
            this.ctrlUserCardInfo1.User = null;
            this.ctrlUserCardInfo1.UserID = 0;
            // 
            // ctrlClientInfoCard1
            // 
            this.ctrlClientInfoCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ctrlClientInfoCard1.Client = null;
            this.ctrlClientInfoCard1.ClientID = -1;
            this.ctrlClientInfoCard1.Location = new System.Drawing.Point(3, 3);
            this.ctrlClientInfoCard1.Name = "ctrlClientInfoCard1";
            this.ctrlClientInfoCard1.NationalNo = "";
            this.ctrlClientInfoCard1.Size = new System.Drawing.Size(769, 398);
            this.ctrlClientInfoCard1.TabIndex = 0;
            // 
            // frmUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 653);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmUserInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Information";
            this.Load += new System.EventHandler(this.frmUserInfo_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Client.Controls.ctrlClientInfoCard ctrlClientInfoCard1;
        private Controls.ctrlUserCardInfo ctrlUserCardInfo1;
    }
}