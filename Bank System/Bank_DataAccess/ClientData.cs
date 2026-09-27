using Bank_DataAccess;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Data_Access_Layer
{
    public class clsClientData
    {
        public static int AddNewClient(string NationalNo, string FullName, DateTime DateOfBirth, string Address, bool Gender, int NationalityID, int ContactInfoID, string ImagePath)
        {
            SqlConnection connection = new SqlConnection(clsDataAccess.ConnectionString);

            string query = "INSERT INTO Client (NationalNo, FullName, DateOfBirth, Address, Gender, NationalityID, ContactInfoID,ImagePath) " +
                           "VALUES (@NationalNo, @FullName, @DateOfBirth, @Address, @Gender, @NationalityID, @ContactInfoID,@ImagePath);" +
                           "SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            command.Parameters.AddWithValue("@FullName", FullName);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Gender", Gender);
            command.Parameters.AddWithValue("@NationalityID", NationalityID);
            command.Parameters.AddWithValue("@ContactInfoID", ContactInfoID);

            if (string.IsNullOrEmpty(ImagePath))
                command.Parameters.AddWithValue("@ImagePath", DBNull.Value);
            else
                command.Parameters.AddWithValue("@ImagePath", ImagePath);

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
                // Handle exception
            }
            finally
            {
                connection.Close();
            }

            return insertedID;
        }

        public static DataTable GetAllClient()
        {
            SqlConnection Connection = new SqlConnection(clsDataAccess.ConnectionString);

            string Query = @"SELECT Client.ClientID, Client.NationalNo, Client.FullName, Client.DateOfBirth,
                            GenderCaption = CASE
                                WHEN Gender = 0 THEN 'Male'
                                WHEN Gender = 1 THEN 'Female'
                            END,
                            Country.CountryName 
                            FROM Client 
                            INNER JOIN Country ON Client.NationalityID = Country.CountryID;";

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
                // Handle exception
            }
            finally
            {
                Connection.Close();
            }

            return DT;
        }

        public static bool UpdateClient(int ClientID, string NationalNo, string FullName, DateTime DateOfBirth, string Address, bool Gender, int NationalityID, int ContactInfoID, string ImagePath)
        {
            int RowAffected = -1;
            SqlConnection Connection = new SqlConnection(clsDataAccess.ConnectionString);

            string Query = @"UPDATE Client 
                            SET NationalNo=@NationalNo, FullName=@FullName, DateOfBirth=@DateOfBirth, Address=@Address, Gender=@Gender, NationalityID=@NationalityID, ContactInfoID=@ContactInfoID, ImagePath=@ImagePath
                            WHERE ClientID=@ClientID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ClientID", ClientID);
            Command.Parameters.AddWithValue("@NationalNo", NationalNo);
            Command.Parameters.AddWithValue("@FullName", FullName);
            Command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            Command.Parameters.AddWithValue("@Address", Address);
            Command.Parameters.AddWithValue("@Gender", Gender);
            Command.Parameters.AddWithValue("@NationalityID", NationalityID);
            Command.Parameters.AddWithValue("@ContactInfoID", ContactInfoID);

            if (string.IsNullOrEmpty(ImagePath))
                Command.Parameters.AddWithValue("@ImagePath", DBNull.Value);
            else
                Command.Parameters.AddWithValue("@ImagePath", ImagePath);

            try
            {
                Connection.Open();
                RowAffected = Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Handle exception
            }
            finally
            {
                Connection.Close();
            }

            return RowAffected > 0;
        }

        public static bool DeleteClient(int ClientID)
        {
            int RowsAffected = -1;
            SqlConnection Connection = new SqlConnection(clsDataAccess.ConnectionString);
            string Query = "DELETE FROM Client WHERE ClientID=@ClientID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ClientID", ClientID);

            try
            {
                Connection.Open();
                RowsAffected = Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Handle exception
            }
            finally
            {
                Connection.Close();
            }

            return RowsAffected > 0;
        }

        public static bool FindClientByClientID(int ClientID, ref string NationalNo, ref string FullName, ref DateTime DateOfBirth, ref string Address, ref bool Gender, ref int NationalityID, ref int ContactInfoID, ref string ImagePath)
        {
            bool Found = false;
            SqlConnection Connection = new SqlConnection(clsDataAccess.ConnectionString);
            string Query = "SELECT * FROM Client WHERE ClientID=@ClientID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ClientID", ClientID);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    Found = true;

                    NationalNo = Reader["NationalNo"] == DBNull.Value ? string.Empty : (string)Reader["NationalNo"];
                    FullName = Reader["FullName"] == DBNull.Value ? string.Empty : (string)Reader["FullName"];
                    DateOfBirth = Reader["DateOfBirth"] == DBNull.Value ? DateTime.MinValue : (DateTime)Reader["DateOfBirth"];
                    Address = Reader["Address"] == DBNull.Value ? string.Empty : (string)Reader["Address"];
                    Gender = Reader["Gender"] != DBNull.Value && (bool)Reader["Gender"];
                    NationalityID = Reader["NationalityID"] == DBNull.Value ? -1 : (int)Reader["NationalityID"];
                    ContactInfoID = Reader["ContactInfoID"] == DBNull.Value ? -1 : (int)Reader["ContactInfoID"];
                    ImagePath = Reader["ImagePath"] == DBNull.Value ? string.Empty : (string)Reader["ImagePath"];
                }
                Reader.Close();
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

        public static bool FindClientByNationalNo(ref int ClientID, string NationalNo, ref string FullName, ref DateTime DateOfBirth, ref string Address, ref bool Gender, ref int NationalityID, ref int ContactInfoID, ref string ImagePath)
        {
            bool Found = false;
            SqlConnection Connection = new SqlConnection(clsDataAccess.ConnectionString);
            string Query = "SELECT * FROM Client WHERE NationalNo=@NationalNo";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@NationalNo", NationalNo);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    Found = true;

                    ClientID = Reader["ClientID"] == DBNull.Value ? -1 : (int)Reader["ClientID"];
                    FullName = Reader["FullName"] == DBNull.Value ? string.Empty : (string)Reader["FullName"];
                    DateOfBirth = Reader["DateOfBirth"] == DBNull.Value ? DateTime.MinValue : (DateTime)Reader["DateOfBirth"];
                    Address = Reader["Address"] == DBNull.Value ? string.Empty : (string)Reader["Address"];
                    Gender = Reader["Gender"] != DBNull.Value && (bool)Reader["Gender"];
                    NationalityID = Reader["NationalityID"] == DBNull.Value ? -1 : (int)Reader["NationalityID"];
                    ContactInfoID = Reader["ContactInfoID"] == DBNull.Value ? -1 : (int)Reader["ContactInfoID"];
                    ImagePath = Reader["ImagePath"] == DBNull.Value ? string.Empty : (string)Reader["ImagePath"];
                }
                Reader.Close();
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

        public static bool IsClientExist(string NationalNo)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccess.ConnectionString);
            string query = "SELECT Found=1 FROM Client WHERE NationalNo = @NationalNo";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);

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
    }
}