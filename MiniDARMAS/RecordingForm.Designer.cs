namespace MiniDARMAS
{
    partial class RecordingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstRecordings = new System.Windows.Forms.ListBox();
            this.btnAddRecording = new System.Windows.Forms.Button();
            this.openFileDialogAudio = new System.Windows.Forms.OpenFileDialog();
            this.backBtn = new System.Windows.Forms.Button();
            this.btnAssignRecording = new System.Windows.Forms.Button();
            this.btnStartRecord = new System.Windows.Forms.Button();
            this.btnStopRecord = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstRecordings
            // 
            this.lstRecordings.FormattingEnabled = true;
            this.lstRecordings.ItemHeight = 16;
            this.lstRecordings.Location = new System.Drawing.Point(63, 62);
            this.lstRecordings.Name = "lstRecordings";
            this.lstRecordings.Size = new System.Drawing.Size(502, 228);
            this.lstRecordings.TabIndex = 0;
            this.lstRecordings.SelectedIndexChanged += new System.EventHandler(this.lstRecordings_SelectedIndexChanged);
            // 
            // btnAddRecording
            // 
            this.btnAddRecording.Location = new System.Drawing.Point(473, 362);
            this.btnAddRecording.Name = "btnAddRecording";
            this.btnAddRecording.Size = new System.Drawing.Size(176, 23);
            this.btnAddRecording.TabIndex = 1;
            this.btnAddRecording.Text = "Browse Audio";
            this.btnAddRecording.UseVisualStyleBackColor = true;
            this.btnAddRecording.Click += new System.EventHandler(this.btnAddRecording_Click);
            // 
            // openFileDialogAudio
            // 
            this.openFileDialogAudio.FileName = "openFileDialog1";
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(666, 37);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 2;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // btnAssignRecording
            // 
            this.btnAssignRecording.Location = new System.Drawing.Point(290, 405);
            this.btnAssignRecording.Name = "btnAssignRecording";
            this.btnAssignRecording.Size = new System.Drawing.Size(166, 23);
            this.btnAssignRecording.TabIndex = 3;
            this.btnAssignRecording.Text = "Assign to Transcriber";
            this.btnAssignRecording.UseVisualStyleBackColor = true;
            this.btnAssignRecording.Click += new System.EventHandler(this.btnAssignRecording_Click);
            // 
            // btnStartRecord
            // 
            this.btnStartRecord.Location = new System.Drawing.Point(41, 362);
            this.btnStartRecord.Name = "btnStartRecord";
            this.btnStartRecord.Size = new System.Drawing.Size(160, 23);
            this.btnStartRecord.TabIndex = 4;
            this.btnStartRecord.Text = "Start Record";
            this.btnStartRecord.UseVisualStyleBackColor = true;
            this.btnStartRecord.Click += new System.EventHandler(this.btnStartRecord_Click);
            // 
            // btnStopRecord
            // 
            this.btnStopRecord.Location = new System.Drawing.Point(252, 362);
            this.btnStopRecord.Name = "btnStopRecord";
            this.btnStopRecord.Size = new System.Drawing.Size(168, 23);
            this.btnStopRecord.TabIndex = 5;
            this.btnStopRecord.Text = "Stop Record";
            this.btnStopRecord.UseVisualStyleBackColor = true;
            this.btnStopRecord.Click += new System.EventHandler(this.btnStopRecord_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(320, 318);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 16);
            this.lblStatus.TabIndex = 6;
            // 
            // RecordingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnStopRecord);
            this.Controls.Add(this.btnStartRecord);
            this.Controls.Add(this.btnAssignRecording);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.btnAddRecording);
            this.Controls.Add(this.lstRecordings);
            this.Name = "RecordingForm";
            this.Text = "RecordingForm";
            this.Load += new System.EventHandler(this.RecordingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstRecordings;
        private System.Windows.Forms.Button btnAddRecording;
        private System.Windows.Forms.OpenFileDialog openFileDialogAudio;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button btnAssignRecording;
        private System.Windows.Forms.Button btnStartRecord;
        private System.Windows.Forms.Button btnStopRecord;
        private System.Windows.Forms.Label lblStatus;
    }
}