using Bank_DataAccess;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Data_Access_Layer
{
    public class clsDepositTransactionData
    {
        public static int AddNewDepositTransaction(int TransactionID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccess.ConnectionString);

            string query = "INSERT INTO DepositTransaction (TransactionID) " +
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
            }
            finally
            {
                connection.Close();
            }

            return insertedID;
        }

        public static DataTable GetAllDepositTransaction()
        {
            SqlConnection Connection = new SqlConnection(clsDataAccess.ConnectionString);

            string Query = "SELECT DTransactionID, TransactionID FROM DepositTransaction";

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

        public static bool UpdateDepositTransaction(int DTransactionID, int TransactionID)
        {
            int RowAffected = -1;
            SqlConnection Connection = new SqlConnection(clsDataAccess.ConnectionString);
            string Query = @"UPDATE DepositTransaction 
                             SET TransactionID=@TransactionID
                             WHERE DTransactionID=@DTransactionID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@DTransactionID", DTransactionID);
            Command.Parameters.AddWithValue("@TransactionID", TransactionID);

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

        public static bool DeleteDepositTransaction(int DTransactionID)
        {
            int RowsAffected = -1;
            SqlConnection Connection = new SqlConnection(clsDataAccess.ConnectionString);
            string Query = "DELETE FROM DepositTransaction WHERE DTransactionID=@DTransactionID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@DTransactionID", DTransactionID);

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

        public static bool FindDepositTransactionByDTransactionID(int DTransactionID, ref int TransactionID)
        {
            bool Found = false;

            SqlConnection Connection = new SqlConnection(clsDataAccess.ConnectionString);

            string Query = "SELECT * FROM DepositTransaction WHERE DTransactionID=@DTransactionID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@DTransactionID", DTransactionID);

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

        public static int GetDepositsCountForAccount(int AccountID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccess.ConnectionString);
            string Query = @"SELECT COUNT(T.TransactionID)
                             FROM [Transaction] T 
                             INNER JOIN DepositTransaction D ON T.TransactionID = D.TransactionID
                             INNER JOIN Account A ON T.AccountID = A.AccountID
                             WHERE YEAR(T.TransactionDate) = YEAR(GETDATE()) 
                             AND MONTH(T.TransactionDate) = MONTH(GETDATE())
                             AND DAY(T.TransactionDate) = DAY(GETDATE()) 
                             AND A.AccountID = @AccountID";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@AccountID", AccountID);

            int count = 0;

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int id))
                {
                    count = id;
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }

            return count;
        }
    }
}