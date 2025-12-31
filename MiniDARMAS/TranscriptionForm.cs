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
using WMPLib;

namespace MiniDARMAS
{
    public partial class TranscriptionForm : Form
    {
        private int _assignmentId;
        private string _audioPath;
        private WindowsMediaPlayer _player;

        public TranscriptionForm(int assignmentId)
        {
            InitializeComponent();
            _assignmentId = assignmentId;
            _player = new WindowsMediaPlayer();
        }

        private void TranscriptionForm_Load(object sender, EventArgs e)
        {
            LoadDraftAndAudio();
        }

        private void LoadDraftAndAudio()
        {
            // Get transcription text
            txtTranscription.Text =
                TranscriptionData.GetDraft(_assignmentId);

            // Get audio file path
            _audioPath =
                AssignmentData.GetAudioPathByAssignment(_assignmentId);

            _player.URL = _audioPath;
            _player.controls.stop();
        }

        // ▶ Play
        private void btnPlay_Click(object sender, EventArgs e)
        {
            _player.controls.play();
        }

        // ⏸ Pause
        private void btnPause_Click(object sender, EventArgs e)
        {
            _player.controls.pause();
        }

        // ⏪ Backward 5 seconds
        private void btnBack_Click(object sender, EventArgs e)
        {
            _player.controls.currentPosition =
                Math.Max(0, _player.controls.currentPosition - 5);
        }

        // ⏩ Forward 5 seconds
        private void btnForward_Click(object sender, EventArgs e)
        {
            _player.controls.currentPosition += 5;
        }

        // 💾 Save Draft
        private void btnSaveDraft_Click(object sender, EventArgs e)
        {
            TranscriptionData.SaveDraft(
                _assignmentId,
                txtTranscription.Text
            );

            MessageBox.Show("Draft saved.");
        }

        // 📤 Submit
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            TranscriptionData.SubmitForReview(
                _assignmentId,
                txtTranscription.Text
            );

            MessageBox.Show("Submitted for review.");
            this.Close();
        }

        // 🔙 Back
        private void backbtn_Click(object sender, EventArgs e)
        {
            _player.controls.stop();
            this.Close();
        }
    }
}
