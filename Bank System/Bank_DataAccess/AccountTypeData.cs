using Bank_DataAccess;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Data_Access_Layer
{
    public class clsAccountTypeData
    {
        


public static int AddNewAccountType(string Name, string Description, decimal MinBalance, decimal InterestRate, byte InterestPeriod, decimal MaxDailyWithDrawAmount, int NumberDailyWithDrawals)
{
    SqlConnection connection = new SqlConnection(clsDataAccess.ConnectionString);

    string query = "INSERT INTO AccountType (Name, Description, MinBalance, InterestRate, InterestPeriod, MaxDailyWithDrawAmount, NumberDailyWithDrawals) " +
                   "VALUES (@Name, @Description, @MinBalance, @InterestRate, @InterestPeriod, @MaxDailyWithDrawAmount, @NumberDailyWithDrawals);" +
                   "SELECT SCOPE_IDENTITY();";

    SqlCommand command = new SqlCommand(query, connection);
    command.Parameters.AddWithValue("@Name", Name);
    command.Parameters.AddWithValue("@Description", Description);
    command.Parameters.AddWithValue("@MinBalance", MinBalance);
    command.Parameters.AddWithValue("@InterestRate", InterestRate);
    command.Parameters.AddWithValue("@InterestPeriod", InterestPeriod);
    command.Parameters.AddWithValue("@MaxDailyWithDrawAmount", MaxDailyWithDrawAmount);
    command.Parameters.AddWithValue("@NumberDailyWithDrawals", NumberDailyWithDrawals);

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

      public static DataTable GetAllAccountType()
        {
            SqlConnection Connection = new SqlConnection(clsDataAccess.ConnectionString);

            string Query = "SELECT AccountTypeID,Name,Description,MinBalance,InterestRate,InterestPeriod,MaxDailyWithDrawAmount,NumberDailyWithDrawals FROM AccountType";

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
        public static DataTable GetAccountNames()
        {
            SqlConnection Connection = new SqlConnection(clsDataAccess.ConnectionString);

            string Query = "SELECT Name FROM AccountType";

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



        public static bool UpdateAccountType(byte AccountTypeID, string Name, string Description, decimal MinBalance, decimal InterestRate, byte InterestPeriod, decimal MaxDailyWithDrawAmount, int NumberDailyWithDrawals) 
{
    int RowAffected = -1;
    SqlConnection Connection = new SqlConnection(clsDataAccess.ConnectionString);
    string Query = @"Update AccountType 
                      set Name=@Name,Description=@Description,MinBalance=@MinBalance,InterestRate=@InterestRate,InterestPeriod=@InterestPeriod,MaxDailyWithDrawAmount=@MaxDailyWithDrawAmount,NumberDailyWithDrawals=@NumberDailyWithDrawals
                       where AccountTypeID=@AccountTypeID";
    SqlCommand Command = new SqlCommand(Query, Connection);
    Command.Parameters.AddWithValue("@AccountTypeID", AccountTypeID);
    Command.Parameters.AddWithValue("@Name", Name);
    Command.Parameters.AddWithValue("@Description", Description);
    Command.Parameters.AddWithValue("@MinBalance", MinBalance);
    Command.Parameters.AddWithValue("@InterestRate", InterestRate);
    Command.Parameters.AddWithValue("@InterestPeriod", InterestPeriod);
    Command.Parameters.AddWithValue("@MaxDailyWithDrawAmount", MaxDailyWithDrawAmount);
    Command.Parameters.AddWithValue("@NumberDailyWithDrawals", NumberDailyWithDrawals);

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

public static bool DeleteAccountType ( byte  AccountTypeID ) 
 { 
    int RowsAffected = -1;
    SqlConnection Connection = new SqlConnection(clsDataAccess.ConnectionString);
    string Query = " Delete From AccountType Where AccountTypeID=@AccountTypeID";
    SqlCommand Command = new SqlCommand(Query, Connection);
    Command.Parameters.AddWithValue("@AccountTypeID", AccountTypeID);
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
      

            public static bool FindAccountTypeByAccountTypeID(byte AccountTypeID, ref string Name, ref string Description, ref decimal MinBalance, ref decimal InterestRate, ref byte InterestPeriod, ref decimal MaxDailyWithDrawAmount, ref int NumberDailyWithDrawals)
            {
                bool Found = false;
            
                SqlConnection Connection = new SqlConnection(clsDataAccess.ConnectionString);
            
                string Query = "SELECT * FROM AccountType WHERE AccountTypeID=@AccountTypeID";
            
                SqlCommand Command = new SqlCommand(Query, Connection);
                Command.Parameters.AddWithValue("@AccountTypeID", AccountTypeID);
            
                try
                {
                    Connection.Open();
            
                    SqlDataReader Reader = Command.ExecuteReader();
            
                    if (Reader.Read())
                    {
                        Found = true;
            
                         

                if (Reader["Name"] == DBNull.Value) Name = default;
                  else Name = (string)Reader["Name"];

                if (Reader["Description"] == DBNull.Value) Description = default;
                  else Description = (string)Reader["Description"];

                if (Reader["MinBalance"] == DBNull.Value) MinBalance = default;
                  else MinBalance = (decimal)Reader["MinBalance"];

                if (Reader["InterestRate"] == DBNull.Value) InterestRate = default;
                  else InterestRate = (decimal)Reader["InterestRate"];

                if (Reader["InterestPeriod"] == DBNull.Value) 
                        InterestPeriod = default;
                  else InterestPeriod = Convert.ToByte(Reader["InterestPeriod"]);

                if (Reader["MaxDailyWithDrawAmount"] == DBNull.Value) MaxDailyWithDrawAmount = default;
                  else MaxDailyWithDrawAmount = (decimal)Reader["MaxDailyWithDrawAmount"];

                if (Reader["NumberDailyWithDrawals"] == DBNull.Value) NumberDailyWithDrawals = default;
                  else NumberDailyWithDrawals = (int)Reader["NumberDailyWithDrawals"];
            
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
            }}}


