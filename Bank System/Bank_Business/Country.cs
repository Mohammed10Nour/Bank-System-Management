
using System;
using System.Collections.Generic;
using System.Data;
using Data_Access_Layer;
namespace Business_Layer
{
    public class clsCountry
    {
public enum enMode { AddNew = 0, Update }
public enMode Mode = enMode.AddNew;

public int CountryID { get; set; }

public string CountryName { get; set; }

public string DialingCode { get; set; }

public clsCountry()
{
    Mode = enMode.AddNew;
    CountryID = default;
    CountryName = default;
    DialingCode = default;
}

private clsCountry(int CountryID, string CountryName, string DialingCode)
{
    Mode = enMode.Update;

    this.CountryID = CountryID;
    this.CountryName = CountryName;
    this.DialingCode = DialingCode;
}
public bool Save()
{
    if (Mode == enMode.AddNew)
    {
        if (_AddNewCountry())
        {
            Mode = enMode.Update;
            return true;
        }
        return false;
    }
    else
    {
        return _UpdateCountry();
    }
}

private bool _AddNewCountry()
{
    this.CountryID = clsCountryData.AddNewCountry(CountryName, DialingCode);
    return this.CountryID != -1;
}

public static DataTable GetAllData()
{
    return clsCountryData.GetAllCountry();
}

private bool _UpdateCountry()
{
               return clsCountryData.UpdateCountry(CountryID, CountryName, DialingCode);
}

public static bool DeleteCountry( int CountryID ) 
    
   {
          return clsCountryData.DeleteCountry(CountryID);
   } 


 public static clsCountry FindCountryByCountryID (int CountryID) 
  
      {
              string CountryName =default ; string DialingCode =default ;
             if (clsCountryData.FindCountryByCountryID(CountryID, ref CountryName, ref DialingCode))
        
             {
                return new clsCountry(CountryID, CountryName, DialingCode);
             }

    else
        return null;

    } 
   

 public static clsCountry FindCountryByCountryName (string CountryName) 
  
      {
             int CountryID =default ;  string DialingCode =default ;
             if (clsCountryData.FindCountryByCountryName(ref CountryID, CountryName, ref DialingCode))
        
             {
                return new clsCountry(CountryID, CountryName, DialingCode);
             }

    else
        return null;

    } 
       }
    }
