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
    public partial class AssignedRecordingsForm : Form
    {
        private int _userId;

        // REQUIRED constructor (called from Dashboard)
        public AssignedRecordingsForm(int userId)
        {
            InitializeComponent();
            _userId = userId;
        }

        // FORM LOAD
        private void AssignedRecordingsForm_Load(object sender, EventArgs e)
        {
            LoadAssignedRecordings();
        }

        private void LoadAssignedRecordings()
        {
            dataGridView1.DataSource =
                AssignmentData.GetAssignedToUser(_userId);

            dataGridView1.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dataGridView1.ReadOnly = true;
        }

        // TRANSCRIBE BUTTON
        private void btnTranscribe_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Please select a recording.");
                return;
            }

            int assignmentId = Convert.ToInt32(
                dataGridView1.CurrentRow.Cells["AssignmentId"].Value
            );

            TranscriptionForm f =
                new TranscriptionForm(assignmentId);

            f.ShowDialog();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

