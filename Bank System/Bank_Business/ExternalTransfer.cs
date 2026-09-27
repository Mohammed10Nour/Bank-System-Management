
using System;
using System.Collections.Generic;
using System.Data;
using Data_Access_Layer;
namespace Business_Layer
{
    public class clsExternalTransfer
    {
        public enum enMode { AddNew = 0, Update }
        public enMode Mode = enMode.AddNew;

        public int ID { get; set; }

        public int IBAN { get; set; }

        public string BankName { get; set; }

        public int RecipientAccountID { get; set; }

        public int TransactionID { get; set; }

        public clsExternalTransfer()
        {
            Mode = enMode.AddNew;
            ID = default;
            IBAN = default;
            BankName = default;
            RecipientAccountID = default;
            TransactionID = default;
        }

        private clsExternalTransfer(int ID, int IBAN, string BankName, int RecipientAccountID, int TransactionID)
        {
            Mode = enMode.Update;

            this.ID = ID;
            this.IBAN = IBAN;
            this.BankName = BankName;
            this.RecipientAccountID = RecipientAccountID;
            this.TransactionID = TransactionID;
        }
        public bool Save()
        {
            if (Mode == enMode.AddNew)
            {
                if (_AddNewExternalTransfer())
                {
                    Mode = enMode.Update;
                    return true;
                }
                return false;
            }
            else
            {
                return _UpdateExternalTransfer();
            }
        }
        private bool _AddNewExternalTransfer()
        {
            this.ID = clsExternalTransferData.AddNewExternalTransfer(IBAN, BankName, RecipientAccountID, TransactionID);
            return this.ID != -1;
        }

        public static DataTable GetAllData()
        {
            return clsExternalTransferData.GetAllExternalTransfer();
        }

        private bool _UpdateExternalTransfer()
        {
            return clsExternalTransferData.UpdateExternalTransfer(ID, IBAN, BankName, RecipientAccountID, TransactionID);
        }

        public static bool DeleteExternalTransfer(int ID)

        {
            return clsExternalTransferData.DeleteExternalTransfer(ID);
        }


        public static clsExternalTransfer FindExternalTransferByID(int ID)

        {
            int IBAN = default; string BankName = default; int RecipientAccountID = default; int TransactionID = default;
            if (clsExternalTransferData.FindExternalTransferByID(ID, ref IBAN, ref BankName, ref RecipientAccountID, ref TransactionID))

            {
                return new clsExternalTransfer(ID, IBAN, BankName, RecipientAccountID, TransactionID);
            }

            else
                return null;

        }



    public static int GetExternalTrnasferCountForAccount(int AccountID)
            {
            return clsExternalTransferData.GetExternalTransferCountForAccount( AccountID);
    }
  
    }
}
