using Bank.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bank.Accounts;
using Business_Layer;
using Guna.UI2.WinForms;
using System.Web.UI;
using System.Xml.Linq;
namespace Bank.Accounts
{
    public partial class frmAddEditAccount : Form
    {
        private enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;


        private int _AccountID;
        public int AccountID
        {
            get
            {
                return _AccountID;
            }
            set
            {
                _AccountID = value;
            }
        }

        private clsAccount _Account;
        public clsAccount Account
        {
            get
            {
                return _Account;
            }
            set
            {
                _Account = value;
            }
        }


        public int ClientID
        {
          get  
            {
                return ctrlClientCardInfoWithFilter1.ClientID;   
            }

            set 
            {
                ctrlClientCardInfoWithFilter1.ClientID = value;
            }
        }
      
        //     Update Account
        private void _LoadDataFromObjectAccountToControls()
        {
            ClientID = clsApplication.FindApplicationByApplicationID(Account.ApplicationID).ClientID;
            ctrlClientCardInfoWithFilter1.LoadData();
            lblAccountID.Text = Account.AccountID.ToString();
            txtAccountNumber.Text = Account.AccountNumber;
            cbAccountStatus.SelectedIndex = (byte)(Account.AccountState-1);
            txtBalance.Text = Account.Balance.ToString();
            cbAccountType.SelectedIndex = (Account.AccountTypeID-1);

        }
        private void _LoadDataFromControlsToAccountObject()
        {
            Account.AccountNumber = txtAccountNumber.Text;
            Account.AccountTypeID = (cbAccountType.SelectedIndex + 1);
            Account.Balance = Convert.ToDecimal(txtBalance.Text.Trim());
            Account.UpdatedAt = DateTime.Now;
            Account.AccountState = (clsAccount.enAccountStatus)(cbAccountStatus.SelectedIndex + 1);
            Account.LastInterestDate = DateTime.Now;
            
        }

        //     Add new Account 
        private bool _LoadApplicationDataAndSaveIts()
        {
            clsApplication newApplication = new clsApplication();
            newApplication.Mode = (clsApplication.enMode)this._Mode;
            newApplication.ClientID = ClientID;
            newApplication.enAppType = clsApplication.enApplicationType.OPEN_ACCOUNT;
            newApplication.ApplicationStatus = clsApplication.enApplicationStatus.New;
            newApplication.ApplicationDate = DateTime.Now;
            newApplication.PaidFees = clsApplicationType.GetApplicationFees((byte)newApplication.enAppType);
            newApplication.UserID = clsGlobal.CurrentUser.UserID;
            newApplication.Save();
            Account.ApplicationID = newApplication.ApplicationID;
           if(Account.ApplicationID!=-1)
            {
                newApplication.ApplicationStatus = clsApplication.enApplicationStatus.Completed;
                newApplication.SetComplete();
                return true;
            }
            return false;
        }
        private bool _DoesClientHasAccountOfSameType()
        {
            return clsAccount.IsClientHasAccount(ClientID,(clsAccountType.enAccountType)cbAccountType.SelectedIndex+1);
        }
        public frmAddEditAccount()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
           
        }
        public frmAddEditAccount(int AccountID)
        {
            InitializeComponent();
           
            this.AccountID = AccountID;
            _Mode = enMode.Update;       
            lblAccountID.Text = AccountID.ToString();
            lblTitle.Text = "تحديث بيانات الحساب";
            pbImageTitle.Image = Resources.icons8_edit_property_100;
        }
        private bool _ValidateBalance()
        {
            decimal minBalance=clsAccountType.FindAccountTypeByAccountTypeID((clsAccountType.enAccountType)(cbAccountType.SelectedIndex+1)).MinBalance;
            if (Convert.ToDecimal(txtBalance.Text.Trim()) < minBalance)
            {
                MessageBox.Show($"عذراً، لا يمكن فتح الحساب بهذا الرصيد.\n\n" +
                $"الرصيد المدخل: {Convert.ToDecimal(txtBalance.Text.Trim()):$} $\n" +
                $"الحد الأدنى المطلوب: {minBalance:$} \n\n" +
                $"يرجى إيداع مبلغ أكبر من أو يساوي {minBalance:$} .",
                "خطأ: الرصيد أقل من الحد الأدنى",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if(!_ValidateBalance())
            {
                return;
            }
            if(_DoesClientHasAccountOfSameType()&&this._Mode!=enMode.Update)
            {
                MessageBox.Show("هذا العميل لديه فعلا حساب مسبقا", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _LoadDataFromControlsToAccountObject();
            switch (this._Mode)
            {
                case enMode.AddNew:
                    {
                        
                       if(_LoadApplicationDataAndSaveIts())
                        {
                             
                            if (Account.Save())
                            {
                                MessageBox.Show("New account has been added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                
                                lblAccountID.Text = Account.AccountID.ToString();
                                
                                lblTitle.Text = "تحديث بيانات الحساب";
                                pbImageTitle.Image = Resources.icons8_edit_property_100;
                                this._Mode = enMode.Update;
                            }
                            else
                            {
                                MessageBox.Show("Failed to add new account. Please check the data and try again.","Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Failed to add new account. Please check the data and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    }
                    case enMode.Update:
                    {
                      if(Account.Save())
                        {

                            MessageBox.Show( "Account information has been updated successfully.","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                            lblUpdateAtDate.Text = Account.UpdatedAt.ToString();
                        }
                      else
                        {
                            MessageBox.Show("Failed to update the account. Please verify the account ID and try again.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        }
                            break;
                    }
            }

        }
        private void frmAddEditAccount_Load(object sender, EventArgs e)
        {
           
            switch (this._Mode)
            {
                case enMode.AddNew:
                    {
                        lblFees.Visible = true;
                        label2.Visible = true;
                        guna2Panel1.Visible = true;
                        lblFees.Text = clsApplicationType.FindApplicationTypeByApplicationTypeId(25).Fees.ToString();
                        Account = new clsAccount();
                        cbAccountStatus.SelectedIndex = 0;
                        cbAccountType.SelectedIndex = 0;
                        cbAccountStatus.Enabled = false;
                        break;
                    }
                case enMode.Update:
                    {
                        lblFees.Visible = false;
                        label2.Visible = false;
                        guna2Panel1.Visible = false;
                        Account = clsAccount.FindAccountByAccountID(AccountID);
                        if (Account == null)
                        {
                          
                            MessageBox.Show($"Account not found.\n\nThe account with ID {AccountID} does not exist.", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                            return;
                        }
                        _LoadDataFromObjectAccountToControls();
                       
                        pbImageTitle.Image = Resources.icons8_edit_property_100;
                        
                        break;
                    }
            }

        }
        private void txtAccountNumber_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(txtAccountNumber.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtAccountNumber,
                    "!يجب ملأ هذا الحقل أولاً");
                return;
            }
            else
                errorProvider1.SetError(txtAccountNumber, null);
            bool exists =clsAccount.IsAccountExist(int.Parse(txtAccountNumber.Text.Trim()));

            if (txtAccountNumber.Text != Account.AccountNumber && exists)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtAccountNumber,
                    "! هذا الرقم مستخدم");
            }
            else
                errorProvider1.SetError(txtAccountNumber , null);
        }
        private void txtAccountNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
        private void txtBalance_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
        private void txtBalance_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtBalance.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtBalance,
                    "!يجب ملأ هذا الحقل أولاً");
            }
            else
                errorProvider1.SetError(txtBalance, null);
        }
        private void ctrlClientCardInfoWithFilter1_OnSelectedClient_1(int obj)
        {
            ClientID = obj;
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
