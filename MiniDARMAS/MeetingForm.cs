using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiniDARMAS.Data;

namespace MiniDARMAS
{
    public partial class MeetingForm : Form
    {
        private int _meetingId;
        public MeetingForm()
        {
            InitializeComponent();

        }


        private void dtpMeetingDate_Load(object sender, EventArgs e)
        {
            dgvMeetings.DataSource = MeetingData.GetAllMeetings();
        }

        private void btnAddMeeting_Click(object sender, EventArgs e)
        {
            MeetingData.AddMeeting(
                txtMeetingNo.Text,
                Convert.ToDateTime(textBox1.Text),
                txtLocation.Text,
                txtChairperson.Text
            );

            dgvMeetings.DataSource = MeetingData.GetAllMeetings();
        }

        private void btnDeleteMeeting_Click(object sender, EventArgs e)
        {
            if (dgvMeetings.CurrentRow == null) return;

            int meetingId = Convert.ToInt32(
                dgvMeetings.CurrentRow.Cells["MeetingId"].Value
            );

            MeetingData.DeleteMeeting(meetingId);
            dgvMeetings.DataSource = MeetingData.GetAllMeetings();
        }

        private void btnManageAgendas_Click(object sender, EventArgs e)
        {
            if (dgvMeetings.CurrentRow == null) return;

            int meetingId = Convert.ToInt32(
                dgvMeetings.CurrentRow.Cells["MeetingId"].Value
            );

            AgendaForm f = new AgendaForm(meetingId);
            f.Show();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
