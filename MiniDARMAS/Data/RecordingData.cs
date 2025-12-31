using System.Data;
using System.Data.SqlClient;

namespace MiniDARMAS.Data
{
    public class RecordingData
    {
        // Get all recordings for a specific agenda
        public static DataTable GetByAgenda(int agendaId)
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = DbHelper.GetConnection())
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(
                    "SELECT RecordingId, AudioFilePath FROM Recordings WHERE AgendaId = @agendaId",
                    conn
                );

                cmd.Parameters.AddWithValue("@agendaId", agendaId);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }

            return dt;
        }


        // Add a new recording for an agenda
        public static void AddRecording(int agendaId, string path)
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Recordings (AgendaId, AudioFilePath) VALUES (@agendaId, @path)",
                    conn
                );

                cmd.Parameters.AddWithValue("@agendaId", agendaId);
                cmd.Parameters.AddWithValue("@path", path);

                cmd.ExecuteNonQuery();
            }
        }
        public static DataTable GetSingleRecordingForDisplay(int recordingId)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                // We select the same columns your DGV expects, but filter by RecordingId
                string sql = @"SELECT RecordingId, AudioFilePath 
                       FROM Recordings 
                       WHERE RecordingId = @recordingId";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.SelectCommand.Parameters.AddWithValue("@recordingId", recordingId);
                conn.Open();
                da.Fill(dt);
            }
            return dt;
        }
    }
}
