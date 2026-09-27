using Bank_DataAccess;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Data_Access_Layer
{
    public class clsExternalTransferData
    {
        public static int AddNewExternalTransfer(int IBAN, string BankName, int RecipientAccountID, int TransactionID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccess.ConnectionString);

            string query = "INSERT INTO ExternalTransfer (IBAN, BankName, RecipientAccountID, TransactionID) " +
                           "VALUES (@IBAN, @BankName, @RecipientAccountID, @TransactionID);" +
                           "SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@IBAN", IBAN);
            command.Parameters.AddWithValue("@BankName", BankName);
            command.Parameters.AddWithValue("@RecipientAccountID", RecipientAccountID);
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

        public static DataTable GetAllExternalTransfer()
        {
            SqlConnection Connection = new SqlConnection(clsDataAccess.ConnectionString);

            string Query = "SELECT ID, IBAN, BankName, RecipientAccountID, TransactionID FROM ExternalTransfer";

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

        public static bool UpdateExternalTransfer(int ID, int IBAN, string BankName, int RecipientAccountID, int TransactionID)
        {
            int RowAffected = -1;
            SqlConnection Connection = new SqlConnection(clsDataAccess.ConnectionString);
            string Query = @"UPDATE ExternalTransfer 
                             SET IBAN=@IBAN, BankName=@BankName, RecipientAccountID=@RecipientAccountID, TransactionID=@TransactionID
                             WHERE ID=@ID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ID", ID);
            Command.Parameters.AddWithValue("@IBAN", IBAN);
            Command.Parameters.AddWithValue("@BankName", BankName);
            Command.Parameters.AddWithValue("@RecipientAccountID", RecipientAccountID);
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

        public static bool DeleteExternalTransfer(int ID)
        {
            int RowsAffected = -1;
            SqlConnection Connection = new SqlConnection(clsDataAccess.ConnectionString);
            string Query = "DELETE FROM ExternalTransfer WHERE ID=@ID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ID", ID);

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

        public static bool FindExternalTransferByID(int ID, ref int IBAN, ref string BankName, ref int RecipientAccountID, ref int TransactionID)
        {
            bool Found = false;

            SqlConnection Connection = new SqlConnection(clsDataAccess.ConnectionString);

            string Query = "SELECT * FROM ExternalTransfer WHERE ID=@ID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ID", ID);

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    Found = true;

                    if (Reader["IBAN"] == DBNull.Value) IBAN = default;
                    else IBAN = (int)Reader["IBAN"];

                    if (Reader["BankName"] == DBNull.Value) BankName = default;
                    else BankName = (string)Reader["BankName"];

                    if (Reader["RecipientAccountID"] == DBNull.Value) RecipientAccountID = default;
                    else RecipientAccountID = (int)Reader["RecipientAccountID"];

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

        public static int GetExternalTransferCountForAccount(int AccountID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccess.ConnectionString);
            string Query = @"SELECT COUNT(T.TransactionID)
                             FROM [Transaction] T 
                             INNER JOIN ExternalTransfer E ON T.TransactionID = E.TransactionID
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