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
    public partial class ReviewForm : Form
    {
        public ReviewForm()
        {
            InitializeComponent();
        }

        private void ReviewForm_Load(object sender, EventArgs e)
        {
            dgvSubmissions.DataSource =
                ReviewData.GetPendingSubmissions();
        }

        private void dgvSubmissions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private int _transcriptionId;

        private void dgvSubmissions_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSubmissions.CurrentRow == null)
                return;

            object idValue =
                dgvSubmissions.CurrentRow.Cells["TranscriptionId"].Value;

            if (idValue == DBNull.Value || idValue == null)
                return;

            // ✅ STORE IT
            _transcriptionId = Convert.ToInt32(idValue);

            // Load transcription text
            object textValue =
                dgvSubmissions.CurrentRow.Cells["TextContent"].Value;

            txtTranscriptionText.Text =
                textValue == DBNull.Value ? "" : textValue.ToString();

            // Load comments
            object commentValue =
                dgvSubmissions.CurrentRow.Cells["EditorComments"].Value;

            txtEditorComments.Text =
                commentValue == DBNull.Value ? "" : commentValue.ToString();
        }



        private void btnApprove_Click(object sender, EventArgs e)
        {
            ReviewData.ApproveTranscription(
                _transcriptionId,
                txtEditorComments.Text
            );

            MessageBox.Show("Approved.");
            dgvSubmissions.DataSource =
                ReviewData.GetPendingSubmissions();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            ReviewData.ReturnForCorrection(
                _transcriptionId,
                txtEditorComments.Text
            );

            MessageBox.Show("Returned for correction.");
            dgvSubmissions.DataSource =
                ReviewData.GetPendingSubmissions();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
