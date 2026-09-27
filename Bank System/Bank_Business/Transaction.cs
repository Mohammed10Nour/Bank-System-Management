
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Data_Access_Layer;
namespace Business_Layer
{
    public class clsTransaction:clsApplication
    {
public enum enMode { AddNew = 0, Update }
public enMode Mode = enMode.AddNew;

public enum enTransactionName { WithDraw=1,Deposit=2,InternalTransfer=3,ExternalTransfer=4};
public int TransactionID { get; set; }

public string TransactionName { get; set; }

public int AccountID { get; set; }

public decimal Amount { get; set; }



public clsTransaction()
{
    Mode = enMode.AddNew;
    TransactionID = default;
    TransactionName = default;
    AccountID = default;
    Amount = default;
 
}

protected clsTransaction(int TransactionID, string TransactionName, int AccountID, decimal Amount, DateTime TransactionDate, int ApplicationID, int UserID,int ClientID, enApplicationType ApplicationType, enApplicationStatus ApplicationStatus, DateTime ApplicationDate, decimal PaidFees)
:base(ApplicationID,ClientID ,ApplicationType ,ApplicationStatus ,ApplicationDate ,PaidFees ,UserID)
     {
    Mode = enMode.Update;

    this.TransactionID = TransactionID;
    this.TransactionName = TransactionName;
    this.AccountID = AccountID;
    this.Amount = Amount;  
   
}
public bool Save()
{
        base.Mode =(clsApplication.enMode)this.Mode;
        if (!base.Save()) return false;

    if (Mode == enMode.AddNew)
    {
        if (_AddNewTransaction())
        {
            Mode = enMode.Update;
            return true;
        }
        return false;
    }
    else
    {
        return _UpdateTransaction();
    }
}
private bool _AddNewTransaction()
{
    this.TransactionID = clsTransactionData.AddNewTransaction(this.TransactionName, this.AccountID, this.Amount, this.ApplicationDate,this.ApplicationID, this.UserID);
    return this.TransactionID != -1;
}
     
     public static DataTable GetAllData()
{
    return clsTransactionData.GetAllTransaction();
}    
     private bool _UpdateTransaction()
{
        

          
            return clsTransactionData.UpdateTransaction(this.TransactionID, this.TransactionName, this.AccountID, this.Amount, this.ApplicationDate, this.ApplicationID, this.UserID);
}   
     public static bool DeleteTransaction( int TransactionID ) 
    
   {
          
            return clsTransactionData.DeleteTransaction(TransactionID);
   } 
     public static int GetWithdrawalCountForAccount(int AccountID)
        {
           
              return clsWithDrawalTransaction.GetWithdrawalCountForAccount(AccountID);
         


        }
        public static int GetDepositsCountForAccount(int AccountID)
        {
            return clsDepositTransaction.GetDepositsCountForAccount(AccountID);
        }
          
     public static int GetInternalTrnasferCountForAccount(int AccountID)
        {
            return clsInternalTransfer.GetInternalTrnasferCountForAccount(AccountID);
        }
     public static int GetExternalTrnasferCountForAccount(int AccountID)
        {
            return clsExternalTransfer.GetExternalTrnasferCountForAccount(AccountID);
        }




















        // public static clsTransaction FindTransactionByTransactionID (int TransactionID) 

        //  {
        //          string TransactionName =default ; int AccountID =default ; decimal Amount =default ; DateTime TransactionDate =default ; int ApplicationID =default ; int UserID =default ;
        //         if (clsTransactionData.FindTransactionByTransactionID(TransactionID, ref TransactionName, ref AccountID, ref Amount, ref TransactionDate, ref ApplicationID, ref UserID))

        //         {
        //            return new clsTransaction(TransactionID, TransactionName, AccountID, Amount, TransactionDate, ApplicationID, UserID);
        //         }

        //else
        //    return null;

        //} 

        // public static clsTransaction FindTransactionByAccountID (int AccountID) 

        //  {
        //         int TransactionID =default ; string TransactionName =default ;  decimal Amount =default ; DateTime TransactionDate =default ; int ApplicationID =default ; int UserID =default ;
        //         if (clsTransactionData.FindTransactionByAccountID(ref TransactionID, ref TransactionName, AccountID, ref Amount, ref TransactionDate, ref ApplicationID, ref UserID))

        //         {
        //            return new clsTransaction(TransactionID, TransactionName, AccountID, Amount, TransactionDate, ApplicationID, UserID);
        //         }

        //else
        //    return null;

        //} 


        // public static clsTransaction FindTransactionByApplicationID (int ApplicationID) 

        //  {

        //        int TransactionID =default ; string TransactionName =default ; int AccountID =default ; decimal Amount =default ; DateTime TransactionDate =default ;  int UserID =default ;

        //        //Find Application Info 
        //        clsApplication Application = clsApplication.FindApplicationByApplicationID(ApplicationID);
        //        if (Application!=null)
        //        {
        //            if (clsTransactionData.FindTransactionByApplicationID(ref TransactionID, ref TransactionName, ref AccountID, ref Amount, ref TransactionDate, ApplicationID, ref UserID))

        //            {
        //                return new clsTransaction(TransactionID, TransactionName, AccountID, Amount, TransactionDate, ApplicationID, Application.UserID, Application.ClientID,Application.enAppType, Application.ApplicationStatus,Application.ApplicationDate, Application.PaidFees);
        //            }
        //        }
        //else
        //    return null;
        //        return null;

        //}

    }
}
