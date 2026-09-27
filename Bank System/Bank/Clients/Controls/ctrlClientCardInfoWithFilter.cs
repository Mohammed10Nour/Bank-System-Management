using Business_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank.Client.Controls
{
    public partial class ctrlClientCardInfoWithFilter : UserControl
    {
        public event Action<int>OnSelectedClient;
        protected virtual void SelectedClient(int ClientID)
        {
            Action<int> handle = OnSelectedClient;
            if (handle != null)
            {
                handle(ClientID); // Raise the event with the parameter
            }
        }

        private bool _FilterEnabled = true;
        public bool FilterEnabled
        {
            get { return _FilterEnabled; }
            set {
                _FilterEnabled = value;
                groupBox1.Enabled = _FilterEnabled;
            }

        }
        public int ClientID
        {
            get { return ctrlClientInfoCard1.ClientID; }
            set { ctrlClientInfoCard1.ClientID = value; }
        }
        public string NationalNo
        {
            get
            {
                return ctrlClientInfoCard1.NationalNo;
            }
            set
            {
                ctrlClientInfoCard1.NationalNo = value;
            }
        }
      public void LoadData()
        {
            if (ClientID != -1)
            {
                ctrlClientInfoCard1.GetClientInfoByClientID();
                FilterEnabled = false;
                cbFilter.SelectedIndex = 0;
                txtSearch.Text = ctrlClientInfoCard1.ClientID.ToString();
            }
        }
        public ctrlClientCardInfoWithFilter()
        {
            InitializeComponent();
            cbFilter.SelectedIndex = 0;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
        
            switch (cbFilter.Text)
            {
                case "Client ID":
                    {
                        if (string.IsNullOrEmpty(txtSearch.Text))
                            return;
                         ClientID = int.Parse(txtSearch.Text.Trim());
                        if (!ctrlClientInfoCard1.GetClientInfoByClientID())
                        {
                            txtSearch.Clear();
                        }
                        else FilterEnabled = false;
                            break;
                    }
                case "National No":
                    {
                        if (string.IsNullOrEmpty(txtSearch.Text))
                            return;
                        NationalNo = txtSearch.Text.Trim();
                        if (!ctrlClientInfoCard1.GetClientInfoByNationalNo())
                        {
                            txtSearch.Clear();
                        }
                        else FilterEnabled = false;


                            break;
                    }

            }
            if (OnSelectedClient != null)
                OnSelectedClient(ctrlClientInfoCard1.ClientID);
           
        }
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
          if(cbFilter.Text=="Client ID")
            {  
               e.Handled = (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back);   
            }
        }
        private void btnAddNewClient_Click(object sender, EventArgs e)
        {          
            frmAddNewClient frm= new frmAddNewClient();
            frm.ShowDialog();  
            ClientID = frm.ClientID;
            LoadData();          
        }
    }
}
