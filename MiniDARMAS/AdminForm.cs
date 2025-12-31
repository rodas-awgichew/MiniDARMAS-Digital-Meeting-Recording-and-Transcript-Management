using MiniDARMAS.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniDARMAS
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            dgvUsers.DataSource = UserData.GetAllUsers();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            UserData.AddUser(
                txtFullName.Text,
                txtUsername.Text,
                txtPassword.Text,
                cmbRole.Text,
                chkIsActive.Checked   
            );

            dgvUsers.DataSource = UserData.GetAllUsers();
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow == null) return;

            int userId = Convert.ToInt32(
                dgvUsers.CurrentRow.Cells["UserId"].Value);

            UserData.UpdateUser(
                userId,
                txtFullName.Text,
                cmbRole.Text,
                chkIsActive.Checked
            );

            dgvUsers.DataSource = UserData.GetAllUsers();
        }

        private void btnDeactivate_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow == null) return;

            int userId = Convert.ToInt32(
                dgvUsers.CurrentRow.Cells["UserId"].Value);

            UserData.DeactivateUser(userId);

            dgvUsers.DataSource = UserData.GetAllUsers();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DashboardForm f = new DashboardForm();
            f.Show();
            this.Close();
        }
    }
}
