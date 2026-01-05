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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            string selectedRole = cmbRole.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedRole))
            {
                lblError.Text = "Please select a role.";
                return;
            }

            using (SqlConnection conn = DbHelper.GetConnection())
            {
                conn.Open();

                string query = @"
            SELECT UserId, Role
            FROM Users
            WHERE Username = @username
              AND PasswordHash = @password
              AND IsActive = 1";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    int userId = reader.GetInt32(0);
                    string dbRole = reader.GetString(1);

                    // 🔐 ROLE CHECK
                    if (!dbRole.Equals(selectedRole, StringComparison.OrdinalIgnoreCase))
                    {
                        lblError.Text =
                            $"You are not authorized to login as {selectedRole}.";
                        return;
                    }

                    // ✅ Authorized
                    AppSession.UserId = userId;
                    AppSession.Role = dbRole;

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

        

        private void LoginForm_Load(object sender, EventArgs e)
        {
            cmbRole.SelectedIndex = 0;
        }
    }
}
