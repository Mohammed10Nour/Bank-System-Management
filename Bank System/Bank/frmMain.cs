using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bank.Client;
using Bank.Users;
using Bank.Applications;
using Bank.Accounts;
using Bank.Account_Transaction;
using Business_Layer;
namespace Bank
{
    public partial class frmMain : Form
    {
        Form _frmLogin;
        public frmMain(Form frmLogin)
        {
            InitializeComponent();
          _frmLogin = frmLogin;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form frm = new frmListClients();
            frm.Show();
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            Form frm = new frmListClients();
            frm.ShowDialog();

        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            Form frm = new frmListUsers();
            frm.ShowDialog();
        }

        private void btnApplicationTypes_Click(object sender, EventArgs e)
        {
            Form frm = new frmApplicationTypes();
            frm.ShowDialog();
        }

        private void openNewAccount_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddEditAccount();
            frm.ShowDialog();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Form frm = new frmListAccounts();
            frm.ShowDialog();
        }

        private void FreezeAccount_Click(object sender, EventArgs e)
        {

         
            Form frm = new frmUpdateStateAccount(clsApplication.enApplicationType.FREEZE_ACCOUNT);
            frm.ShowDialog();
        }

        private void ReactivateAccount_Click(object sender, EventArgs e)
        {
            Form frm = new frmUpdateStateAccount(clsApplication.enApplicationType.REACTIVATE_ACCOUNT);
            frm.ShowDialog();
        }

        private void CloseAccount_Click(object sender, EventArgs e)
        {
            Form frm = new frmUpdateStateAccount(clsApplication.enApplicationType.CLOSE_ACCOUNT);
            frm.ShowDialog();
        }

        private void Deposit_Click(object sender, EventArgs e)
        {
            Form frm = new frmWithDraw_Deposit(clsTransaction.enTransactionName.Deposit,clsApplication.enApplicationType.DEPOSIT);
            frm.ShowDialog();

        }

        private void Withdrawal_Click(object sender, EventArgs e)
        {
            Form frm = new frmWithDraw_Deposit(clsTransaction.enTransactionName.WithDraw, clsApplication.enApplicationType.WITHDRAW);
            frm.ShowDialog();
        }
        private void InternalTransfer_Click(object sender, EventArgs e)
        {
            Form frm = new frmWithDraw_Deposit(clsTransaction.enTransactionName.InternalTransfer, clsApplication.enApplicationType.TRANSFER_INTERNAL);
            frm.ShowDialog();
        }
        private void ExternalTransfer_Click(object sender, EventArgs e)
        {
            Form frm = new frmWithDraw_Deposit(clsTransaction.enTransactionName.ExternalTransfer, clsApplication.enApplicationType.TRANSFER_EXTERNAL);
            frm.ShowDialog();
        }

        private void currentUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmUserInfo(clsGlobal.CurrentUser.UserID);
            frm.ShowDialog();

        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddEditUser(clsGlobal.CurrentUser.UserID);
            frm.ShowDialog();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsGlobal.CurrentUser = null;
            _frmLogin.Show();
            this.Close();
        
    }

    }
}
