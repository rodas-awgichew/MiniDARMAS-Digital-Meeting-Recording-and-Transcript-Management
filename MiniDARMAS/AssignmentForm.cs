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
    public partial class AssignmentForm : Form
    {
        private int _recordingId;


        public AssignmentForm(int recordingId)
        {
            InitializeComponent();
            _recordingId = recordingId;
        }



        private void btnAssign_Click(object sender, EventArgs e)
        {
            int transcriberId =
                Convert.ToInt32(cmbTranscribers.SelectedValue);

            AssignmentData.AssignRecording(
                _recordingId,
                transcriberId
            );

            MessageBox.Show("Recording assigned successfully");
            this.Close();
        }


        private void AssignmentForm_Load(object sender, EventArgs e)
        {
            // We use a new specialized method so we don't break the Agenda-based loading
            dgvRecordings.DataSource = RecordingData.GetSingleRecordingForDisplay(_recordingId);

            // This part remains exactly as you had it
            cmbTranscribers.DataSource = UserData.GetTranscribers();
            cmbTranscribers.DisplayMember = "FullName";
            cmbTranscribers.ValueMember = "UserId";
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
