
using System;
using System.Collections.Generic;
using System.Data;
using Data_Access_Layer;
namespace Business_Layer
{
    public class clsWithDrawalTransaction
    {
public enum enMode { AddNew = 0, Update }
public enMode Mode = enMode.AddNew;

public int WTransactionID { get; set; }
public int TransactionID { get; set; }
        public clsWithDrawalTransaction()
        {
            Mode = enMode.AddNew;
            WTransactionID = default;
            TransactionID = default;
           
        }
                                                                                                                                            // 


public bool Save()
{
          
    if (Mode == enMode.AddNew)
    {
        if (_AddNewWithDrawalTransaction())
        {
            Mode = enMode.Update;
            return true;
        }
        return false;
    }
    else
    {
        return _UpdateWithDrawalTransaction();
    }
}
private bool _AddNewWithDrawalTransaction()
{
    this.WTransactionID = clsWithDrawalTransactionData.AddNewWithDrawalTransaction(this.TransactionID);
    return this.WTransactionID != -1;
}
public static DataTable GetAllData()
{
    return clsWithDrawalTransactionData.GetAllWithDrawalTransaction();
}
private bool _UpdateWithDrawalTransaction()
{
               return clsWithDrawalTransactionData.UpdateWithDrawalTransaction(WTransactionID, this.TransactionID);
}
public static bool DeleteWithDrawalTransaction( int WTransactionID ) 
    
   {
          return clsWithDrawalTransactionData.DeleteWithDrawalTransaction(WTransactionID);
   }

     
    public static int GetWithdrawalCountForAccount(int AccountID)
        {
            return clsWithDrawalTransactionData.GetWithdrawalCountForAccount(AccountID);
        }
public static decimal GetTotalWithdrawnToday(int AccountID)
        {
            return clsWithDrawalTransactionData.GetTotalWithdrawnToday(AccountID);
        }

       
}
}


























//public static clsWithDrawalTransaction FindWithDrawalTransactionByTransactionID (int TransactionID) 

//      {
//             int WTransactionID =default ; 
//             if (clsWithDrawalTransactionData.FindWithDrawalTransactionByTransactionID(ref WTransactionID, TransactionID))

//             {
//                return new clsWithDrawalTransaction(WTransactionID, TransactionID);
//             }

//    else
//        return null;

//    }       
//public static clsWithDrawalTransaction FindWithDrawalTransactionByWTransactionID (int WTransactionID) 

//      {
//              int TransactionID =default ;
//             if (clsWithDrawalTransactionData.FindWithDrawalTransactionByWTransactionID(WTransactionID, ref TransactionID))

//             {
//                return new clsWithDrawalTransaction(WTransactionID, TransactionID);
//             }

//    else
//        return null;

//    } 

//    private clsWithDrawalTransaction(int WTransactionID, int TransactionID, string TransactionName, int AccountID, decimal Amount, DateTime TransactionDate, int ApplicationID, int UserID, int ClientID, enApplicationType ApplicationType, enApplicationStatus ApplicationStatus, DateTime ApplicationDate, decimal PaidFees):base(TransactionID, TransactionName, AccountID, Amount, TransactionDate, ApplicationID, UserID, ClientID, ApplicationType, ApplicationStatus, ApplicationDate, PaidFees)

//{
//    Mode = enMode.Update;
//    this.WTransactionID = WTransactionID;
//    this.TransactionID = TransactionID;
//}