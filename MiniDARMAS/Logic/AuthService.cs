using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniDARMAS.Data;
using System.Data.SqlClient;

namespace MiniDARMAS.Logic
{
    public class AuthService
    {
        public static bool Login(string username, string password, out int userId, out string role)
        {
            userId = 0;
            role = null;

            using (SqlConnection conn = DbHelper.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "SELECT UserId, Role FROM Users WHERE Username=@u AND PasswordHash=@p AND IsActive=1",
                    conn);

                cmd.Parameters.AddWithValue("@u", username);
                cmd.Parameters.AddWithValue("@p", password);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    userId = reader.GetInt32(0);
                    role = reader.GetString(1);
                    return true;
                }
            }
            return false;
        }
    }
}
