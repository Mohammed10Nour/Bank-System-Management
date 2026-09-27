using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bank.Applications;
using Bank.Accounts;
using Bank.Users;
using Bank.Client;
using Business_Layer;
using Bank.Account_Transaction;
namespace Bank
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {
            clsAccount.ServiceInterest();
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.EnableVisualStyles();

            //System.Windows.Forms.Application.Run(new frmMain());
            System.Windows.Forms.Application.Run(new frmLogin());
        }
        
    }
}
