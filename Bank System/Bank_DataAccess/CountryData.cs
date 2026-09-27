using Bank_DataAccess;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Data_Access_Layer
{
    public class clsCountryData
    {
        public static int AddNewCountry(string CountryName, string DialingCode)
        {
            SqlConnection connection = new SqlConnection(clsDataAccess.ConnectionString);

            string query = "INSERT INTO Country (CountryName, DialingCode) " +
                           "VALUES (@CountryName, @DialingCode);" +
                           "SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CountryName", CountryName);
            command.Parameters.AddWithValue("@DialingCode", DialingCode);

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

        public static DataTable GetAllCountry()
        {
            SqlConnection Connection = new SqlConnection(clsDataAccess.ConnectionString);

            string Query = "SELECT CountryID, CountryName, DialingCode FROM Country";

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

        public static bool UpdateCountry(int CountryID, string CountryName, string DialingCode)
        {
            int RowAffected = -1;
            SqlConnection Connection = new SqlConnection(clsDataAccess.ConnectionString);
            string Query = @"UPDATE Country 
                             SET CountryName=@CountryName, DialingCode=@DialingCode
                             WHERE CountryID=@CountryID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@CountryID", CountryID);
            Command.Parameters.AddWithValue("@CountryName", CountryName);
            Command.Parameters.AddWithValue("@DialingCode", DialingCode);

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

        public static bool DeleteCountry(int CountryID)
        {
            int RowsAffected = -1;
            SqlConnection Connection = new SqlConnection(clsDataAccess.ConnectionString);
            string Query = "DELETE FROM Country WHERE CountryID=@CountryID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@CountryID", CountryID);

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

        public static bool FindCountryByCountryID(int CountryID, ref string CountryName, ref string DialingCode)
        {
            bool Found = false;

            SqlConnection Connection = new SqlConnection(clsDataAccess.ConnectionString);

            string Query = "SELECT * FROM Country WHERE CountryID=@CountryID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@CountryID", CountryID);

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    Found = true;

                    if (Reader["CountryName"] == DBNull.Value) CountryName = default;
                    else CountryName = (string)Reader["CountryName"];

                    if (Reader["DialingCode"] == DBNull.Value) DialingCode = default;
                    else DialingCode = (string)Reader["DialingCode"];

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

        public static bool FindCountryByCountryName(ref int CountryID, string CountryName, ref string DialingCode)
        {
            bool Found = false;

            SqlConnection Connection = new SqlConnection(clsDataAccess.ConnectionString);

            string Query = "SELECT * FROM Country WHERE CountryName=@CountryName";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@CountryName", CountryName);

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    Found = true;

                    if (Reader["CountryID"] == DBNull.Value) CountryID = default;
                    else CountryID = (int)Reader["CountryID"];

                    if (Reader["DialingCode"] == DBNull.Value) DialingCode = default;
                    else DialingCode = (string)Reader["DialingCode"];

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