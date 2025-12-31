using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MiniDARMAS.Data
{
    public class MeetingData
    {
        public static DataTable GetAllMeetings()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                conn.Open();
                SqlDataAdapter da =
                    new SqlDataAdapter("SELECT * FROM Meetings", conn);
                da.Fill(dt);
            }
            return dt;
        }

        public static void AddMeeting(
    string meetingNo,
    DateTime date,
    string location,
    string chairperson
)
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Meetings " +
                    "(MeetingNo, Date, Location, Chairperson, StatusId) " +
                    "VALUES (@no, @date, @loc, @chair, @status)",
                    conn
                );

                cmd.Parameters.AddWithValue("@no", meetingNo);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@loc", location);
                cmd.Parameters.AddWithValue("@chair", chairperson);
                cmd.Parameters.AddWithValue("@status", 1); // Created

                cmd.ExecuteNonQuery();
            }
        }


        public static void DeleteMeeting(int meetingId)
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                conn.Open();
                SqlCommand cmd =
                    new SqlCommand("DELETE FROM Meetings WHERE MeetingId=@id", conn);
                cmd.Parameters.AddWithValue("@id", meetingId);
                cmd.ExecuteNonQuery();
            }
        }
    }
}

