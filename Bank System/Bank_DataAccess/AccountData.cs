using Bank_DataAccess;
using Microsoft.SqlServer.Server;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;

namespace Data_Access_Layer
{
    public class clsAccountData
    {
        


public static int AddNewAccount(string AccountNumber, int AccountTypeID, decimal Balance, int AccountState, DateTime UpdatedAt, int ApplicationID,DateTime LastInterestDate)
{
            SqlConnection connection = new SqlConnection(clsDataAccess.ConnectionString);

    string query = "INSERT INTO Account (AccountNumber, AccountTypeID, Balance, AccountState, UpdatedAt, ApplicationID,LastInterestDate) " +
                   "VALUES (@AccountNumber, @AccountTypeID, @Balance, @AccountState, @UpdatedAt, @ApplicationID,@LastInterestDate);" +
                   "SELECT SCOPE_IDENTITY();";

    SqlCommand command = new SqlCommand(query, connection);
    command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
    command.Parameters.AddWithValue("@AccountTypeID", AccountTypeID);
    command.Parameters.AddWithValue("@Balance", Balance);
    command.Parameters.AddWithValue("@AccountState", AccountState);
    command.Parameters.AddWithValue("@UpdatedAt", UpdatedAt);
    command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@LastInterestDate", LastInterestDate ); 
    int insertedID = -1;

    try
    {
        connection.Open();
        object result = command.ExecuteScalar();

        if (result != null && int.TryParse(result.ToString(), out int id))
        {
            insertedID = id;
        }
    }
    catch (Exception ex)
    {
    }
    finally
    {
        connection.Close();
    }

    return insertedID;
}


public static DataTable GetAllAccount()
{
    SqlConnection Connection = new SqlConnection(clsDataAccess.ConnectionString);

            string Query = @"
select Account.AccountID,Account.AccountNumber , AccountName=
    CASE Account.AccountTypeID
        WHEN 1 THEN 'Basic Savings'
        WHEN 2 THEN 'Premium Savings'
        WHEN 3 THEN 'Gold Savings'
        ELSE 'Unknown Role'
    END,
     Client.FullName ClientName,Account.Balance,AccountState=
    CASE Account.AccountState 
        WHEN 1 THEN 'Active'
        WHEN 2 THEN 'Closed'
        WHEN 3 THEN 'Forzen'
       
        ELSE 'Unknown'
    END,Account.UpdatedAt
    From Account 
    inner join Application on Account.ApplicationID=Application.ApplicationID
    inner join  Client on Application.ClientID=Client.ClientID


"
        ;
    SqlCommand Command = new SqlCommand(Query, Connection);
    DataTable DT = new DataTable();

    try
    {
        Connection.Open();

        SqlDataReader Reader = Command.ExecuteReader();
        DT.Load(Reader);

        Reader.Close();
    }
    catch (Exception ex)
    {
        // Handle error
    }
    finally
    {
        Connection.Close();
    }

    return DT;
}



public static bool UpdateAccount(int AccountID, string AccountNumber, int AccountTypeID, decimal Balance, int AccountState, DateTime UpdatedAt, int ApplicationID,DateTime LastInterestDate) 
{
    int RowAffected = -1;
    SqlConnection Connection = new SqlConnection(clsDataAccess.ConnectionString);
    string Query = @"Update Account 
                      set AccountNumber=@AccountNumber,AccountTypeID=@AccountTypeID,Balance=@Balance,AccountState=@AccountState,UpdatedAt=@UpdatedAt,ApplicationID=@ApplicationID,LastInterestDate=@LastInterestDate
                       where AccountID=@AccountID";
    SqlCommand Command = new SqlCommand(Query, Connection);
    Command.Parameters.AddWithValue("@AccountID", AccountID);
    Command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
    Command.Parameters.AddWithValue("@AccountTypeID", AccountTypeID);
    Command.Parameters.AddWithValue("@Balance", Balance);
    Command.Parameters.AddWithValue("@AccountState", AccountState);
    Command.Parameters.AddWithValue("@UpdatedAt", UpdatedAt);
    Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
    Command.Parameters.AddWithValue("@LastInterestDate", LastInterestDate); 

    try
    {
        Connection.Open();
        RowAffected = Command.ExecuteNonQuery();
    }
    catch (Exception ex)
    {

    }
    finally
    {
        Connection.Close();
    }

    return RowAffected > 0;
}

public static bool DeleteAccount ( int  AccountID ) 
 { 
    int RowsAffected = -1;
    SqlConnection Connection = new SqlConnection(clsDataAccess.ConnectionString);
            string Query = @"
UPDATE Application 
SET ApplicationStatus = 2
WHERE ApplicationID = (
    SELECT ApplicationID 
    FROM Account 
    WHERE AccountID = @AccountID
);

DELETE FROM Account 
WHERE AccountID = @AccountID;
";
            SqlCommand Command = new SqlCommand(Query, Connection);
    Command.Parameters.AddWithValue("@AccountID", AccountID);
    try
      {
          Connection.Open();
          RowsAffected = Command.ExecuteNonQuery();
     
      }
      catch (Exception ex)
      {
     
      }
     
      finally
      {
          Connection.Close();
     
      }
      return RowsAffected > 0;
      } 
      

            public static bool FindAccountByAccountID(int AccountID, ref string AccountNumber, ref int AccountTypeID, ref decimal Balance, ref int AccountState, ref DateTime UpdatedAt, ref int ApplicationID,ref DateTime LastInterestDate)
            {
                bool Found = false;
            
                SqlConnection Connection = new SqlConnection(clsDataAccess.ConnectionString);
            
                string Query = "SELECT * FROM Account WHERE AccountID=@AccountID";
            
                SqlCommand Command = new SqlCommand(Query, Connection);
                Command.Parameters.AddWithValue("@AccountID", AccountID);
            
                try
                {
                    Connection.Open();
            
                    SqlDataReader Reader = Command.ExecuteReader();
            
                    if (Reader.Read())
                    {
                        Found = true;
            
                         

                if (Reader["AccountNumber"] == DBNull.Value) AccountNumber = default;
                  else AccountNumber = (string)Reader["AccountNumber"];

                if (Reader["AccountTypeID"] == DBNull.Value) AccountTypeID = default;
                  else AccountTypeID = (int)Reader["AccountTypeID"];

                if (Reader["Balance"] == DBNull.Value) Balance = default;
                  else Balance = (decimal)Reader["Balance"];

                if (Reader["AccountState"] == DBNull.Value) AccountState = default;
                  else AccountState = (int)Reader["AccountState"];

                if (Reader["UpdatedAt"] == DBNull.Value) UpdatedAt = default;
                  else UpdatedAt = (DateTime)Reader["UpdatedAt"];

                if (Reader["ApplicationID"] == DBNull.Value) ApplicationID = default;
                  else ApplicationID = (int)Reader["ApplicationID"];
                    // LastInterestDate
                    if (Reader["LastInterestDate"] == DBNull.Value) LastInterestDate = default;
                    else LastInterestDate = (DateTime)Reader["LastInterestDate"];
                    Reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    Found = false;
               
                }
                finally
                {
                    Connection.Close();
                }
            
                return Found;
            }

            public static bool FindAccountByApplicationID(ref int AccountID, ref string AccountNumber, ref int AccountTypeID, ref decimal Balance, ref int AccountState, ref DateTime UpdatedAt, int ApplicationID,ref DateTime LastInterestDate)
            {
                bool Found = false;
            
                SqlConnection Connection = new SqlConnection(clsDataAccess.ConnectionString);
            
                string Query = "SELECT * FROM Account WHERE ApplicationID=@ApplicationID";
            
                SqlCommand Command = new SqlCommand(Query, Connection);
                Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            
                try
                {
                    Connection.Open();
            
                    SqlDataReader Reader = Command.ExecuteReader();
            
                    if (Reader.Read())
                    {
                        Found = true;
            
                        if (Reader["AccountID"] == DBNull.Value) AccountID = default;
                  else AccountID = (int)Reader["AccountID"];

                if (Reader["AccountNumber"] == DBNull.Value) AccountNumber = default;
                  else AccountNumber = (string)Reader["AccountNumber"];

                if (Reader["AccountTypeID"] == DBNull.Value) AccountTypeID = default;
                  else AccountTypeID = (int)Reader["AccountTypeID"];

                if (Reader["Balance"] == DBNull.Value) Balance = default;
                  else Balance = (decimal)Reader["Balance"];

                if (Reader["AccountState"] == DBNull.Value) AccountState = default;
                  else AccountState = (int)Reader["AccountState"];

                if (Reader["UpdatedAt"] == DBNull.Value) UpdatedAt = default;
                  else UpdatedAt = (DateTime)Reader["UpdatedAt"];

                    if (Reader["LastInterestDate"] == DBNull.Value) LastInterestDate = default;
                    else LastInterestDate = (DateTime)Reader["LastInterestDate"];

                    Reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    Found = false;
                }
                finally
                {
                    Connection.Close();
                }
            
                return Found;
            }

            public static bool FindAccountByAccountNumber(ref int AccountID, string AccountNumber, ref int AccountTypeID, ref decimal Balance, ref int AccountState, ref DateTime UpdatedAt, ref int ApplicationID,ref DateTime LastInterestDate)
            {
                bool Found = false;
            
                SqlConnection Connection = new SqlConnection(clsDataAccess.ConnectionString);
            
                string Query = "SELECT * FROM Account WHERE AccountNumber=@AccountNumber";
            
                SqlCommand Command = new SqlCommand(Query, Connection);
                Command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            
                try
                {
                    Connection.Open();
            
                    SqlDataReader Reader = Command.ExecuteReader();
            
                    if (Reader.Read())
                    {
                        Found = true;
            
                        if (Reader["AccountID"] == DBNull.Value) AccountID = default;
                  else AccountID = (int)Reader["AccountID"];

                 

                if (Reader["AccountTypeID"] == DBNull.Value) AccountTypeID = default;
                  else AccountTypeID = (int)Reader["AccountTypeID"];

                if (Reader["Balance"] == DBNull.Value) Balance = default;
                  else Balance = (decimal)Reader["Balance"];

                if (Reader["AccountState"] == DBNull.Value) AccountState = default;
                  else AccountState = (int)Reader["AccountState"];

                if (Reader["UpdatedAt"] == DBNull.Value) UpdatedAt = default;
                  else UpdatedAt = (DateTime)Reader["UpdatedAt"];

                if (Reader["ApplicationID"] == DBNull.Value) ApplicationID = default;
                  else ApplicationID = (int)Reader["ApplicationID"];
                 
                    if (Reader["LastInterestDate"] == DBNull.Value) LastInterestDate = default;
                    else LastInterestDate = (DateTime)Reader["LastInterestDate"];
                    Reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    Found = false;
                }
                finally
                {
                    Connection.Close();
                }
            
                return Found;
            }
    
        public static bool IsClientHasAccount(int ClientID,byte AccountTypeID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccess.ConnectionString);

            string query = @"select found=1 from Account 
inner join Application
ON Account.ApplicationID=Application.ApplicationID
and ClientID=@ClientID and AccountTypeID=@AccountTypeID;";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ClientID",ClientID);
            command.Parameters.AddWithValue("@AccountTypeID", AccountTypeID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;

                reader.Close();
            }
            catch (Exception ex)
            {
               
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }
        public static bool IsAccountExist(int AccountNumber)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccess.ConnectionString);

            string query = @"select found=1 from Account 
                               where AccountNumber=@AccountNumber;";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AccountNumber",AccountNumber);
           

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;

                reader.Close();
            }
            catch (Exception ex)
            {
               
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }
        public static int GetAccountState(int AccountID)
        {
            int AccountState = 0;

            SqlConnection Connection = new SqlConnection(clsDataAccess.ConnectionString);

            string Query = "select AccountState from Account where AccountID=@AccountID;";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@AccountID", AccountID);

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {

                    if (Reader["AccountState"] == DBNull.Value)
                        AccountState = -1;
                    else AccountState = (int)Reader["AccountState"];



                    Reader.Close();
                }
            }
            catch (Exception ex)
            {
                
            }
            finally
            {
                Connection.Close();
            }

            return AccountState;
        }
        public static DataTable GetDataAboutInterest()
        {
            
            string Qury = @"select Account.AccountID,Account.LastInterestDate,AccountType.AccountTypeID,
Application.ApplicationDate
,AccountType.InterestPeriod,AccountType.InterestRate 
from Account inner join Application on Account.ApplicationID = Application.ApplicationID
inner join AccountType on Account.AccountTypeID = AccountType.AccountTypeID";

            
            DataTable _dt = new DataTable();

            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccess.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand(Qury, Connection))
                    using (SqlDataReader Reader = Command.ExecuteReader())
                    {

                        if (Reader.HasRows)
                        {
                           
                                _dt.Load(Reader);
                            
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
            return _dt;
        }
    }
    }


