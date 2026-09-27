using Bank_DataAccess;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Data_Access_Layer
{
    public class clsWithDrawalTransactionData
    {
        public static int AddNewWithDrawalTransaction(int TransactionID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccess.ConnectionString);

            string query = "INSERT INTO WithDrawalTransaction (TransactionID) " +
                           "VALUES (@TransactionID);" +
                           "SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TransactionID", TransactionID);

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
                // Handle error
            }
            finally
            {
                connection.Close();
            }

            return insertedID;
        }

        public static DataTable GetAllWithDrawalTransaction()
        {
            SqlConnection Connection = new SqlConnection(clsDataAccess.ConnectionString);

            string Query = "SELECT WTransactionID, TransactionID FROM WithDrawalTransaction";

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

        public static bool UpdateWithDrawalTransaction(int WTransactionID, int TransactionID)
        {
            int RowAffected = -1;
            SqlConnection Connection = new SqlConnection(clsDataAccess.ConnectionString);
            string Query = @"UPDATE WithDrawalTransaction 
                             SET TransactionID=@TransactionID
                             WHERE WTransactionID=@WTransactionID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@WTransactionID", WTransactionID);
            Command.Parameters.AddWithValue("@TransactionID", TransactionID);

            try
            {
                Connection.Open();
                RowAffected = Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Handle error
            }
            finally
            {
                Connection.Close();
            }

            return RowAffected > 0;
        }

        public static bool DeleteWithDrawalTransaction(int WTransactionID)
        {
            int RowsAffected = -1;
            SqlConnection Connection = new SqlConnection(clsDataAccess.ConnectionString);
            string Query = "DELETE FROM WithDrawalTransaction WHERE WTransactionID=@WTransactionID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@WTransactionID", WTransactionID);

            try
            {
                Connection.Open();
                RowsAffected = Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Handle error
            }
            finally
            {
                Connection.Close();
            }

            return RowsAffected > 0;
        }

        public static bool FindWithDrawalTransactionByWTransactionID(int WTransactionID, ref int TransactionID)
        {
            bool Found = false;

            SqlConnection Connection = new SqlConnection(clsDataAccess.ConnectionString);

            string Query = "SELECT * FROM WithDrawalTransaction WHERE WTransactionID=@WTransactionID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@WTransactionID", WTransactionID);

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    Found = true;

                    if (Reader["TransactionID"] == DBNull.Value) TransactionID = default;
                    else TransactionID = (int)Reader["TransactionID"];

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

        public static int GetWithdrawalCountForAccount(int AccountID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccess.ConnectionString);
            string Query = @"SELECT COUNT(T.TransactionID)
                             FROM [Transaction] T 
                             INNER JOIN WithDrawalTransaction W ON T.TransactionID = W.TransactionID
                             INNER JOIN Account A ON T.AccountID = A.AccountID
                             WHERE CAST(T.TransactionDate AS DATE) = CAST(GETDATE() AS DATE) 
                             AND A.AccountID = @AccountID";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@AccountID", AccountID);

            int count = 0;

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int parsedCount))
                {
                    count = parsedCount;
                }
            }
            catch (Exception ex)
            {
                // Handle error
            }
            finally
            {
                connection.Close();
            }

            return count;
        }

        public static decimal GetTotalWithdrawnToday(int AccountID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccess.ConnectionString);
            string Query = @"SELECT ISNULL(SUM(T.Amount), 0) 
                             FROM [Transaction] T 
                             INNER JOIN WithDrawalTransaction W ON T.TransactionID = W.TransactionID 
                             WHERE T.AccountID = @AccountID 
                             AND CAST(T.TransactionDate AS DATE) = CAST(GETDATE() AS DATE)";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@AccountID", AccountID);

            decimal sum = 0;

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && decimal.TryParse(result.ToString(), out decimal parsedSum))
                {
                    sum = parsedSum;
                }
            }
            catch (Exception ex)
            {
                // Handle error
            }
            finally
            {
                connection.Close();
            }

            return sum;
        }
    }
}