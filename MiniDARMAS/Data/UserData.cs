using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniDARMAS.Data;
using System.Data;
using System.Data.SqlClient;

namespace MiniDARMAS.Data
{
    public class UserData
    {
        // READ
        public static DataTable GetAllUsers()
        {
            DataTable table = new DataTable();
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                conn.Open();
                SqlDataAdapter da =
                    new SqlDataAdapter("SELECT * FROM Users", conn);
                da.Fill(table);
            }
            return table;
        }

        // CREATE
        public static void AddUser(string fullName, string username,
                                   string password, string role, bool isActive)
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    @"INSERT INTO Users
                      (FullName, Username, PasswordHash, Role, IsActive)
                      VALUES (@FullName, @Username, @Password, @Role, @IsActive)",
                    conn);

                cmd.Parameters.AddWithValue("@FullName", fullName);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@Role", role);
                cmd.Parameters.AddWithValue("@IsActive", isActive ? 1 : 0);

                cmd.ExecuteNonQuery();
            }
        }

        // UPDATE
        public static void UpdateUser(int userId, string fullName, string role, bool isActive)
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    @"UPDATE Users
                      SET FullName=@FullName,
                          Role=@Role,
                          IsActive=@IsActive
                      WHERE UserId=@UserId",
                    conn);

                cmd.Parameters.AddWithValue("@FullName", fullName);
                cmd.Parameters.AddWithValue("@Role", role);
                cmd.Parameters.AddWithValue("@IsActive", isActive ? 1 : 0);
                cmd.Parameters.AddWithValue("@UserId", userId);

                cmd.ExecuteNonQuery();
            }
        }

        // DEACTIVATE
        public static void DeactivateUser(int userId)
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "UPDATE Users SET IsActive = 0 WHERE UserId = @UserId",
                    conn);

                cmd.Parameters.AddWithValue("@UserId", userId);
                cmd.ExecuteNonQuery();
            }
        }

        public static DataTable GetTranscribers()
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT UserId, FullName FROM Users WHERE Role='Transcriber' AND IsActive=1",
                    conn
                );
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

    }
}
