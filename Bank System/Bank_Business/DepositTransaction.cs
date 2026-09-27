
using System;
using System.Collections.Generic;
using System.Data;
using Data_Access_Layer;
namespace Business_Layer
{
    public class clsDepositTransaction
    {
public enum enMode { AddNew = 0, Update }
public enMode Mode = enMode.AddNew;

public int DTransactionID { get; set; }
        public int TransactionID { get; set; }


public clsDepositTransaction()
{
    Mode = enMode.AddNew;
    DTransactionID = default;
    TransactionID = default;
}

private clsDepositTransaction(int DTransactionID, int TransactionID)
{
    Mode = enMode.Update;

    this.DTransactionID = DTransactionID;
            this.TransactionID = TransactionID;
   
}
public bool Save()
{
    
    if (Mode == enMode.AddNew)
    {
        if (_AddNewDepositTransaction())
        {
            Mode = enMode.Update;
            return true;
        }
        return false;
    }
    else
    {
        return _UpdateDepositTransaction();
    }
}
private bool _AddNewDepositTransaction()
{
    this.DTransactionID = clsDepositTransactionData.AddNewDepositTransaction(this.TransactionID);
    return this.DTransactionID != -1;
}

public static DataTable GetAllData()
{
    return clsDepositTransactionData.GetAllDepositTransaction();
}

private bool _UpdateDepositTransaction()
{
               return clsDepositTransactionData.UpdateDepositTransaction(this.DTransactionID, this.TransactionID);
}

public static bool DeleteDepositTransaction( int DTransactionID ) 
    
   {
          return clsDepositTransactionData.DeleteDepositTransaction(DTransactionID);
   } 

        public static int GetDepositsCountForAccount(int AccountID)
        {
            return clsDepositTransactionData.GetDepositsCountForAccount(AccountID);
        }
   //  public static clsDepositTransaction FindDepositTransactionByTransactionID (int TransactionID) 

        //  {
        //         int DTransactionID =default ; 
        //         if (clsDepositTransactionData.FindDepositTransactionByTransactionID(ref DTransactionID, TransactionID))

        //         {
        //            return new clsDepositTransaction(DTransactionID, TransactionID);
        //         }

        //else
        //    return null;

        //} 
       }
          }
