namespace Bank.Client.Controls
{
    partial class ctrlClientCardInfoWithFilter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddNewClient = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.ctrlClientInfoCard1 = new Bank.Client.Controls.ctrlClientInfoCard();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.groupBox1.Controls.Add(this.btnAddNewClient);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.cbFilter);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(5, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(766, 74);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter By:";
            // 
            // btnAddNewClient
            // 
            this.btnAddNewClient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddNewClient.Image = global::Bank.Properties.Resources.icons8_add_user_male_48;
            this.btnAddNewClient.Location = new System.Drawing.Point(617, 17);
            this.btnAddNewClient.Name = "btnAddNewClient";
            this.btnAddNewClient.Size = new System.Drawing.Size(64, 51);
            this.btnAddNewClient.TabIndex = 3;
            this.btnAddNewClient.UseVisualStyleBackColor = true;
            this.btnAddNewClient.Click += new System.EventHandler(this.btnAddNewClient_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Image = global::Bank.Properties.Resources.icons8_search_48;
            this.btnSearch.Location = new System.Drawing.Point(547, 17);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(64, 51);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbFilter
            // 
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "Client ID",
            "National No"});
            this.cbFilter.Location = new System.Drawing.Point(112, 29);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(180, 33);
            this.cbFilter.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(297, 29);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(220, 33);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // ctrlClientInfoCard1
            // 
            this.ctrlClientInfoCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ctrlClientInfoCard1.Client = null;
            this.ctrlClientInfoCard1.ClientID = -1;
            this.ctrlClientInfoCard1.Location = new System.Drawing.Point(3, 77);
            this.ctrlClientInfoCard1.Name = "ctrlClientInfoCard1";
            this.ctrlClientInfoCard1.Size = new System.Drawing.Size(769, 398);
            this.ctrlClientInfoCard1.TabIndex = 2;
            // 
            // ctrlClientCardInfoWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.ctrlClientInfoCard1);
            this.Controls.Add(this.groupBox1);
            this.Name = "ctrlClientCardInfoWithFilter";
            this.Size = new System.Drawing.Size(775, 466);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnAddNewClient;
        private System.Windows.Forms.Button btnSearch;
        private ctrlClientInfoCard ctrlClientInfoCard1;
    }
}
