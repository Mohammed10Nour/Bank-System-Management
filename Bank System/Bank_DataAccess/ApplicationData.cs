using Bank_DataAccess;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;

namespace Data_Access_Layer
{
    public class clsApplicationData
    {
        public static int AddNewApplication(int ClientID, int ApplicationTypeID, byte ApplicationStatus, DateTime ApplicationDate, decimal PaidFees, int UserID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccess.ConnectionString);

            string query = "INSERT INTO Application (ClientID, ApplicationTypeID, ApplicationStatus, ApplicationDate, PaidFees, UserID) " +
                           "VALUES (@ClientID, @ApplicationTypeID, @ApplicationStatus, @ApplicationDate, @PaidFees, @UserID);" +
                           "SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ClientID", ClientID);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
            command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
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

        public static DataTable GetAllApplication()
        {
            SqlConnection Connection = new SqlConnection(clsDataAccess.ConnectionString);

            string Query = "SELECT ApplicationID,ClientID,ApplicationTypeID,ApplicationStatus,ApplicationDate,PaidFees,UserID FROM Application";

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

        public static bool UpdateApplication(int ApplicationID, int ClientID, int ApplicationTypeID, int ApplicationStatus, DateTime ApplicationDate, decimal PaidFees, int UserID)
        {
            int RowAffected = -1;
            SqlConnection Connection = new SqlConnection(clsDataAccess.ConnectionString);
            string Query = @"UPDATE Application 
                             SET ClientID=@ClientID, ApplicationTypeID=@ApplicationTypeID, ApplicationStatus=@ApplicationStatus, ApplicationDate=@ApplicationDate, PaidFees=@PaidFees, UserID=@UserID
                             WHERE ApplicationID=@ApplicationID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            Command.Parameters.AddWithValue("@ClientID", ClientID);
            Command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            Command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
            Command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
            Command.Parameters.AddWithValue("@PaidFees", PaidFees);
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

        public static bool DeleteApplication(int ApplicationID)
        {
            int RowsAffected = -1;
            SqlConnection Connection = new SqlConnection(clsDataAccess.ConnectionString);
            string Query = "DELETE FROM Application WHERE ApplicationID=@ApplicationID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

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

        public static bool FindApplicationByApplicationID(int ApplicationID, ref int ClientID, ref int ApplicationTypeID, ref int ApplicationStatus, ref DateTime ApplicationDate, ref decimal PaidFees, ref int UserID)
        {
            bool Found = false;

            SqlConnection Connection = new SqlConnection(clsDataAccess.ConnectionString);

            string Query = "SELECT * FROM Application WHERE ApplicationID=@ApplicationID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    Found = true;

                    if (Reader["ClientID"] == DBNull.Value) ClientID = default;
                    else ClientID = (int)Reader["ClientID"];

                    if (Reader["ApplicationTypeID"] == DBNull.Value) ApplicationTypeID = default;
                    else ApplicationTypeID = (int)Reader["ApplicationTypeID"];

                    if (Reader["ApplicationStatus"] == DBNull.Value) ApplicationStatus = default;
                    else ApplicationStatus = (int)Reader["ApplicationStatus"];

                    if (Reader["ApplicationDate"] == DBNull.Value) ApplicationDate = default;
                    else ApplicationDate = (DateTime)Reader["ApplicationDate"];

                    if (Reader["PaidFees"] == DBNull.Value) PaidFees = default;
                    else PaidFees = (decimal)Reader["PaidFees"];

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

        public static bool FindApplicationByApplicationTypeID(ref int ApplicationID, ref int ClientID, int ApplicationTypeID, ref int ApplicationStatus, ref DateTime ApplicationDate, ref decimal PaidFees, ref int UserID)
        {
            bool Found = false;

            SqlConnection Connection = new SqlConnection(clsDataAccess.ConnectionString);

            string Query = "SELECT * FROM Application WHERE ApplicationTypeID=@ApplicationTypeID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    Found = true;

                    if (Reader["ApplicationID"] == DBNull.Value) ApplicationID = default;
                    else ApplicationID = (int)Reader["ApplicationID"];

                    if (Reader["ClientID"] == DBNull.Value) ClientID = default;
                    else ClientID = (int)Reader["ClientID"];

                    if (Reader["ApplicationStatus"] == DBNull.Value) ApplicationStatus = default;
                    else ApplicationStatus = (int)Reader["ApplicationStatus"];

                    if (Reader["ApplicationDate"] == DBNull.Value) ApplicationDate = default;
                    else ApplicationDate = (DateTime)Reader["ApplicationDate"];

                    if (Reader["PaidFees"] == DBNull.Value) PaidFees = default;
                    else PaidFees = (decimal)Reader["PaidFees"];

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

        public static bool FindApplicationByClientID(ref int ApplicationID, int ClientID, ref int ApplicationTypeID, ref int ApplicationStatus, ref DateTime ApplicationDate, ref decimal PaidFees, ref int UserID)
        {
            bool Found = false;

            SqlConnection Connection = new SqlConnection(clsDataAccess.ConnectionString);

            string Query = "SELECT * FROM Application WHERE ClientID=@ClientID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ClientID", ClientID);

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    Found = true;

                    if (Reader["ApplicationID"] == DBNull.Value) ApplicationID = default;
                    else ApplicationID = (int)Reader["ApplicationID"];

                    if (Reader["ApplicationTypeID"] == DBNull.Value) ApplicationTypeID = default;
                    else ApplicationTypeID = (int)Reader["ApplicationTypeID"];

                    if (Reader["ApplicationStatus"] == DBNull.Value) ApplicationStatus = default;
                    else ApplicationStatus = (int)Reader["ApplicationStatus"];

                    if (Reader["ApplicationDate"] == DBNull.Value) ApplicationDate = default;
                    else ApplicationDate = (DateTime)Reader["ApplicationDate"];

                    if (Reader["PaidFees"] == DBNull.Value) PaidFees = default;
                    else PaidFees = (decimal)Reader["PaidFees"];

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

        public static bool FindApplicationByUserID(ref int ApplicationID, ref int ClientID, ref int ApplicationTypeID, ref int ApplicationStatus, ref DateTime ApplicationDate, ref decimal PaidFees, int UserID)
        {
            bool Found = false;

            SqlConnection Connection = new SqlConnection(clsDataAccess.ConnectionString);

            string Query = "SELECT * FROM Application WHERE UserID=@UserID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    Found = true;

                    if (Reader["ApplicationID"] == DBNull.Value) ApplicationID = default;
                    else ApplicationID = (int)Reader["ApplicationID"];

                    if (Reader["ClientID"] == DBNull.Value) ClientID = default;
                    else ClientID = (int)Reader["ClientID"];

                    if (Reader["ApplicationTypeID"] == DBNull.Value) ApplicationTypeID = default;
                    else ApplicationTypeID = (int)Reader["ApplicationTypeID"];

                    if (Reader["ApplicationStatus"] == DBNull.Value) ApplicationStatus = default;
                    else ApplicationStatus = (int)Reader["ApplicationStatus"];

                    if (Reader["ApplicationDate"] == DBNull.Value) ApplicationDate = default;
                    else ApplicationDate = (DateTime)Reader["ApplicationDate"];

                    if (Reader["PaidFees"] == DBNull.Value) PaidFees = default;
                    else PaidFees = (decimal)Reader["PaidFees"];

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

        public static void SetComplete(int ApplicationID, int ApplicationStatus)
        {
            int RowAffected = -1;
            SqlConnection Connection = new SqlConnection(clsDataAccess.ConnectionString);

            string Query = @"UPDATE Application 
                             SET ApplicationStatus=@ApplicationStatus
                             WHERE ApplicationID=@ApplicationID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            Command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);

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
        }
    }
}