
using System;
using System.Collections.Generic;
using System.Data;
using System.Security.Principal;
using Data_Access_Layer;
namespace Business_Layer
{
    public class clsAccountType
    {
        public enum enMode { AddNew = 0, Update }
        public enMode Mode = enMode.AddNew;
        public enum enAccountType
        {
            BASIC_SAVINGS = 1,
            PREMIUM_SAVINGS = 2,
            GOLD_SAVINGS = 3
        }
        public enum enInterestPeriod
        {
            Weekly=1,
            Monthly=2,
            Yearly=3
        }

        public enAccountType AccountType { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal MinBalance
        {
            get
            {
                switch (this.AccountType)
                {
                    case enAccountType.BASIC_SAVINGS:
                        {
                            return 100;
                        }
                    case enAccountType.PREMIUM_SAVINGS:
                        {
                            return 2500;
                        }
                    case enAccountType.GOLD_SAVINGS:
                        {
                            return 20000;
                        }
                }
                return 0;
            }

        }

        public decimal InterestRate { get; set; }

        public enInterestPeriod InterestPeriod { get; set; }

        public decimal MaxDailyWithDrawAmount { get; set; }

        public int NumberDailyWithDrawals { get; set; }


        public clsAccountType()
        {
            Mode = enMode.AddNew;
            AccountType = enAccountType.BASIC_SAVINGS;
            Name = default;
            Description = default;
           // MinBalance = default;
            InterestRate = default;
            InterestPeriod = default;
            MaxDailyWithDrawAmount = default;
            NumberDailyWithDrawals = default;
        }
        private clsAccountType(enAccountType AccountType, string Name, string Description, decimal MinBalance, decimal InterestRate, enInterestPeriod InterestPeriod, decimal MaxDailyWithDrawAmount, int NumberDailyWithDrawals)
        {
            Mode = enMode.Update;
            this.AccountType = AccountType;
            this.Name = Name;
            this.Description = Description;
            //   this.MinBalance = MinBalance;
            this.InterestRate = InterestRate;
            this.InterestPeriod = InterestPeriod;
            this.MaxDailyWithDrawAmount = MaxDailyWithDrawAmount;
            this.NumberDailyWithDrawals = NumberDailyWithDrawals;
        }
        public bool Save()
        {
            if (Mode == enMode.AddNew)
            {
                if (_AddNewAccountType())
                {
                    Mode = enMode.Update;
                    return true;
                }
                return false;
            }
            else
            {
                return _UpdateAccountType();
            }
        }
        private bool _AddNewAccountType()
        {
            this.AccountType = (enAccountType)clsAccountTypeData.AddNewAccountType(Name, Description, MinBalance, InterestRate,(byte) InterestPeriod, MaxDailyWithDrawAmount, NumberDailyWithDrawals);
            return (int)this.AccountType != -1;
        }
        public static DataTable GetAllData()
        {
            return clsAccountTypeData.GetAllAccountType();
        }
        private bool _UpdateAccountType()
        {
            return clsAccountTypeData.UpdateAccountType((byte)AccountType, Name, Description, MinBalance, InterestRate, (byte)InterestPeriod, MaxDailyWithDrawAmount, NumberDailyWithDrawals);
        }
        public static bool DeleteAccountType(enAccountType AccountTypeID)

        {
            return clsAccountTypeData.DeleteAccountType((byte)AccountTypeID);
        }
        public static clsAccountType FindAccountTypeByAccountTypeID(enAccountType AccountType)

        {
            string Name = default; string Description = default; decimal MinBalance = default; decimal InterestRate = default; byte InterestPeriod = default; decimal MaxDailyWithDrawAmount = default; int NumberDailyWithDrawals = default;
            if (clsAccountTypeData.FindAccountTypeByAccountTypeID((byte)AccountType, ref Name, ref Description, ref MinBalance, ref InterestRate, ref InterestPeriod, ref MaxDailyWithDrawAmount, ref NumberDailyWithDrawals))

            {
                return new clsAccountType(AccountType, Name, Description, MinBalance, InterestRate, (enInterestPeriod)InterestPeriod, MaxDailyWithDrawAmount, NumberDailyWithDrawals);
            }

            else
                return null;
        }

       
    }
}
