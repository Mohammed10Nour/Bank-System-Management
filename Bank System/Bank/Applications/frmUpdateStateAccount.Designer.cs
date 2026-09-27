namespace Bank.Applications
{
    partial class frmUpdateStateAccount
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblApplicationName = new System.Windows.Forms.Label();
            this.ctrlAccountCardInfoWithFilter1 = new Bank.Accounts.Controls.ctrlAccountCardInfoWithFilter();
            this.ctrlApplicationBasicInfo1 = new Bank.Applications.ctrlApplicationBasicInfo();
            this.btnApplicationTypes = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Bank.Properties.Resources.check;
            this.pictureBox2.Location = new System.Drawing.Point(470, 58);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(72, 51);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bank.Properties.Resources.accounting;
            this.pictureBox1.Location = new System.Drawing.Point(312, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblApplicationName
            // 
            this.lblApplicationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationName.Location = new System.Drawing.Point(218, 112);
            this.lblApplicationName.Name = "lblApplicationName";
            this.lblApplicationName.Size = new System.Drawing.Size(349, 39);
            this.lblApplicationName.TabIndex = 2;
            this.lblApplicationName.Text = "Freeze Account";
            this.lblApplicationName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ctrlAccountCardInfoWithFilter1
            // 
            this.ctrlAccountCardInfoWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlAccountCardInfoWithFilter1.FilterValue = true;
            this.ctrlAccountCardInfoWithFilter1.Location = new System.Drawing.Point(12, 154);
            this.ctrlAccountCardInfoWithFilter1.Name = "ctrlAccountCardInfoWithFilter1";
            this.ctrlAccountCardInfoWithFilter1.Size = new System.Drawing.Size(878, 434);
            this.ctrlAccountCardInfoWithFilter1.TabIndex = 3;
            this.ctrlAccountCardInfoWithFilter1.OnSelectedAccount += new System.Action<int>(this.ctrlAccountCardInfoWithFilter1_OnSelectedAccount);
            // 
            // ctrlApplicationBasicInfo1
            // 
            this.ctrlApplicationBasicInfo1.Location = new System.Drawing.Point(7, 594);
            this.ctrlApplicationBasicInfo1.Name = "ctrlApplicationBasicInfo1";
            this.ctrlApplicationBasicInfo1.Size = new System.Drawing.Size(883, 171);
            this.ctrlApplicationBasicInfo1.TabIndex = 4;
            // 
            // btnApplicationTypes
            // 
            this.btnApplicationTypes.Animated = true;
            this.btnApplicationTypes.BackColor = System.Drawing.Color.Transparent;
            this.btnApplicationTypes.BorderColor = System.Drawing.Color.White;
            this.btnApplicationTypes.BorderRadius = 12;
            this.btnApplicationTypes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnApplicationTypes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnApplicationTypes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnApplicationTypes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnApplicationTypes.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnApplicationTypes.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplicationTypes.ForeColor = System.Drawing.Color.White;
            this.btnApplicationTypes.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnApplicationTypes.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnApplicationTypes.Location = new System.Drawing.Point(697, 771);
            this.btnApplicationTypes.Name = "btnApplicationTypes";
            this.btnApplicationTypes.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnApplicationTypes.ShadowDecoration.Depth = 60;
            this.btnApplicationTypes.ShadowDecoration.Enabled = true;
            this.btnApplicationTypes.Size = new System.Drawing.Size(193, 40);
            this.btnApplicationTypes.TabIndex = 15;
            this.btnApplicationTypes.Text = "Application Types ";
            this.btnApplicationTypes.Click += new System.EventHandler(this.btnApplicationTypes_Click);
            // 
            // frmUpdateStateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 823);
            this.Controls.Add(this.btnApplicationTypes);
            this.Controls.Add(this.ctrlApplicationBasicInfo1);
            this.Controls.Add(this.ctrlAccountCardInfoWithFilter1);
            this.Controls.Add(this.lblApplicationName);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmUpdateStateAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUpdateStateAccount";
            this.Load += new System.EventHandler(this.frmUpdateStateAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblApplicationName;
        private Accounts.Controls.ctrlAccountCardInfoWithFilter ctrlAccountCardInfoWithFilter1;
        private ctrlApplicationBasicInfo ctrlApplicationBasicInfo1;
        private Guna.UI2.WinForms.Guna2Button btnApplicationTypes;
    }
}