using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MiniDARMAS.Data
{
    public class ReviewData
    {
        public static DataTable GetPendingSubmissions()
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(
                    @"SELECT 
                TranscriptionId,
                AssignmentId,
                TextContent,
                EditorComments,
                StatusId
              FROM Transcriptions
              WHERE StatusId = @status",
                    conn
                );

                da.SelectCommand.Parameters.AddWithValue(
                    "@status", StatusIds.UnderReview
                );

                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }


        public static void ApproveTranscription(int transcriptionId, string comments)
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(
                    @"UPDATE Transcriptions 
                      SET StatusId = @status, EditorComments = @c 
                      WHERE TranscriptionId = @id",
                    conn
                );

                cmd.Parameters.AddWithValue("@status", StatusIds.Approved);
                cmd.Parameters.AddWithValue("@c", comments);
                cmd.Parameters.AddWithValue("@id", transcriptionId);

                cmd.ExecuteNonQuery();
            }
        }

        public static void ReturnForCorrection(int transcriptionId, string comments)
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(
                    @"UPDATE Transcriptions 
                      SET StatusId = @status, EditorComments = @c 
                      WHERE TranscriptionId = @id",
                    conn
                );

                cmd.Parameters.AddWithValue("@status", StatusIds.Returned);
                cmd.Parameters.AddWithValue("@c", comments);
                cmd.Parameters.AddWithValue("@id", transcriptionId);

                cmd.ExecuteNonQuery();
            }
        }

        public static DataTable GetApprovedTranscriptions()
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(
                    @"SELECT 
                TranscriptionId,
                AssignmentId,
                TextContent,
                EditorComments,
                StatusId,
                LastUpdated

              FROM Transcriptions
              WHERE StatusId = @status",
                    conn
                );

                da.SelectCommand.Parameters.AddWithValue(
    "@status", StatusIds.UnderReview
);


                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}

