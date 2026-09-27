
using System;
using System.Collections.Generic;
using System.Data;
using Data_Access_Layer;
namespace Business_Layer
{
 public class clsClient
 {
public enum enMode { AddNew = 0, Update }
public enMode Mode = enMode.AddNew;

public int ClientID { get; set; }

public string NationalNo { get; set; }

public string FullName { get; set; }

public DateTime DateOfBirth { get; set; }

public string Address { get; set; }

public bool Gender { get; set; }

public int NationalityID { get; set; }
 public string ImagePath { get; set; }

 public clsCountry Country { get; set; }

public int ContactInfoID { get; set; }
 
public clsContactInformation ContactInformation { get; set; }

public clsClient()
{
    Mode = enMode.AddNew;
    ClientID = -1;
    NationalNo = default;
    FullName = default;
    DateOfBirth = default;
    Address = default;
    Gender = default;
    NationalityID = default;
    ContactInfoID = default;
    ImagePath = default;
    ContactInformation = new clsContactInformation();
   
}

private clsClient(int ClientID, string NationalNo, string FullName, DateTime DateOfBirth, string Address,bool  Gender, int NationalityID, int ContactInfoID,string ImagePath)
{
    Mode = enMode.Update;

    this.ClientID = ClientID;
    this.NationalNo = NationalNo;
    this.FullName = FullName;
    this.DateOfBirth = DateOfBirth;
    this.Address = Address;
    this.Gender = Gender;
    this.NationalityID = NationalityID;
    this.Country = clsCountry.FindCountryByCountryID(this.NationalityID);
    this.ContactInfoID = ContactInfoID;
    this.ContactInformation = clsContactInformation.FindContactInformationByCInfoID(this.ContactInfoID);
    this.ImagePath = ImagePath;
}
public bool Save()
{
    if (Mode == enMode.AddNew)
    {
        if (_AddNewClient())
        {
            Mode = enMode.Update;
            return true;
        }
        return false;
    }
    else
    {
        return _UpdateClient();
    }
}
private bool _AddNewClient()
{
    this.ClientID = clsClientData.AddNewClient(NationalNo, FullName, DateOfBirth, Address, Gender, NationalityID, ContactInfoID,ImagePath);
    return this.ClientID != -1;
}

public static DataTable GetAllData()
{
    return clsClientData.GetAllClient();
}

private bool _UpdateClient()
{
               return clsClientData.UpdateClient(ClientID, NationalNo, FullName, DateOfBirth, Address, Gender, NationalityID, ContactInfoID,ImagePath);
}

public static bool DeleteClient( int ClientID ) 
    
   {
          return clsClientData.DeleteClient(ClientID);
   } 
public static clsClient FindClientByClientID (int ClientID) 
  
      {
       string NationalNo =default ; string FullName =default ; DateTime DateOfBirth =default ; string Address =default ; bool Gender =default ; int NationalityID =default ; int ContactInfoID =default ;string ImagePath = default;
      if (clsClientData.FindClientByClientID(ClientID, ref NationalNo, ref FullName, ref DateOfBirth, ref Address, ref Gender, ref NationalityID, ref ContactInfoID,ref ImagePath))
   
      {
         return new clsClient(ClientID, NationalNo, FullName, DateOfBirth, Address, Gender, NationalityID, ContactInfoID,ImagePath );
      }

    else
        return null;

    } 
public static clsClient FindClientByNationalNo (string NationalNo) 
  
      {
             int ClientID =default ;  string FullName =default ; DateTime DateOfBirth =default ; string Address =default ; bool Gender =default ; int NationalityID =default ; int ContactInfoID =default ;string ImagePath = default;
             if (clsClientData.FindClientByNationalNo(ref ClientID, NationalNo, ref FullName, ref DateOfBirth, ref Address, ref Gender, ref NationalityID, ref ContactInfoID,ref ImagePath ))
        
             {
                return new clsClient(ClientID, NationalNo, FullName, DateOfBirth, Address, Gender, NationalityID, ContactInfoID,ImagePath );
             }

    else
        return null;

    } 
public static bool IsClientExist(string NatinoalNo)
  {
            return clsClientData.IsClientExist(NatinoalNo);
  }
    
    }
}
