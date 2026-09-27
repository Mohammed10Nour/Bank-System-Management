using Bank.Properties;
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
    public partial class ctrlAccountCardInfo : UserControl
    {
        private string _AccountName;
        public string AccountName
        {
            get
            => _AccountName;
            
            set
            {
                _AccountName = value;
                switch (_AccountName)
                {
                    case "BASIC_SAVINGS":
                        {
                            lblTitle.Text = "Basic Savings";
                            pbAccountImage.Image = Resources.BasicAccount;
                            break;
                        }
                    case "PREMIUM_SAVINGS":
                        {
                            lblTitle.Text = "Premium Savings";
                            pbAccountImage.Image = Resources.PremiumAccount;
                            break;
                        }
                    case "GOLD_SAVINGS":
                        {
                            lblTitle.Text = "Gold Savings";
                            pbAccountImage.Image = Resources.GoldAccount;
                            break;
                        }
                }

            }

        }

        private int _AccountID = -1;
        public int AccountID
        {
            get { return _AccountID; }
            set { _AccountID = value; }
        }

        private string _AccountNumber = "";
        public string AccountNumber { get => _AccountNumber;set { _AccountNumber = value; } }

        private clsAccount _Account;
        public clsAccount Account
        {
            get { return _Account; }
            set { _Account = value; }
        }

        private void _LoadData()
        {
            this.AccountID = Account.AccountID;
            AccountName = Account.AccountType.ToString();
            lblAccountID.Text = Account.AccountID.ToString() ;
            lblAccountNumber.Text = Account.AccountNumber.ToString() ;
            lblAccountStatus.Text =Account.AccountState.ToString();
            lblBalance.Text = Account.Balance.ToString();
            lblClientName.Text = Account.Application.Client.FullName;

            lblInterestPeriod.Text = Account.AccountType.InterestPeriod.ToString();
            lblInterestRate.Text = Account.AccountType.InterestRate.ToString();
            lblMax.Text = Account.AccountType.MaxDailyWithDrawAmount.ToString();
            lblNumber.Text = clsTransaction.GetWithdrawalCountForAccount(AccountID).ToString();
            lblMax.Text = Account.AccountType.MaxDailyWithDrawAmount.ToString();
        }
        public void ResetControls()
        {
            this.AccountID = -1;
            lblTitle.Text = "";
            pbAccountImage.Image = null;
            lblAccountID.Text = "????";
            lblAccountNumber.Text = "????";
            lblAccountStatus.Text = "????";
            lblBalance.Text = "????";
            lblClientName.Text = "????";
            lblBalance.Text = "????";
            lblInterestPeriod.Text = "????";
            lblInterestRate.Text = "????";
            lblMax.Text = "????";
            lblNumber.Text = "????";
        }
        public bool LoadAccountDataByAccountID()
        {
            Account = clsAccount.FindAccountByAccountID(AccountID);
            if(Account==null)
            {
                MessageBox.Show("Account not found!", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetControls();
                return false;
            }
            _LoadData();
            return true;

        }
        public bool LoadAccountDataByAccountNumber()
        {
            Account = clsAccount.FindAccountByAccountNumber(AccountNumber);
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
     
        public ctrlAccountCardInfo()
        {
            InitializeComponent();
        }

        private void lblEditInformatin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (AccountID < 1) return;
            Form frm = new frmAddEditAccount(AccountID);
            frm.ShowDialog();
            _LoadData();
        }
    }
}
