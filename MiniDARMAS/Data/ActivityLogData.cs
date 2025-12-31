using System;
using System.Data;
using System.Data.SqlClient;

namespace MiniDARMAS.Data
{
    public class ActivityLogData
    {
        public static void Log(
            int userId,
            string action,
            string entityType = null,
            int? entityId = null)
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(
                    @"INSERT INTO ActivityLogs 
                      (UserId, Action, EntityType, EntityId)
                      VALUES (@u, @a, @e, @id)",
                    conn
                );

                cmd.Parameters.AddWithValue("@u", userId);
                cmd.Parameters.AddWithValue("@a", action);
                cmd.Parameters.AddWithValue("@e",
                    (object)entityType ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@id",
                    (object)entityId ?? DBNull.Value);

                cmd.ExecuteNonQuery();
            }
        }

        // Optional: Admin dashboard usage
        public static DataTable GetRecent()
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(
                    @"SELECT TOP 50 
                        U.Username,
                        A.Action,
                        A.EntityType,
                        A.EntityId,
                        A.Timestamp
                      FROM ActivityLogs A
                      JOIN Users U ON A.UserId = U.UserId
                      ORDER BY A.Timestamp DESC",
                    conn
                );

                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}
