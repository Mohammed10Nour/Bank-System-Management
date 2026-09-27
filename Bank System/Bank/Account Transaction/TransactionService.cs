using Business_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Web.Util;
using System.Windows.Forms;

namespace Bank.Account_Transaction
{
    internal class TransactionService
    {
        public int ExecuteTransaction( clsAccount Account,clsAccount RecieverAccount,decimal Amount,clsApplication.enApplicationType enAppType,int Iban,decimal Fees,int UserID,int ReciverAccountID)
        {
            _ValidateBusinessRules( Account, Amount, enAppType);
            int transactionId = _CreateTransactionAndSaveIt( Account, Amount, enAppType, UserID, Fees);
            if (transactionId <= 0)
                throw new Exception(" العملية فشلت ");

            _Process(Account, RecieverAccount, Amount, enAppType,Iban, transactionId,ReciverAccountID );
            return transactionId;
        }
        private void _ValidateBusinessRules( clsAccount Account,decimal Amount,clsApplication.enApplicationType enAppType)
        {
            if ((enAppType == clsApplication.enApplicationType.WITHDRAW || (enAppType == clsApplication.enApplicationType.TRANSFER_INTERNAL || (enAppType == clsApplication.enApplicationType.TRANSFER_EXTERNAL))) && Amount > Account.Balance)
            {

                throw new Exception("عذراً لاتمتلك رصيد كاف في حسابك لاتمام هذه العملية !");//, "Warrning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
            if (clsWithDrawalTransaction.GetWithdrawalCountForAccount(Account.AccountID) >= Account.AccountType.NumberDailyWithDrawals && enAppType == clsApplication.enApplicationType.WITHDRAW)
            {
                throw new Exception("عذراً,لايمكن القيام بهذا الاجراء ,لقد وصلت الى العدد الاقصى المسموح لعمليات السحب من حسابك لهذا اليوم ");//, "Warrning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
            if (enAppType == clsApplication.enApplicationType.WITHDRAW && clsWithDrawalTransaction.GetTotalWithdrawnToday(Account.AccountID) >= Account.AccountType.MaxDailyWithDrawAmount)

            {
                throw new Exception("عذراً,لايمكن القيام بهذا الاجراء ,لقد وصلت الى الحد الاقصى المسموح لعمليات السحب من حسابك لهذا اليوم ");
              
            }
           

        }
        private int _CreateTransactionAndSaveIt( clsAccount Account,decimal Amount,clsApplication.enApplicationType enAppType,int UserID,decimal Fees)
      {
            clsTransaction newTransaction = new clsTransaction();
            newTransaction.TransactionName = enAppType.ToString();
            newTransaction.AccountID = Account.AccountID;
            newTransaction.Amount = Amount;
            newTransaction.UserID = UserID;
            newTransaction.ClientID = Account.Application.Client.ClientID;
            newTransaction.enAppType =enAppType;
            newTransaction.ApplicationStatus = clsApplication.enApplicationStatus.New;
            newTransaction.ApplicationDate = DateTime.Now;
            newTransaction.PaidFees = Fees;
            if (newTransaction.Save())
            {
                newTransaction.ApplicationStatus = clsApplication.enApplicationStatus.Completed;
                newTransaction.Save();
                return newTransaction.TransactionID;

            }
            else return -1;
        }
        private void _Process(clsAccount Account,clsAccount ReceiverAccount,Decimal Amount,clsApplication.enApplicationType enAppType,int Iban,int transactionID,int ReciverAccountID)
        {
            switch (enAppType)
            {
                case clsApplication.enApplicationType.WITHDRAW:
                    {
                        Account.Balance -= Amount;
                        new clsWithDrawalTransaction { WTransactionID = transactionID }.Save();


                        break;
                    }
                case clsApplication.enApplicationType.DEPOSIT:
                    {
                        Account.Balance += Amount;
                        new clsDepositTransaction
                        {
                            TransactionID = transactionID
                        }.Save();

                        break;
                    }
                case clsApplication.enApplicationType.TRANSFER_INTERNAL:
                    {
                        Account.Balance -=Amount;
                       
                       ReceiverAccount.Balance += Amount;
                        new clsInternalTransfer
                        {
                            TransactionID = transactionID,
                            RecipientAccount = ReceiverAccount.AccountID
                        }.Save();
                       ReceiverAccount.Save();

                        break;
                    }
                case clsApplication.enApplicationType.TRANSFER_EXTERNAL:
                    {
                        Account.Balance -= Amount;

                        new clsExternalTransfer
                        {

                            TransactionID = transactionID,
                            RecipientAccountID = ReciverAccountID,
                            IBAN = Iban
                        }.Save();

                        break;
                    }
            }
        }
    
    }
}
