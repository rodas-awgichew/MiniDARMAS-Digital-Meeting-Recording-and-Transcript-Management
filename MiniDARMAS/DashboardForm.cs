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
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }
        private void LoadAdminStatistics()
        {
            lblTotalMeetings.Text =
                $"Total Meetings: {DashboardData.GetCount("Meetings")}";

            lblTotalRecordings.Text =
                $"Total Recordings: {DashboardData.GetCount("Recordings")}";

            lblPendingTranscriptions.Text =
                $"Pending Transcriptions: {DashboardData.GetPendingTranscriptions()}";

            lblApprovedTranscriptions.Text =
                $"Approved Transcriptions: {DashboardData.GetApprovedTranscriptions()}";
        }

        private void LoadActivityLog()
        {
            dgvActivityLogs.DataSource = ActivityLogData.GetRecent();

        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            string role = AppSession.Role;

            // Hide menus
            adminToolStripMenuItem.Visible = false;
            adminToolStripMenuItem1.Visible = false;
            operatorToolStripMenuItem.Visible = false;
            transcriberToolStripMenuItem.Visible = false;
            editorToolStripMenuItem.Visible = false;
            approverToolStripMenuItem.Visible = false;

            // Hide admin panels
            grpAdminStats.Visible = false;
            grpActivityLog.Visible = false;

            switch (role)
            {
                case "Admin":
                    adminToolStripMenuItem.Visible = true;
                    adminToolStripMenuItem1.Visible = true;
                    operatorToolStripMenuItem.Visible = true;

                    grpAdminStats.Visible = true;
                    grpActivityLog.Visible = true;

                    LoadAdminStatistics();
                    LoadActivityLog();
                    break;

                case "Operator":
                    operatorToolStripMenuItem.Visible = true;
                    break;

                case "Transcriber":
                    transcriberToolStripMenuItem.Visible = true;
                    break;

                case "Editor":
                    editorToolStripMenuItem.Visible = true;
                    break;

                case "Approver":
                    approverToolStripMenuItem.Visible = true;
                    break;
            }
        }



        private void adminToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new AdminForm().ShowDialog();
        }

        private void operatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new MeetingForm().ShowDialog();
        }

        private void transcriberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AssignedRecordingsForm f =
                new AssignedRecordingsForm(AppSession.UserId);

            f.ShowDialog();
        }




        private void editorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ReviewForm().ShowDialog();
        }

        private void approverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ApprovedTranscriptionsForm().ShowDialog();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Close();
        }
    }
}
