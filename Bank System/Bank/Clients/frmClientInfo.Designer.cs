namespace Bank.Client
{
    partial class frmClientInfo
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
            this.ctrlClientInfo1 = new Bank.Client.Controls.ctrlClientInfoCard();
            this.pnlHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlClientInfo1
            // 
            this.ctrlClientInfo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ctrlClientInfo1.Client = null;
            this.ctrlClientInfo1.ClientID = -1;
            this.ctrlClientInfo1.Location = new System.Drawing.Point(12, 193);
            this.ctrlClientInfo1.Name = "ctrlClientInfo1";
            this.ctrlClientInfo1.NationalNo = "";
            this.ctrlClientInfo1.Size = new System.Drawing.Size(769, 398);
            this.ctrlClientInfo1.TabIndex = 0;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Transparent;
            this.pnlHeader.BorderColor = System.Drawing.Color.Transparent;
            this.pnlHeader.BorderRadius = 20;
            this.pnlHeader.BorderThickness = 1;
            this.pnlHeader.Controls.Add(this.guna2PictureBox2);
            this.pnlHeader.Controls.Add(this.label3);
            this.pnlHeader.FillColor = System.Drawing.Color.DarkSlateGray;
            this.pnlHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlHeader.Location = new System.Drawing.Point(12, 124);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.ShadowDecoration.Depth = 5;
            this.pnlHeader.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pnlHeader.Size = new System.Drawing.Size(769, 63);
            this.pnlHeader.TabIndex = 8;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.guna2PictureBox2.FillColor = System.Drawing.Color.DarkSlateGray;
            this.guna2PictureBox2.Image = global::Bank.Properties.Resources.icons8_client_management_1001;
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(697, 12);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(45, 42);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox2.TabIndex = 4;
            this.guna2PictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(426, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(275, 42);
            this.label3.TabIndex = 2;
            this.label3.Text = "تفاصيل بيانات العميل";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::Bank.Properties.Resources.icons8_person_100;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(629, 12);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(152, 106);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 7;
            this.guna2PictureBox1.TabStop = false;
            // 
            // frmClientInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(790, 603);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.ctrlClientInfo1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmClientInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client Information";
            this.Load += new System.EventHandler(this.frmClientInfo_Load);
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ctrlClientInfoCard ctrlClientInfo1;
        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}