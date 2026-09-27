using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank.Accounts
{
    public partial class frmAccountInfo : Form
    {
      //  public string AccountName { get; set; }
        public int AccountID { get; set; }
        public frmAccountInfo(int AccountID)//,string AccountName)
        {
            InitializeComponent();
           // ctrlAccountCardInfo1.AccountName =AccountName;
            ctrlAccountCardInfo1.AccountID = AccountID;
            ctrlAccountTransactionInfo1.AccountID = AccountID;
            
        }

        private void frmAccountInfo_Load(object sender, EventArgs e)
        {
            ctrlAccountTransactionInfo1.LoadAccountTransactionData();
            ctrlAccountCardInfo1.LoadAccountDataByAccountID();
        }
    }
}
