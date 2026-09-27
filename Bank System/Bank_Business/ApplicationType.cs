
using System;
using System.Collections.Generic;
using System.Data;
using Data_Access_Layer;
namespace Business_Layer
{
    public class clsApplicationType
    {
        public enum enMode { AddNew = 0, Update }
        public enMode Mode = enMode.AddNew;

        public int ApplicationTypeId { get; set; }

        public string Description { get; set; }

        public decimal Fees { get; set; }

        public clsApplicationType()
        {
            Mode = enMode.AddNew;
            ApplicationTypeId = default;
            Description = default;
            Fees = default;
        }

        private clsApplicationType(int ApplicationTypeId, string Description, decimal Fees)
        {
            Mode = enMode.Update;

            this.ApplicationTypeId = ApplicationTypeId;
            this.Description = Description;
            this.Fees = Fees;
        }

        public bool Save()
        {
            if (Mode == enMode.AddNew)
            {
                if (_AddNewApplicationType())
                {
                    Mode = enMode.Update;
                    return true;
                }
                return false;
            }
            else
            {
                return _UpdateApplicationType();
            }
        }

        private bool _AddNewApplicationType()
        {
            this.ApplicationTypeId = clsApplicationTypeData.AddNewApplicationType(Description, Fees);
            return this.ApplicationTypeId != -1;
        }

        public static DataTable GetAllData()
        {
            return clsApplicationTypeData.GetAllApplicationType();
        }

        private bool _UpdateApplicationType()
        {
            return clsApplicationTypeData.UpdateApplicationType(ApplicationTypeId, Description, Fees);
        }

        public static bool DeleteApplicationType(int ApplicationTypeId)

        {
            return clsApplicationTypeData.DeleteApplicationType(ApplicationTypeId);
        }

        public static clsApplicationType FindApplicationTypeByApplicationTypeId(byte ApplicationTypeId)

        {
            string Description = default; decimal Fees = default;
            if (clsApplicationTypeData.FindApplicationTypeByApplicationTypeId(ApplicationTypeId, ref Description, ref Fees))

            {
                return new clsApplicationType(ApplicationTypeId, Description, Fees);
            }

            else
                return null;

        }
        public static decimal GetApplicationFees(byte ApplicationTypeID)
        {
            return FindApplicationTypeByApplicationTypeId(ApplicationTypeID).Fees;
        }
    
    }

}
