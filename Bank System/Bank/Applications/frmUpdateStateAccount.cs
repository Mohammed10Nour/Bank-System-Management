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

namespace Bank.Applications
{
    public partial class frmUpdateStateAccount : Form
    {
        public clsAccount Account { get; set; }
        private int _AccountID = -1;
        public int AccountID
        {
            get => _AccountID;
                set { _AccountID = value; }
        }
        private clsAccount.enAccountStatus NewAccountState { get; set; }

        private clsApplication.enApplicationType _enAppType = clsApplication.enApplicationType.ISSUE_ATM_CARD;
        public clsApplication.enApplicationType enAppType
        {
            get => _enAppType;
            set { _enAppType = value; }
        }
        public frmUpdateStateAccount(clsApplication.enApplicationType enAppType)
        {
            InitializeComponent();

            this.enAppType = enAppType;
            ctrlApplicationBasicInfo1.enAppType = enAppType;
        }
        private bool _ValidateAccountState()
        {
            switch(enAppType)
            {
                case clsApplication.enApplicationType.REACTIVATE_ACCOUNT:
                {
                    if(Account.AccountState == clsAccount.enAccountStatus.Closed)
                     {
                            MessageBox.Show("This account is closed. You cannot make any modifications to it.",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                            
                            return false;
                     }
                        break;
                }
                case clsApplication.enApplicationType.FREEZE_ACCOUNT:
                    {
                        if (Account.AccountState == clsAccount.enAccountStatus.Closed)
                        {
                            MessageBox.Show("This account is closed. You cannot make any modifications to it.",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                            return false;
                        }
                        if (Account.AccountState == clsAccount.enAccountStatus.Frozen)
                        {
                            MessageBox.Show("This account is already frozen.",
                                            "Warning",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Warning);
                              return false;
                        }

                        break;
                    }
                case clsApplication.enApplicationType.CLOSE_ACCOUNT:
                    {
                        if (Account.AccountState == clsAccount.enAccountStatus.Closed)
                        {
                            MessageBox.Show("This account is already closed.",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                            return false;
                        }
                        break;
                    }
            }


            return true;
           
        }
        private void ctrlAccountCardInfoWithFilter1_OnSelectedAccount(int obj)
        {
            if (obj <= 0) return;
            this.AccountID = obj;
            ctrlAccountCardInfoWithFilter1.AccountID = this.AccountID;
        }
        private void btnApplicationTypes_Click(object sender, EventArgs e)
        {
            if (this.AccountID == -1)
                return;

             this.Account = clsAccount.FindAccountByAccountID(this.AccountID);
            if (!_ValidateAccountState())
                return;

            clsApplication newApplication = new clsApplication();
            newApplication.ApplicationStatus = clsApplication.enApplicationStatus.Completed;
            newApplication.ApplicationDate = DateTime.Now;
            newApplication.enAppType = enAppType;
            newApplication.ClientID = Account.Application.ClientID;
            newApplication.PaidFees = clsApplicationType.FindApplicationTypeByApplicationTypeId((byte)enAppType).Fees;
            newApplication.UserID = clsGlobal.CurrentUser.UserID;
            if (newApplication.Save())
            {
                Account.AccountState = this.NewAccountState;
                if (this.NewAccountState == clsAccount.enAccountStatus.Closed)
                { Account.Balance = 0; }
                if (Account.Save())
                {
                    MessageBox.Show("Update Account Status has been successfully .", $"{enAppType.ToString()}", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ctrlApplicationBasicInfo1.UpdateApplicationData(newApplication.ApplicationID, newApplication.ApplicationStatus);
                    ctrlAccountCardInfoWithFilter1.ReloadData();
                    btnApplicationTypes.Enabled = false;
                    ctrlAccountCardInfoWithFilter1.FilterValue = false;
                    return;
                }
            }


            MessageBox.Show("Failed To Update The Account Status.", $"{enAppType.ToString()}+Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void frmUpdateStateAccount_Load(object sender, EventArgs e)
        {
            switch (this.enAppType.ToString())
            {
                case "FREEZE_ACCOUNT":
                    {
                        this.Text = "Freeze Account";
                        this.NewAccountState = clsAccount.enAccountStatus.Frozen;
                        pictureBox2.Image = Resources.snowflake;
                        ctrlApplicationBasicInfo1.enAppType = clsApplication.enApplicationType.FREEZE_ACCOUNT;

                        break;
                    }
                case "REACTIVATE_ACCOUNT":
                    {
                        this.Text = "Reactivate Account";                      
                        this.NewAccountState = clsAccount.enAccountStatus.Active;
                        pictureBox2.Image = Resources.check;
                        ctrlApplicationBasicInfo1.enAppType = clsApplication.enApplicationType.REACTIVATE_ACCOUNT;

                        break;
                    }
                case "CLOSE_ACCOUNT":
                    {
                        this.Text = "Close Account";                        
                        this.NewAccountState = clsAccount.enAccountStatus.Closed;
                        pictureBox2.Image = Resources.icons8_close_window_100;
                        ctrlApplicationBasicInfo1.enAppType = clsApplication.enApplicationType.CLOSE_ACCOUNT;
                        break;
                    }
            }
            lblApplicationName.Text = this.Text;
            btnApplicationTypes.Text = this.Text;
            ctrlApplicationBasicInfo1.LoadApplicationData();
        }
    
    }
    
}


