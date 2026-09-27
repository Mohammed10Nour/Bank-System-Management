using Bank.Properties;
using Business_Layer;
using Guna.UI2.WinForms;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank.Account_Transaction
{
    public partial class frmWithDraw_Deposit : Form
    {
        private int _AccountID = -1;
        public int AccountID { get; set; }

        private int _Account;
        private clsAccount _ReceiverAccount;
        public clsAccount Account { get; set; }
        private decimal _Amount;
        private clsTransaction.enTransactionName TransactionName;
        private decimal _ApplicationFees;
        private clsApplication.enApplicationType enAppType;
        public frmWithDraw_Deposit(clsTransaction.enTransactionName TransactionName, clsApplication.enApplicationType AppType)
        {
            InitializeComponent();

            btnSave.Select();
            this.TransactionName = TransactionName;
            this.enAppType = AppType;
            _ApplicationFees = clsApplicationType.FindApplicationTypeByApplicationTypeId((byte)this.enAppType).Fees;
        }
        private void ctrlAccountCardInfoWithFilter1_OnSelectedAccount(int obj)
        {
            this.AccountID = obj;
            if (this.AccountID == -1)
            { ctrlAccountTransactionInfo1.ResetControls(); return; }

           
            Account = clsAccount.FindAccountByAccountID(AccountID);


            ctrlAccountTransactionInfo1.AccountID = this.AccountID;
            ctrlAccountTransactionInfo1.LoadAccountTransactionData();



        }
        private void frmWithDraw_Deposit_Load(object sender, EventArgs e)
        {
            switch (this.TransactionName)
            {

                case clsTransaction.enTransactionName.WithDraw:
                    {
                        this.Text = "With Draw";
                        pbImageTransaction.Image = Resources.cash_withdrawal;
                        gbWithDraw.ForeColor = Color.Red;
                        break;
                    }
                case clsTransaction.enTransactionName.Deposit:
                    {
                        this.Text = "Deposit";
                        pbImageTransaction.Image = Resources.deposit;
                        gbDeposit.ForeColor = Color.Red;
                        break;
                    }
                case clsTransaction.enTransactionName.InternalTransfer:
                    {
                        this.Text = "Internal Transfer";
                        pbImageTransaction.Image = Resources.left_right;
                        gbInternalTransfer.ForeColor = Color.Red;
                        break;
                    }
                case clsTransaction.enTransactionName.ExternalTransfer:
                    {

                        this.Text = "External Transfer";
                        pbImageTransaction.Image = Resources.export;
                        gbExternalTransfer.ForeColor = Color.Red;
                        break;
                    }
            }
            lblTransactionName.Text = this.Text;
            lblFees.Text = _ApplicationFees.ToString();
            gbDeposit.Enabled = (this.TransactionName == clsTransaction.enTransactionName.Deposit);
            gbWithDraw.Enabled = (this.TransactionName == clsTransaction.enTransactionName.WithDraw);
            gbExternalTransfer.Enabled = (this.TransactionName == clsTransaction.enTransactionName.ExternalTransfer);
            gbInternalTransfer.Enabled = (this.TransactionName == clsTransaction.enTransactionName.InternalTransfer);



        }
   
        private bool _VaildateBasic()
        {
            if (this.AccountID <= 0)
                return false;
            if (!this.ValidateChildren())
                return false;
            return true;
        }
      
        private void _ShowSuccess()
        {
            MessageBox.Show($"{TransactionName} operation completed successfully ✅", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnSave.Enabled = false;
            ctrlAccountCardInfoWithFilter1.ReloadData();
            ctrlAccountTransactionInfo1.LoadAccountTransactionData();
            ctrlAccountCardInfoWithFilter1.FilterValue = false;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_VaildateBasic())
                return;
            try
            {
                TransactionService Service = new TransactionService();
                int iban = int.TryParse(txtIBAM.Text, out var R) ? R : 0;
                int ReciverAccountID = int.TryParse(txtAccountNumberForExternal.Text, out var L) ? L: 0;
                Service.ExecuteTransaction(this.Account, this._ReceiverAccount, this._Amount, enAppType,iban, this._ApplicationFees, clsGlobal.CurrentUser.UserID,ReciverAccountID);
                
                if(Account.Save())
                    _ShowSuccess();
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


        }
       
        private void AllTexts_KeyPress(object sender, KeyPressEventArgs e)
        {

             Guna2TextBox text = sender as Guna2TextBox;
             e.Handled = (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back);


        }

        private void AllTexts_Validating(object sender, CancelEventArgs e)
        {
            Guna2TextBox Text = sender as Guna2TextBox;
            if (Text.Enabled != true)
                return;
            if (string.IsNullOrWhiteSpace(Text.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(Text, "هذا الحقل لايجب ان يكون فارغاً");

            }
            else
            { errorProvider1.SetError(Text, null); e.Cancel = false; }
        }

        private void ValidateAmount_Validated(object sender, EventArgs e)
        {
            Guna2TextBox text = sender as Guna2TextBox;
            if (string.IsNullOrEmpty(text.Text))
                return;
            this._Amount = Convert.ToDecimal(text.Text.Trim());
        }

        private void txtAccountNumberForInternal_Validating(object sender, CancelEventArgs e)
        {
            if (this.enAppType != clsApplication.enApplicationType.TRANSFER_INTERNAL)
                return;
            
            AllTexts_Validating(sender, e);
            if (e.Cancel)
                return;
            Guna2TextBox Text = sender as Guna2TextBox;
            this._ReceiverAccount = clsAccount.FindAccountByAccountNumber(Text.Text.Trim());
            if (this._ReceiverAccount == null)
            {
                MessageBox.Show("!هذا الحساب غير موجود", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
                return;
             }
            if (this.AccountID <= 0)
                return;
            if(this._ReceiverAccount.AccountID==this.Account.AccountID)
            {
                MessageBox.Show("!لايمكنك تحويل الرصيد للحساب الحالي", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
                return;
            }

    }
    }
}
