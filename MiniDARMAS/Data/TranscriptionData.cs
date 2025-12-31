using System;
using System.Data;
using System.Data.SqlClient;

namespace MiniDARMAS.Data
{
    public class TranscriptionData
    {
        public static string GetDraft(int assignmentId)
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(
                    "SELECT TextContent FROM Transcriptions WHERE AssignmentId = @aid",
                    conn
                );

                cmd.Parameters.AddWithValue("@aid", assignmentId);

                object result = cmd.ExecuteScalar();
                return result == null || result == DBNull.Value
                    ? ""
                    : result.ToString();
            }
        }

        public static void SaveDraft(int assignmentId, string text)
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(
                    @"IF NOT EXISTS (
                  SELECT 1 FROM Transcriptions WHERE AssignmentId = @aid
              )
              BEGIN
                  INSERT INTO Transcriptions (AssignmentId, TextContent, StatusId)
                  VALUES (@aid, @text, @status)
              END
              ELSE
              BEGIN
                  UPDATE Transcriptions
                  SET TextContent = @text
                  WHERE AssignmentId = @aid
              END",
                    conn
                );

                cmd.Parameters.AddWithValue("@aid", assignmentId);
                cmd.Parameters.AddWithValue("@text", text);
                cmd.Parameters.AddWithValue("@status", StatusIds.Assigned);

                cmd.ExecuteNonQuery();
            }
        }


        public static void SubmitForReview(int assignmentId, string text)
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(
                    @"IF EXISTS (
                  SELECT 1 FROM Transcriptions WHERE AssignmentId = @aid
              )
              BEGIN
                  UPDATE Transcriptions
                  SET TextContent = @text,
                      StatusId = @status,
                      LastUpdated = GETDATE()
                  WHERE AssignmentId = @aid
              END
              ELSE
              BEGIN
                  INSERT INTO Transcriptions (
                      AssignmentId,
                      TextContent,
                      StatusId,
                      LastUpdated
                  )
                  VALUES (
                      @aid,
                      @text,
                      @status,
                      GETDATE()
                  )
              END",
                    conn
                );

                cmd.Parameters.Add("@aid", SqlDbType.Int).Value = assignmentId;
                cmd.Parameters.Add("@text", SqlDbType.NVarChar).Value = text;
                cmd.Parameters.Add("@status", SqlDbType.Int).Value = StatusIds.UnderReview;

                cmd.ExecuteNonQuery();
            }
        }




    }
}
