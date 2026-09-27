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

namespace Bank.Accounts.Controls
{
    public partial class ctrlAccountTransactionInfo : UserControl
    {
        private int _AccountID;
        public int AccountID
        {
            get { return _AccountID; }
            set { _AccountID = value; }
        }

        private clsAccount _Account;
        public clsAccount Account
        {
            get { return _Account; }
            set { _Account = value; }
        }
        private void _LoadData()
        {
            lblDepositsCount.Text = clsTransaction.GetDepositsCountForAccount(AccountID).ToString();
            lblExternalTransferCount.Text = clsTransaction.GetExternalTrnasferCountForAccount(AccountID).ToString();
            lblInternalTransferCount.Text = clsTransaction.GetInternalTrnasferCountForAccount(AccountID).ToString();
            lblWithDrawalsCount.Text = clsTransaction.GetWithdrawalCountForAccount(AccountID).ToString();
        }
        public void ResetControls()
        {
           lblDepositsCount.Text="????";
          lblExternalTransferCount.Text = "????";
         lblInternalTransferCount.Text = "????";
       lblWithDrawalsCount.Text = "????";
         
        }
        public bool LoadAccountTransactionData()
        {
            Account = clsAccount.FindAccountByAccountID(AccountID);
            if (Account == null)
            {
                MessageBox.Show("Account not found!", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetControls();
                return false;
            }
            _LoadData();
            return true;

        }
        public ctrlAccountTransactionInfo()
        {
            InitializeComponent();
        }

        
    }
}
