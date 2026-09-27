using Bank_DataAccess;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Data_Access_Layer
{
    public class clsApplicationTypeData
    {
        public static int AddNewApplicationType(string Description, decimal Fees)
        {
            SqlConnection connection = new SqlConnection(clsDataAccess.ConnectionString);

            string query = "INSERT INTO ApplicationType (Description, Fees) " +
                           "VALUES (@Description, @Fees);" +
                           "SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Description", Description);
            command.Parameters.AddWithValue("@Fees", Fees);

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

        public static DataTable GetAllApplicationType()
        {
            SqlConnection Connection = new SqlConnection(clsDataAccess.ConnectionString);

            string Query = "SELECT ApplicationTypeId,Description,Fees FROM ApplicationType";

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

        public static bool UpdateApplicationType(int ApplicationTypeId, string Description, decimal Fees)
        {
            int RowAffected = -1;
            SqlConnection Connection = new SqlConnection(clsDataAccess.ConnectionString);
            string Query = @"UPDATE ApplicationType 
                             SET Description=@Description, Fees=@Fees
                             WHERE ApplicationTypeId=@ApplicationTypeId";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ApplicationTypeId", ApplicationTypeId);
            Command.Parameters.AddWithValue("@Description", Description);
            Command.Parameters.AddWithValue("@Fees", Fees);

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

        public static bool DeleteApplicationType(int ApplicationTypeId)
        {
            int RowsAffected = -1;
            SqlConnection Connection = new SqlConnection(clsDataAccess.ConnectionString);
            string Query = "DELETE FROM ApplicationType WHERE ApplicationTypeId=@ApplicationTypeId";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ApplicationTypeId", ApplicationTypeId);

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

        public static bool FindApplicationTypeByApplicationTypeId(byte ApplicationTypeID, ref string Description, ref decimal Fees)
        {
            bool Found = false;

            SqlConnection Connection = new SqlConnection(clsDataAccess.ConnectionString);

            string Query = "SELECT * FROM ApplicationType WHERE ApplicationTypeID=@ApplicationTypeID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    Found = true;

                    if (Reader["Description"] == DBNull.Value) Description = default;
                    else Description = (string)Reader["Description"];

                    if (Reader["Fees"] == DBNull.Value) Fees = default;
                    else Fees = (decimal)Reader["Fees"];

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