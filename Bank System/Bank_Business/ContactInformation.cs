
using System;
using System.Collections.Generic;
using System.Data;
using Data_Access_Layer;
namespace Business_Layer
{
    public class clsContactInformation
    {
public enum enMode { AddNew = 0, Update }
public enMode Mode = enMode.AddNew;

public int CInfoID { get; set; }

public string Phone { get; set; }

public string Email { get; set; }


public clsContactInformation()
{
    Mode = enMode.AddNew;
    CInfoID = default;
    Phone = default;
    Email = default;
}

private clsContactInformation(int CInfoID, string Phone, string Email)
{
    Mode = enMode.Update;

    this.CInfoID = CInfoID;
    this.Phone = Phone;
    this.Email = Email;
   // this.AlternativePhone = AlternativePhone;
}
public bool Save()
{
    if (Mode == enMode.AddNew)
    {
        if (_AddNewContactInformation())
        {
            Mode = enMode.Update;
            return true;
        }
        return false;
    }
    else
    {
        return _UpdateContactInformation();
    }
}
private bool _AddNewContactInformation()
{
    this.CInfoID = clsContactInformationData.AddNewContactInformation(Phone, Email);
    return this.CInfoID != -1;
}

public static DataTable GetAllData()
{
    return clsContactInformationData.GetAllContactInformation();
}

private bool _UpdateContactInformation()
{
               return clsContactInformationData.UpdateContactInformation(CInfoID, Phone, Email);
}

public static bool DeleteContactInformation( int CInfoID ) 
    
   {
          return clsContactInformationData.DeleteContactInformation(CInfoID);
   } 


     public static clsContactInformation FindContactInformationByCInfoID (int CInfoID) 
  
      {
              string Phone =default ; string Email =default ;
             if (clsContactInformationData.FindContactInformationByCInfoID(CInfoID, ref Phone, ref Email))
        
             {
                return new clsContactInformation(CInfoID, Phone, Email);
             }

    else
        return null;

    } 
       }
          }
