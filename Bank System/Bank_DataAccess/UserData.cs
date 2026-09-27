using Bank_DataAccess;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Data_Access_Layer
{
    public class clsUserData
    {
        public static int AddNewUser(int ClientID, string UserName, string Password, bool IsActive, int Permission)
        {
            SqlConnection connection = new SqlConnection(clsDataAccess.ConnectionString);

            string query = "INSERT INTO Users (ClientID, UserName, Password, IsActive, Permission) " +
                           "VALUES (@ClientID, @UserName, @Password, @IsActive, @Permission);" +
                           "SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ClientID", ClientID);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@Permission", Permission);

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
                // íãßä ÊÓÌíá ÇáÎØÃ åäÇ
            }
            finally
            {
                connection.Close();
            }

            return insertedID;
        }

        public static DataTable GetAllUsers()
        {
            SqlConnection Connection = new SqlConnection(clsDataAccess.ConnectionString);

            string Query = @"
SELECT 
    U.UserID,
    C.FullName, 
    U.UserName,
    U.IsActive,
    RoleName = 
    CASE U.Permission
        WHEN 7 THEN 'Admin User'
        ELSE 'Regular User'
    END 
FROM Users AS U
INNER JOIN Client AS C ON U.ClientID = C.ClientID;";

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

        public static bool UpdateUser(int UserID, int ClientID, string UserName, string Password, bool IsActive, int Permission)
        {
            int RowAffected = -1;
            SqlConnection Connection = new SqlConnection(clsDataAccess.ConnectionString);

            string Query = @"UPDATE Users 
                             SET ClientID=@ClientID, UserName=@UserName, Password=@Password, IsActive=@IsActive, Permission=@Permission
                             WHERE UserID=@UserID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@UserID", UserID);
            Command.Parameters.AddWithValue("@ClientID", ClientID);
            Command.Parameters.AddWithValue("@UserName", UserName);
            Command.Parameters.AddWithValue("@Password", Password);
            Command.Parameters.AddWithValue("@IsActive", IsActive);
            Command.Parameters.AddWithValue("@Permission", Permission);

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

        public static bool DeleteUser(int UserID)
        {
            int RowsAffected = -1;
            SqlConnection Connection = new SqlConnection(clsDataAccess.ConnectionString);

            string Query = "DELETE FROM Users WHERE UserID=@UserID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@UserID", UserID);

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

        public static bool FindUserByUserID(int UserID, ref int ClientID, ref string UserName, ref string Password, ref bool IsActive, ref int Permission)
        {
            bool Found = false;

            SqlConnection Connection = new SqlConnection(clsDataAccess.ConnectionString);

            string Query = "SELECT * FROM Users WHERE UserID=@UserID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    Found = true;

                    if (Reader["ClientID"] == DBNull.Value) ClientID = default;
                    else ClientID = (int)Reader["ClientID"];

                    if (Reader["UserName"] == DBNull.Value) UserName = default;
                    else UserName = (string)Reader["UserName"];

                    if (Reader["Password"] == DBNull.Value) Password = default;
                    else Password = (string)Reader["Password"];

                    if (Reader["IsActive"] == DBNull.Value) IsActive = default;
                    else IsActive = (bool)Reader["IsActive"];

                    if (Reader["Permission"] == DBNull.Value) Permission = default;
                    else Permission = (int)Reader["Permission"];

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

        public static bool FindUserByClientID(ref int UserID, int ClientID, ref string UserName, ref string Password, ref bool IsActive, ref int Permission)
        {
            bool Found = false;

            SqlConnection Connection = new SqlConnection(clsDataAccess.ConnectionString);

            string Query = "SELECT * FROM Users WHERE ClientID=@ClientID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ClientID", ClientID);

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    Found = true;

                    if (Reader["UserID"] == DBNull.Value) UserID = default;
                    else UserID = (int)Reader["UserID"];

                    if (Reader["UserName"] == DBNull.Value) UserName = default;
                    else UserName = (string)Reader["UserName"];

                    if (Reader["Password"] == DBNull.Value) Password = default;
                    else Password = (string)Reader["Password"];

                    if (Reader["IsActive"] == DBNull.Value) IsActive = default;
                    else IsActive = (bool)Reader["IsActive"];

                    if (Reader["Permission"] == DBNull.Value) Permission = default;
                    else Permission = (int)Reader["Permission"];

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

        public static bool FindUserByUserName(ref int UserID, ref int ClientID, string UserName, ref string Password, ref bool IsActive, ref int Permission)
        {
            bool Found = false;

            SqlConnection Connection = new SqlConnection(clsDataAccess.ConnectionString);

            string Query = "SELECT * FROM Users WHERE UserName=@UserName";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@UserName", UserName);

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    Found = true;

                    if (Reader["UserID"] == DBNull.Value) UserID = default;
                    else UserID = (int)Reader["UserID"];

                    if (Reader["ClientID"] == DBNull.Value) ClientID = default;
                    else ClientID = (int)Reader["ClientID"];

                    if (Reader["Password"] == DBNull.Value) Password = default;
                    else Password = (string)Reader["Password"];

                    if (Reader["IsActive"] == DBNull.Value) IsActive = default;
                    else IsActive = (bool)Reader["IsActive"];

                    if (Reader["Permission"] == DBNull.Value) Permission = default;
                    else Permission = (int)Reader["Permission"];

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

        public static bool FindUserByUserNameAndPassword(ref int UserID, ref int ClientID, string UserName, string Password, ref bool IsActive, ref int Permission)
        {
            bool Found = false;

            SqlConnection Connection = new SqlConnection(clsDataAccess.ConnectionString);

            string Query = "SELECT * FROM Users WHERE UserName=@UserName AND Password=@Password";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@Password", Password);
            Command.Parameters.AddWithValue("@UserName", UserName);

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    Found = true;

                    if (Reader["UserID"] == DBNull.Value) UserID = default;
                    else UserID = (int)Reader["UserID"];

                    if (Reader["ClientID"] == DBNull.Value) ClientID = default;
                    else ClientID = (int)Reader["ClientID"];

                    if (Reader["IsActive"] == DBNull.Value) IsActive = default;
                    else IsActive = (bool)Reader["IsActive"];

                    if (Reader["Permission"] == DBNull.Value) Permission = default;
                    else Permission = (int)Reader["Permission"];

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

        public static bool IsUserExist(string UserName)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccess.ConnectionString);

            string query = "SELECT Found=1 FROM Users WHERE UserName = @UserName";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserName", UserName);

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

        public static bool IsClientExistAsUser(int ClientID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccess.ConnectionString);

            string query = "SELECT Found=1 FROM Users WHERE ClientID = @ClientID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ClientID", ClientID);

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