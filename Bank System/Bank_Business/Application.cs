
using System;
using System.Collections.Generic;
using System.Data;
using Data_Access_Layer;
namespace Business_Layer
{
    public class clsApplication
    {
    public enum enMode { AddNew = 0, Update }
    public enMode Mode = enMode.AddNew;

    public enum enApplicationStatus { New = 1, Cancelled = 2, Completed = 3};
    public enum enApplicationType
        {
            OPEN_ACCOUNT =25,
            DEPOSIT ,
            WITHDRAW ,
            TRANSFER_INTERNAL,
            TRANSFER_EXTERNAL,
            ISSUE_ATM_CARD,
            REPLACE_CARD,
            FREEZE_ACCOUNT,
            REACTIVATE_ACCOUNT ,
            CLOSE_ACCOUNT ,
            CHECK_BALANCE ,
            VIEW_STATEMENT
        }
    public enApplicationType enAppType { get; set; }
    public clsApplicationType ApplicationType { get; set; }
    public int ClientID { get; set; }
    public clsClient Client { get; set; }
  
    public int ApplicationID { get; set; }
    
    public enApplicationStatus  ApplicationStatus { get; set; }
    
    public DateTime ApplicationDate { get; set; }
    
    public decimal PaidFees { get; set; }
    
    public int UserID { get; set; }

     public clsApplication()
        {
            Mode = enMode.AddNew;
            ApplicationID = -1;
            ClientID = -1;
            enAppType = enApplicationType.OPEN_ACCOUNT;
            ApplicationStatus = default;
            ApplicationDate = default;
            PaidFees = default;
            UserID = -1;
        }
    protected clsApplication(int ApplicationID, int ClientID, enApplicationType ApplicationType, enApplicationStatus ApplicationStatus, DateTime ApplicationDate, decimal PaidFees, int UserID)
    {
    Mode = enMode.Update;

    this.ApplicationID = ApplicationID;
    this.ClientID = ClientID;
    this.Client = clsClient.FindClientByClientID(this.ClientID);
    this.enAppType = ApplicationType;
    
    this.ApplicationType = clsApplicationType.FindApplicationTypeByApplicationTypeId((byte)this.enAppType);
    this.ApplicationStatus = ApplicationStatus;
    this.ApplicationDate = ApplicationDate;
    this.PaidFees = PaidFees;
    this.UserID = UserID;
     }
    
    public bool Save()
       
        { 
         if (Mode == enMode.AddNew)
         {
        if (_AddNewApplication())
        {
            Mode = enMode.Update;
            return true;
        }
        return false;
    }
    else
    {
        return _UpdateApplication();
    }
}

    private bool _AddNewApplication()
{
    this.ApplicationID = clsApplicationData.AddNewApplication(ClientID, (byte)enAppType, (byte)ApplicationStatus, ApplicationDate, PaidFees, UserID);
    return this.ApplicationID != -1;
}

    public static DataTable GetAllData()
{
    return clsApplicationData.GetAllApplication();
}

    private bool _UpdateApplication()
{
               return clsApplicationData.UpdateApplication(ApplicationID, ClientID, (byte)enAppType, (byte)ApplicationStatus, ApplicationDate, PaidFees, UserID);
}

    public static bool DeleteApplication( int ApplicationID ) 
    
   {
          return clsApplicationData.DeleteApplication(ApplicationID);
   } 

    public static clsApplication FindApplicationByApplicationID (int ApplicationID) 
  
      {
              int ClientID =default ; int ApplicationType=default ; int ApplicationStatus =default ; DateTime ApplicationDate =default ; decimal PaidFees =default ; int UserID =default ;
             if (clsApplicationData.FindApplicationByApplicationID(ApplicationID, ref ClientID, ref ApplicationType,  ref ApplicationStatus, ref ApplicationDate, ref PaidFees, ref UserID))
        
             {
                return new clsApplication(ApplicationID, ClientID,(enApplicationType) ApplicationType,(enApplicationStatus)ApplicationStatus, ApplicationDate, PaidFees, UserID);
             }

    else
        return null;

    } 
       
    public static clsApplication FindApplicationByApplicationTypeID (int ApplicationType) 
  
      {
             int ApplicationID =default ; int ClientID =default ;  int ApplicationStatus =default ; DateTime ApplicationDate =default ; decimal PaidFees =default ; int UserID =default ;
             if (clsApplicationData.FindApplicationByApplicationTypeID(ref ApplicationID, ref ClientID, ApplicationType, ref ApplicationStatus, ref ApplicationDate, ref PaidFees, ref UserID))
        
             {
                return new clsApplication(ApplicationID, ClientID, (enApplicationType) ApplicationType, (enApplicationStatus)ApplicationStatus, ApplicationDate, PaidFees, UserID);
             }

    else
        return null;

    } 
   
    public static clsApplication FindApplicationByClientID (int ClientID) 
  
      {
             int ApplicationID =default ;  int ApplicationType =default ; int ApplicationStatus =default ; DateTime ApplicationDate =default ; decimal PaidFees =default ; int UserID =default ;
             if (clsApplicationData.FindApplicationByClientID(ref ApplicationID, ClientID, ref ApplicationType, ref ApplicationStatus, ref ApplicationDate, ref PaidFees, ref UserID))
        
             {
                return new clsApplication(ApplicationID, ClientID,(enApplicationType) ApplicationType, (enApplicationStatus)ApplicationStatus, ApplicationDate, PaidFees, UserID);
             }

    else
        return null;

    } 
       
    public static clsApplication FindApplicationByUserID (int UserID) 
  
      {
             int ApplicationID =default ; int ClientID =default ; int ApplicationType =default ; int ApplicationStatus =default ; DateTime ApplicationDate =default ; decimal PaidFees =default ; 
             if (clsApplicationData.FindApplicationByUserID(ref ApplicationID, ref ClientID, ref ApplicationType, ref ApplicationStatus, ref ApplicationDate, ref PaidFees, UserID))
        
             {
                return new clsApplication(ApplicationID, ClientID,(enApplicationType ) ApplicationType, (enApplicationStatus)ApplicationStatus, ApplicationDate, PaidFees, UserID);
             }

    else
        return null;

    } 
    
    public void SetComplete()
        {
            clsApplicationData.SetComplete(this.ApplicationID, (int)this.ApplicationStatus);
        }
    }
 
}
