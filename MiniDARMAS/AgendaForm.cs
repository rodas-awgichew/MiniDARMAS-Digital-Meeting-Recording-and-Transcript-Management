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
    public partial class AgendaForm : Form
    {
        private int _meetingId;

        public AgendaForm(int meetingId)
        {
            InitializeComponent();
            _meetingId = meetingId;
        }


        private void AgendaForm_Load(object sender, EventArgs e)
        {
            dgvAgendas.DataSource = AgendaData.GetAgendasByMeeting(_meetingId);
        }

        private void btnAddAgenda_Click(object sender, EventArgs e)
        {
            AgendaData.AddAgenda(
                _meetingId,
                txtAgendaTitle.Text,
                txtOffice.Text,
                txtAgendaDescription.Text
            );

            dgvAgendas.DataSource = AgendaData.GetAgendasByMeeting(_meetingId);
        }

        private void btnDeleteAgenda_Click(object sender, EventArgs e)
        {
            int agendaId = Convert.ToInt32(
                dgvAgendas.CurrentRow.Cells["AgendaId"].Value
            );

            AgendaData.DeleteAgenda(agendaId);
            dgvAgendas.DataSource = AgendaData.GetAgendasByMeeting(_meetingId);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnManageRecords_Click(object sender, EventArgs e)
        {
            if (dgvAgendas.CurrentRow == null) return;

            int agendaId = Convert.ToInt32(
                dgvAgendas.CurrentRow.Cells["AgendaId"].Value
            );

            RecordingForm f = new RecordingForm(agendaId);
            f.Show();
        }

        private void btnRecordings_Click(object sender, EventArgs e)
        {
            if (dgvAgendas.CurrentRow == null)
            {
                MessageBox.Show("Please select an agenda first.");
                return;
            }

            // Read AgendaId from the selected row
            int agendaId = Convert.ToInt32(
                dgvAgendas.CurrentRow.Cells["AgendaId"].Value
            );

            // Open Recording form for this agenda
            RecordingForm form = new RecordingForm(agendaId);
            form.ShowDialog();
        }
    }
}
