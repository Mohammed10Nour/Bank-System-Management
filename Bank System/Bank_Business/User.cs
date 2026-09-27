
using System;
using System.Collections.Generic;
using System.Data;
using Data_Access_Layer;
namespace Business_Layer
{
  public class clsUser
    {
private enum enMode { AddNew = 0, Update }
private enMode _Mode = enMode.AddNew;

public  enum enPermission { AddEditUsers=1,DeleteUsers=2,ShowDetailsUsersInformation=4};
public enPermission ePermission = enPermission.AddEditUsers;
public int UserID { get; set; }

public int ClientID { get; set; }

public string UserName { get; set; }

public string Password { get; set; }

public bool IsActive { get; set; }

public int Permission { get; set; }

public clsUser()
{
    _Mode = enMode.AddNew;
    UserID = -1;
    ClientID = default;
    UserName = default;
    Password = default;
    IsActive = default;
    Permission = default;
}

private clsUser(int UserID, int ClientID, string UserName, string Password, bool IsActive, int Permission)
{
    _Mode = enMode.Update;

    this.UserID = UserID;
    this.ClientID = ClientID;
    this.UserName = UserName;
    this.Password = Password;
    this.IsActive = IsActive;
    this.Permission = Permission;
}

public bool Save()
{
    if (_Mode == enMode.AddNew)
    {
        if (_AddNewUser())
        {
            _Mode = enMode.Update;
            return true;
        }
        return false;
    }
    else
    {
        return _UpdateUser();
    }
}

private bool _AddNewUser()
{
    this.UserID = clsUserData.AddNewUser(ClientID, UserName, Password, IsActive, Permission);
    return this.UserID != -1;
}

public static DataTable GetAllData()
{
    return clsUserData.GetAllUsers();
}

private bool _UpdateUser()
{
               return clsUserData.UpdateUser(UserID, ClientID, UserName, Password, IsActive, Permission);
}

public static bool DeleteUser( int UserID ) 
    
   {
          return clsUserData.DeleteUser(UserID);
   } 

public static clsUser FindUserByUserID (int UserID) 
  
      {
              int ClientID =default ; string UserName =default ; string Password =default ; bool IsActive =default ; int Permission =default ;
             if (clsUserData.FindUserByUserID(UserID, ref ClientID, ref UserName, ref Password, ref IsActive, ref Permission))
        
             {
                return new clsUser(UserID, ClientID, UserName, Password, IsActive,Permission );
             }

    else
        return null;

    } 
       
public static clsUser FindUserByClientID (int ClientID) 
  
      {
             int UserID =default ;  string UserName =default ; string Password =default ; bool IsActive =default ; int Permission =default ;
             if (clsUserData.FindUserByClientID(ref UserID, ClientID, ref UserName, ref Password, ref IsActive, ref Permission))
        
             {
                return new clsUser(UserID, ClientID, UserName, Password, IsActive,Permission);
             }

    else
        return null;

    } 
       
public static clsUser FindUserByUserName (string UserName) 
  
      {
             int UserID =default ; int ClientID =default ;  string Password =default ; bool IsActive =default ; int Permission =default ;
             if (clsUserData.FindUserByUserName(ref UserID, ref ClientID, UserName, ref Password, ref IsActive, ref Permission))
        
             {
                return new clsUser(UserID, ClientID, UserName, Password, IsActive, Permission);
             }

    else
        return null;

    } 
       
public static clsUser FindUserByUserNameAndPassword (string UserName,string Password) 
  
      {
             int UserID =default ; int ClientID =default ;  bool IsActive =default ; int Permission=default ;
             if (clsUserData.FindUserByUserNameAndPassword(ref UserID, ref ClientID,  UserName, Password, ref IsActive, ref Permission ))
        
             {
                return new clsUser(UserID, ClientID, UserName, Password, IsActive, Permission);
             }

    else
        return null;

    } 
       
public static bool IsUserExist(string UserName)
    {
            return clsUserData.IsUserExist(UserName);
     }
        public static bool IsClientExistAsUser(int ClientID)
        {
            return clsUserData.IsClientExistAsUser(ClientID);
        }
  }
  
}
