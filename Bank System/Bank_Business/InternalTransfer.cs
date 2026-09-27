
using System;
using System.Collections.Generic;
using System.Data;
using Data_Access_Layer;
namespace Business_Layer
{
    public class clsInternalTransfer
    {
public enum enMode { AddNew = 0, Update }
public enMode Mode = enMode.AddNew;

public int ID { get; set; }

public int RecipientAccount { get; set; }

public int TransactionID { get; set; }

public clsInternalTransfer()
{
    Mode = enMode.AddNew;
    ID = default;
    RecipientAccount = default;
    TransactionID = default;
}

private clsInternalTransfer(int ID, int RecipientAccount, int TransactionID)
{
    Mode = enMode.Update;

    this.ID = ID;
    this.RecipientAccount = RecipientAccount;
    this.TransactionID = TransactionID;
}
public bool Save()
{
    if (Mode == enMode.AddNew)
    {
        if (_AddNewInternalTransfer())
        {
            Mode = enMode.Update;
            return true;
        }
        return false;
    }
    else
    {
        return _UpdateInternalTransfer();
    }
}
private bool _AddNewInternalTransfer()
{
    this.ID = clsInternalTransferData.AddNewInternalTransfer(RecipientAccount, TransactionID);
    return this.ID != -1;
}

public static DataTable GetAllData()
{
    return clsInternalTransferData.GetAllInternalTransfer();
}

private bool _UpdateInternalTransfer()
{
               return clsInternalTransferData.UpdateInternalTransfer(ID, RecipientAccount, TransactionID);
}

public static bool DeleteInternalTransfer( int ID ) 
    
   {
          return clsInternalTransferData.DeleteInternalTransfer(ID);
   } 


     public static clsInternalTransfer FindInternalTransferByID (int ID) 
  
      {
              int RecipientAccount =default ; int TransactionID =default ;
             if (clsInternalTransferData.FindInternalTransferByID(ID, ref RecipientAccount, ref TransactionID))
        
             {
                return new clsInternalTransfer(ID, RecipientAccount, TransactionID);
             }

    else
        return null;

    } 
      
        public static int GetInternalTrnasferCountForAccount(int AccountID)
        {
            return clsInternalTransferData.GetInternalTransferCountForAccount(AccountID);
        }
    }
          }
