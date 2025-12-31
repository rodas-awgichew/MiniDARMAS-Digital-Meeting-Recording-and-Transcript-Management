using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration; 

namespace MiniDARMAS.Data
{
    public static class DbHelper
    {
        // Now reading from App.config instead of hardcoding
        private static readonly string connectionString =
            ConfigurationManager.ConnectionStrings["MiniDARMAS_Conn"].ConnectionString;

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        public static DataTable GetDataTable(string sqlQuery)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, conn))
                {
                    adapter.Fill(dt);
                }
            }
            return dt;
        }
    }
}