using System;
using System.Data;
using System.Data.SqlClient;

namespace MiniDARMAS.Data
{
    public class AssignmentData
    {
        /* ================================
           ASSIGN RECORDING TO TRANSCRIBER
           ================================ */
        public static void AssignRecording(int recordingId, int userId)
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                conn.Open();

                // 1️⃣ Create Assignment
                SqlCommand cmd = new SqlCommand(
                    @"INSERT INTO Assignments (RecordingId, TranscriberId, StatusId)
              VALUES (@r, @u, @s);
              SELECT SCOPE_IDENTITY();",
                    conn
                );

                cmd.Parameters.AddWithValue("@r", recordingId);
                cmd.Parameters.AddWithValue("@u", userId);
                cmd.Parameters.AddWithValue("@s", StatusIds.Assigned);

                int assignmentId = Convert.ToInt32(cmd.ExecuteScalar());

                // 2️⃣ CREATE transcription row immediately
                SqlCommand tcmd = new SqlCommand(
                    @"INSERT INTO Transcriptions (AssignmentId, StatusId)
              VALUES (@aid, @status)",
                    conn
                );

                tcmd.Parameters.AddWithValue("@aid", assignmentId);
                tcmd.Parameters.AddWithValue("@status", StatusIds.Assigned);

                tcmd.ExecuteNonQuery();
            }
        }


        /* ================================
           GET ASSIGNED RECORDINGS
           ================================ */
        public static DataTable GetAssignedToUser(int userId)
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = DbHelper.GetConnection())
            {
                conn.Open();

                string sql = @"
                SELECT
                    a.AssignmentId,
                    m.MeetingNo,
                    ag.Title AS AgendaTitle,
                    r.AudioFilePath,
                    s.StatusName
                FROM Assignments a
                JOIN Recordings r ON a.RecordingId = r.RecordingId
                JOIN Agendas ag ON r.AgendaId = ag.AgendaId
                JOIN Meetings m ON ag.MeetingId = m.MeetingId
                JOIN StatusLookup s ON a.StatusId = s.StatusId
                WHERE a.TranscriberId = @userId";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.SelectCommand.Parameters.AddWithValue("@userId", userId);
                da.Fill(dt);
            }

            return dt;
        }

        public static string GetAudioPathByAssignment(int assignmentId)
        {
            using (SqlConnection con = DbHelper.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(
                    @"SELECT r.AudioFilePath
              FROM Assignments a
              JOIN Recordings r ON a.RecordingId = r.RecordingId
              WHERE a.AssignmentId = @id", con);

                cmd.Parameters.AddWithValue("@id", assignmentId);

                con.Open();
                return cmd.ExecuteScalar()?.ToString();
            }
        }

    }
}
