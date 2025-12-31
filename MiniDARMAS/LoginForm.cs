using MiniDARMAS.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniDARMAS
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            using (SqlConnection conn = DbHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT UserId, Role FROM Users WHERE Username=@username AND PasswordHash=@password AND IsActive=1";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    int userId = reader.GetInt32(0);
                    string role = reader.GetString(1);

                    AppSession.UserId = userId;
                    AppSession.Role = role;

                    DashboardForm dashboard = new DashboardForm();
                    dashboard.Show();
                    this.Hide();

                }
                else
                {
                    lblError.Text = "Invalid username or password!";
                }
            }
        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();

 
            // Shift focus back to the first field
            txtUsername.Focus();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
