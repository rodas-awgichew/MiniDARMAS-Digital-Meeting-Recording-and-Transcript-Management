using System.Data;
using System.Data.SqlClient;

namespace MiniDARMAS.Data
{
    public class DashboardData
    {
        public static int GetCount(string table)
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    $"SELECT COUNT(*) FROM {table}", conn);
                return (int)cmd.ExecuteScalar();
            }
        }

        public static int GetPendingTranscriptions()
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "SELECT COUNT(*) FROM Transcriptions WHERE StatusId=@s",
                    conn);
                cmd.Parameters.AddWithValue("@s", StatusIds.Submitted);
                return (int)cmd.ExecuteScalar();
            }
        }

        public static int GetApprovedTranscriptions()
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "SELECT COUNT(*) FROM Transcriptions WHERE StatusId=@s",
                    conn);
                cmd.Parameters.AddWithValue("@s", StatusIds.Approved);
                return (int)cmd.ExecuteScalar();
            }
        }

        public static DataTable GetActivityLog()
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(
    "SELECT TOP 50 * FROM ActivityLogs ORDER BY Timestamp DESC",
    conn
);


                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}
