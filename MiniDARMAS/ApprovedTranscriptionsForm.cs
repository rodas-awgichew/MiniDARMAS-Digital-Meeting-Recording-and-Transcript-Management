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
    public partial class ApprovedTranscriptionsForm : Form
    {
        public ApprovedTranscriptionsForm()
        {
            InitializeComponent();
        }

        private void ApprovedTranscriptionsForm_Load(object sender, EventArgs e)
        {
            dgvApproved.DataSource =
                ReviewData.GetApprovedTranscriptions();

            dgvApproved.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvApproved.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvApproved.MultiSelect = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void btnOpenFinal_Click(object sender, EventArgs e)
        {
            if (dgvApproved.CurrentRow == null)
            {
                MessageBox.Show("Please select a transcription.");
                return;
            }

            object textValue =
                dgvApproved.CurrentRow.Cells["TextContent"].Value;

            string transcriptionText =
                textValue == DBNull.Value ? "" : textValue.ToString();

            FinalDocumentForm form =
                new FinalDocumentForm(transcriptionText);

            form.ShowDialog();
        }

    }
}
