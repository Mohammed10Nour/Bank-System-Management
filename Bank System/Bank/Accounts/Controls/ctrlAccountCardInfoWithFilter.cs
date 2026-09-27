using Bank.Applications;
using Bank.Client.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank.Accounts.Controls
{
   
    public partial class ctrlAccountCardInfoWithFilter : UserControl
    {


        public event Action<int> OnSelectedAccount;
        protected virtual void SelectedAccount(int AccountID)
        {
            Action<int> handle = OnSelectedAccount;
            if (handle != null)
            {
                handle(AccountID); // Raise the event with the parameter
            }
        }


      
        public int AccountID
        {
            get { return ctrlAccountCardInfo1.AccountID; }
            set { ctrlAccountCardInfo1.AccountID = value;
               }
         }

        private bool _FilterValue = true;
        public bool FilterValue
        {
            get => _FilterValue;
            set
            {
                _FilterValue = value;
                groupBox1.Enabled = _FilterValue;
            }  
        }
   
        
        
        public ctrlAccountCardInfoWithFilter()
        {
            InitializeComponent();
            cbFilter.SelectedIndex = 0;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtSearch.Text.Trim()))
            {
                return;
            }
            switch(cbFilter.Text)
            {
                case "Account ID":
                    {
                        ctrlAccountCardInfo1.AccountID = int.Parse(txtSearch.Text.Trim());
                        if (!ctrlAccountCardInfo1.LoadAccountDataByAccountID())
                        { AccountID = -1; txtSearch.Clear(); }
                           
                        break;
                    }
                case "Account Number":
                    {
                        
                        ctrlAccountCardInfo1.AccountNumber= txtSearch.Text.Trim();
                        if (!ctrlAccountCardInfo1.LoadAccountDataByAccountNumber())
                        { AccountID = -1; txtSearch.Clear(); }
                        break;
                    }

            }
            if (OnSelectedAccount != null)
                OnSelectedAccount(ctrlAccountCardInfo1.AccountID);
        }
        public void ReloadData()
        {
           
            ctrlAccountCardInfo1.LoadAccountDataByAccountID();
        }
        private void ResetControls()
        {
           
            ctrlAccountCardInfo1.ResetControls();
            txtSearch.Clear();
            txtSearch.Visible = cbFilter.Text != "None";
        }
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (cbFilter.Text!="Account Number")
            {
                e.Handled = (!char.IsDigit(e.KeyChar) && e.KeyChar!= (char)Keys.Back);
            }
            
        }
        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetControls();
        }
        private void ctrlAccountCardInfo1_Load(object sender, EventArgs e)
        {
          
            groupBox1.Select();
        }
    }
}
