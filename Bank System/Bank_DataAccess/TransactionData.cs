using Bank_DataAccess;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Data_Access_Layer
{
    public class clsTransactionData
    {
        public static int AddNewTransaction(string TransactionName, int AccountID, decimal Amount, DateTime TransactionDate, int ApplicationID, int UserID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccess.ConnectionString);

            string query = "INSERT INTO [Transaction] (TransactionName, AccountID, Amount, TransactionDate, ApplicationID, UserID) " +
                           "VALUES (@TransactionName, @AccountID, @Amount, @TransactionDate, @ApplicationID, @UserID);" +
                           "SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TransactionName", TransactionName);
            command.Parameters.AddWithValue("@AccountID", AccountID);
            command.Parameters.AddWithValue("@Amount", Amount);
            command.Parameters.AddWithValue("@TransactionDate", TransactionDate);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@UserID", UserID);

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

        public static DataTable GetAllTransaction()
        {
            SqlConnection Connection = new SqlConnection(clsDataAccess.ConnectionString);

            string Query = "SELECT TransactionID,TransactionName,AccountID,Amount,TransactionDate,ApplicationID,UserID FROM [Transaction]";

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

        public static bool UpdateTransaction(int TransactionID, string TransactionName, int AccountID, decimal Amount, DateTime TransactionDate, int ApplicationID, int UserID)
        {
            int RowAffected = -1;
            SqlConnection Connection = new SqlConnection(clsDataAccess.ConnectionString);
            string Query = @"UPDATE [Transaction] 
                             SET TransactionName=@TransactionName, AccountID=@AccountID, Amount=@Amount, TransactionDate=@TransactionDate, ApplicationID=@ApplicationID, UserID=@UserID
                             WHERE TransactionID=@TransactionID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@TransactionID", TransactionID);
            Command.Parameters.AddWithValue("@TransactionName", TransactionName);
            Command.Parameters.AddWithValue("@AccountID", AccountID);
            Command.Parameters.AddWithValue("@Amount", Amount);
            Command.Parameters.AddWithValue("@TransactionDate", TransactionDate);
            Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            Command.Parameters.AddWithValue("@UserID", UserID);

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

        public static bool DeleteTransaction(int TransactionID)
        {
            int RowsAffected = -1;
            SqlConnection Connection = new SqlConnection(clsDataAccess.ConnectionString);
            string Query = "DELETE FROM [Transaction] WHERE TransactionID=@TransactionID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@TransactionID", TransactionID);

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

        public static bool FindTransactionByTransactionID(int TransactionID, ref string TransactionName, ref int AccountID, ref decimal Amount, ref DateTime TransactionDate, ref int ApplicationID, ref int UserID)
        {
            bool Found = false;

            SqlConnection Connection = new SqlConnection(clsDataAccess.ConnectionString);

            string Query = "SELECT * FROM [Transaction] WHERE TransactionID=@TransactionID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@TransactionID", TransactionID);

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    Found = true;

                    if (Reader["TransactionName"] == DBNull.Value) TransactionName = default;
                    else TransactionName = (string)Reader["TransactionName"];

                    if (Reader["AccountID"] == DBNull.Value) AccountID = default;
                    else AccountID = (int)Reader["AccountID"];

                    if (Reader["Amount"] == DBNull.Value) Amount = default;
                    else Amount = (decimal)Reader["Amount"];

                    if (Reader["TransactionDate"] == DBNull.Value) TransactionDate = default;
                    else TransactionDate = (DateTime)Reader["TransactionDate"];

                    if (Reader["ApplicationID"] == DBNull.Value) ApplicationID = default;
                    else ApplicationID = (int)Reader["ApplicationID"];

                    if (Reader["UserID"] == DBNull.Value) UserID = default;
                    else UserID = (int)Reader["UserID"];

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

        public static bool FindTransactionByAccountID(ref int TransactionID, ref string TransactionName, int AccountID, ref decimal Amount, ref DateTime TransactionDate, ref int ApplicationID, ref int UserID)
        {
            bool Found = false;

            SqlConnection Connection = new SqlConnection(clsDataAccess.ConnectionString);

            string Query = "SELECT * FROM [Transaction] WHERE AccountID=@AccountID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@AccountID", AccountID);

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    Found = true;

                    if (Reader["TransactionID"] == DBNull.Value) TransactionID = default;
                    else TransactionID = (int)Reader["TransactionID"];

                    if (Reader["TransactionName"] == DBNull.Value) TransactionName = default;
                    else TransactionName = (string)Reader["TransactionName"];

                    if (Reader["Amount"] == DBNull.Value) Amount = default;
                    else Amount = (decimal)Reader["Amount"];

                    if (Reader["TransactionDate"] == DBNull.Value) TransactionDate = default;
                    else TransactionDate = (DateTime)Reader["TransactionDate"];

                    if (Reader["ApplicationID"] == DBNull.Value) ApplicationID = default;
                    else ApplicationID = (int)Reader["ApplicationID"];

                    if (Reader["UserID"] == DBNull.Value) UserID = default;
                    else UserID = (int)Reader["UserID"];

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

        public static bool FindTransactionByApplicationID(ref int TransactionID, ref string TransactionName, ref int AccountID, ref decimal Amount, ref DateTime TransactionDate, int ApplicationID, ref int UserID)
        {
            bool Found = false;

            SqlConnection Connection = new SqlConnection(clsDataAccess.ConnectionString);

            string Query = "SELECT * FROM [Transaction] WHERE ApplicationID=@ApplicationID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    Found = true;

                    if (Reader["TransactionID"] == DBNull.Value) TransactionID = default;
                    else TransactionID = (int)Reader["TransactionID"];

                    if (Reader["TransactionName"] == DBNull.Value) TransactionName = default;
                    else TransactionName = (string)Reader["TransactionName"];

                    if (Reader["AccountID"] == DBNull.Value) AccountID = default;
                    else AccountID = (int)Reader["AccountID"];

                    if (Reader["Amount"] == DBNull.Value) Amount = default;
                    else Amount = (decimal)Reader["Amount"];

                    if (Reader["TransactionDate"] == DBNull.Value) TransactionDate = default;
                    else TransactionDate = (DateTime)Reader["TransactionDate"];

                    if (Reader["UserID"] == DBNull.Value) UserID = default;
                    else UserID = (int)Reader["UserID"];

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
    }
}