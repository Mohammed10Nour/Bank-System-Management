
using System;
using System.Collections.Generic;
using System.Data;
using Data_Access_Layer;
namespace Business_Layer
{
    public class clsAccount
    {
        public enum enMode { AddNew = 0, Update }
        public enMode Mode = enMode.AddNew;

        public enum enAccountStatus { Active = 1, Closed = 2, Frozen = 3 }
        public int AccountID { get; set; }



        public int ApplicationID { get; set; }
        public clsApplication Application { get; set; }
        
        public string AccountNumber { get; set; }

        public int AccountTypeID { get; set; }
        public clsAccountType AccountType { get; set; }
        public decimal Balance { get; set; }

        public enAccountStatus AccountState { get; set; }

        public DateTime UpdatedAt { get; set; }
        public DateTime LastInterestDate { get; set; }
        public clsAccount()
        {
            Mode = enMode.AddNew;
            AccountID = default;
            ApplicationID = default;
            AccountNumber = default;
            AccountTypeID = default;
            Balance = default;
            AccountState = default;
            UpdatedAt = default;
            LastInterestDate = default;


        }
        private clsAccount(int AccountID, string AccountNumber, int AccountTypeID, decimal Balance, enAccountStatus AccountState, DateTime UpdatedAt, int ApplicationID,DateTime LastInterestDate)

        {
            Mode = enMode.Update;
            this.AccountID = AccountID;
            this.ApplicationID = ApplicationID;
            this.Application = clsApplication.FindApplicationByApplicationID(this.ApplicationID);
            this.AccountNumber = AccountNumber;
            this.AccountTypeID = AccountTypeID;
            this.AccountType = clsAccountType.FindAccountTypeByAccountTypeID((clsAccountType.enAccountType)this.AccountTypeID);
            this.Balance = Balance;
            this.AccountState = AccountState;
            this.UpdatedAt = UpdatedAt;
            this.LastInterestDate = LastInterestDate;
        }


        public bool Save()
        {


            if (Mode == enMode.AddNew)
            {
                if (_AddNewAccount())
                {
                    Mode = enMode.Update;
                    return true;
                }
                return false;
            }
            else
            {
                return _UpdateAccount();
            }
        }

        private bool _AddNewAccount()
        {
            this.AccountID = clsAccountData.AddNewAccount(this.AccountNumber, this.AccountTypeID, this.Balance, (byte)this.AccountState, this.UpdatedAt, this.ApplicationID,this.LastInterestDate );
            return this.AccountID != -1;
        }
        public static DataTable GetAllData()
        {
            return clsAccountData.GetAllAccount();
        }
        private bool _UpdateAccount()
        {
            return clsAccountData.UpdateAccount(this.AccountID, this.AccountNumber, this.AccountTypeID, this.Balance, (byte)this.AccountState, this.UpdatedAt, this.ApplicationID,this.LastInterestDate);
        }
        public static bool DeleteAccount(int AccountID)
        {
            return clsAccountData.DeleteAccount(AccountID);
        }
        public static clsAccount FindAccountByAccountID(int AccountID)

        {
            string AccountNumber = default; int AccountTypeID = default; decimal Balance = default; int AccountState = default; DateTime UpdatedAt = default; int ApplicationID = -1;

            DateTime LastInterestDate = default;
            if (clsAccountData.FindAccountByAccountID(AccountID, ref AccountNumber, ref AccountTypeID, ref Balance, ref AccountState, ref UpdatedAt, ref ApplicationID,ref LastInterestDate ))
            {
                return new clsAccount(AccountID, AccountNumber, AccountTypeID, Balance, (enAccountStatus)AccountState, UpdatedAt, ApplicationID,LastInterestDate );
            }
            return null;
        }
        public static clsAccount FindAccountByAccountNumber(string AccountNumber)

        {
            int AccountID = default; int AccountTypeID = default; decimal Balance = default; int AccountState = default; DateTime UpdatedAt = default; int ApplicationID = -1;
            DateTime LastInterestDate = default;
            if (clsAccountData.FindAccountByAccountNumber(ref AccountID, AccountNumber, ref AccountTypeID, ref Balance, ref AccountState, ref UpdatedAt, ref ApplicationID,ref LastInterestDate ))
            {
                return new clsAccount(AccountID, AccountNumber, AccountTypeID, Balance, (enAccountStatus)AccountState, UpdatedAt, ApplicationID,LastInterestDate );
            }
            return null;

        }
        public static clsAccount FindAccountByApplicationID(int ApplicationID)

        {
            string AccountNumber = default; int AccountTypeID = default; decimal Balance = default; int AccountState = default; DateTime UpdatedAt = default; int AccountID = -1;
            DateTime LastInterestDate = default;
            if (clsAccountData.FindAccountByApplicationID(ref AccountID, ref AccountNumber, ref AccountTypeID, ref Balance, ref AccountState, ref UpdatedAt, ApplicationID,ref LastInterestDate ))
            {
                return new clsAccount(AccountID, AccountNumber, AccountTypeID, Balance, (enAccountStatus)AccountState, UpdatedAt, ApplicationID,LastInterestDate );
            }
            return null;
        }
        public static bool IsClientHasAccount(int ClientID, clsAccountType.enAccountType AccountType)
        {
            return clsAccountData.IsClientHasAccount(ClientID, (byte)AccountType);
        }
        public static bool IsAccountExist(int AccountNumber)
        {
            return clsAccountData.IsAccountExist(AccountNumber);
        }
        public static clsAccount.enAccountStatus GetAccountState(int AccountID)
        {
            return (clsAccount.enAccountStatus)clsAccountData.GetAccountState(AccountID);
        }
      
        public static void ServiceInterest()
        { 
            DataTable DataAccounts = new DataTable();
            DataAccounts = clsAccountData.GetDataAboutInterest();
            clsAccount Account = null;
            int AccountID = default ;
            decimal InterestRate =default ;
            DateTime LastInterestDate = default;
            int Days = default;
            foreach (DataRow R in DataAccounts.Rows)
            {
               
                AccountID = Convert.ToInt16(R["AccountID"]);
                InterestRate = Convert.ToDecimal(R["InterestRate"]);
                LastInterestDate = Convert.ToDateTime(R["LastInterestDate"]);
                switch (R["AccountTypeID"])
                {
                    case 1:
                        {
                            Days = 7;                        
                            break;
                        }
                    case 2:
                        {
                            Days = 30;
                            break;
                        }
                    case 3:
                        {
                            Days = 365;
                            break;
                        }
                }
                if ( LastInterestDate == default||DateTime.Now>=LastInterestDate.AddDays(Days))
                {
                    Account = clsAccount.FindAccountByAccountID(AccountID);
                    
                    if (Account == null)
                        continue;
                    Account.Balance += Account.Balance * InterestRate/100;
                    Account.LastInterestDate = DateTime.Now;
                    Account.UpdatedAt = DateTime.Now;
                    Account.Save();
                }

            }

        }

    }


}