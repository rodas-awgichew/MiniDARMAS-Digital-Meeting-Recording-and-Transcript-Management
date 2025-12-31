using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MiniDARMAS.Data
{
    public class AgendaData
    {
        public static DataTable GetAgendasByMeeting(int meetingId)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                conn.Open();
                SqlDataAdapter da =
                    new SqlDataAdapter(
                        "SELECT * FROM Agendas WHERE MeetingId=@mid", conn);
                da.SelectCommand.Parameters.AddWithValue("@mid", meetingId);
                da.Fill(dt);
            }
            return dt;
        }

        public static void AddAgenda(int meetingId, string title,string Office,string SupportingDocument)
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Agendas (MeetingId, Title, Office, SupportingDocument) " +
                    "VALUES (@mid, @title,@office, @desc)", conn);

                cmd.Parameters.AddWithValue("@mid", meetingId);
                cmd.Parameters.AddWithValue("@title", title);
                cmd.Parameters.AddWithValue("@office",Office);
                cmd.Parameters.AddWithValue("@desc", SupportingDocument);
                cmd.ExecuteNonQuery();
            }
        }

        public static void DeleteAgenda(int agendaId)
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                conn.Open();
                SqlCommand cmd =
                    new SqlCommand("DELETE FROM Agendas WHERE AgendaId=@id", conn);
                cmd.Parameters.AddWithValue("@id", agendaId);
                cmd.ExecuteNonQuery();
            }
        }
    }
}

