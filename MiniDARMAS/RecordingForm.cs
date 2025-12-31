using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MiniDARMAS.Data;
using NAudio.Wave; // Make sure NAudio is installed via NuGet

namespace MiniDARMAS
{
    public partial class RecordingForm : Form
    {
        private int _agendaId;

        // NAudio Variables for Recording
        private WaveInEvent _waveSource = null;
        private WaveFileWriter _waveFile = null;
        private string _tempRecordingPath = "";

        public RecordingForm(int agendaId)
        {
            InitializeComponent();
            _agendaId = agendaId;
        }

        private void RecordingForm_Load(object sender, EventArgs e)
        {
            RefreshRecordingList();
        }

        private void RefreshRecordingList()
        {
            // Fetch records from your DB logic
            lstRecordings.DataSource = RecordingData.GetByAgenda(_agendaId);
            lstRecordings.DisplayMember = "AudioFilePath";
            lstRecordings.ValueMember = "RecordingId";
        }

        // --- SECTION 1: LIVE RECORDING LOGIC ---

        private void btnStartRecord_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Define where to save the file
                string folderPath = Path.Combine(Application.StartupPath, "Recordings");
                if (!Directory.Exists(folderPath)) Directory.CreateDirectory(folderPath);

                _tempRecordingPath = Path.Combine(folderPath, $"Rec_{_agendaId}_{DateTime.Now:yyyyMMdd_HHmmss}.wav");

                // 2. Initialize NAudio WaveIn
                _waveSource = new WaveInEvent();
                _waveSource.WaveFormat = new WaveFormat(44100, 1); // standard quality

                // Event: Write data to file as it arrives from mic
                _waveSource.DataAvailable += (s, a) =>
                {
                    if (_waveFile != null)
                    {
                        _waveFile.Write(a.Buffer, 0, a.BytesRecorded);
                        _waveFile.Flush();
                    }
                };

                // Event: Cleanup when recording stops
                _waveSource.RecordingStopped += (s, a) =>
                {
                    _waveFile?.Dispose();
                    _waveFile = null;
                    _waveSource?.Dispose();
                    _waveSource = null;
                };

                _waveFile = new WaveFileWriter(_tempRecordingPath, _waveSource.WaveFormat);

                // 3. Start Hardware
                _waveSource.StartRecording();

                // 4. UI Feedback
                btnStartRecord.Enabled = false;
                btnStopRecord.Enabled = true;
                lblStatus.Text = "RECORDING...";
                lblStatus.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error starting microphone: " + ex.Message);
            }
        }

        private void btnStopRecord_Click(object sender, EventArgs e)
        {
            // 1. Stop the hardware
            _waveSource?.StopRecording();

            // 2. Save the file path to the Database immediately
            // This makes the recording "official" so the operator can see it
            RecordingData.AddRecording(_agendaId, _tempRecordingPath);

            // 3. Update UI
            btnStartRecord.Enabled = true;
            btnStopRecord.Enabled = false;
            lblStatus.Text = "Recording Saved Successfully!";
            lblStatus.ForeColor = Color.Green;

            RefreshRecordingList();
        }

        // --- SECTION 2: BROWSE EXISTING FILE ---

        private void btnAddRecording_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Audio Files|*.mp3;*.wav";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                RecordingData.AddRecording(_agendaId, ofd.FileName);
                RefreshRecordingList();
            }
        }

        // --- SECTION 3: ASSIGN TO TRANSCRIBER ---

        private void btnAssignRecording_Click(object sender, EventArgs e)
        {
            if (lstRecordings.SelectedItem == null)
            {
                MessageBox.Show("Please select a recording from the list first.");
                return;
            }

            // Extract the RecordingId from the selected ListBox item
            int recordingId = Convert.ToInt32(((DataRowView)lstRecordings.SelectedItem)["RecordingId"]);

            // Open the assignment form
            AssignmentForm f = new AssignmentForm(recordingId);
            f.ShowDialog();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            _waveSource?.StopRecording(); // Ensure mic is off
            this.Close();
        }
        private void lstRecordings_SelectedIndexChanged(object sender, EventArgs e)
        {
                    }
    }
}