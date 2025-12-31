namespace MiniDARMAS
{
    partial class TranscriptionForm
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
            this.txtTranscription = new System.Windows.Forms.TextBox();
            this.btnSaveDraft = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTranscription
            // 
            this.txtTranscription.Location = new System.Drawing.Point(25, 59);
            this.txtTranscription.Multiline = true;
            this.txtTranscription.Name = "txtTranscription";
            this.txtTranscription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTranscription.Size = new System.Drawing.Size(751, 243);
            this.txtTranscription.TabIndex = 0;
            // 
            // btnSaveDraft
            // 
            this.btnSaveDraft.Location = new System.Drawing.Point(151, 415);
            this.btnSaveDraft.Name = "btnSaveDraft";
            this.btnSaveDraft.Size = new System.Drawing.Size(118, 23);
            this.btnSaveDraft.TabIndex = 1;
            this.btnSaveDraft.Text = "Save Draft";
            this.btnSaveDraft.UseVisualStyleBackColor = true;
            this.btnSaveDraft.Click += new System.EventHandler(this.btnSaveDraft_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(373, 415);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 23);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // backbtn
            // 
            this.backbtn.Location = new System.Drawing.Point(701, 21);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(75, 23);
            this.backbtn.TabIndex = 3;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(97, 337);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(95, 23);
            this.btnPlay.TabIndex = 4;
            this.btnPlay.Text = "▶ Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(237, 337);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(97, 23);
            this.btnPause.TabIndex = 5;
            this.btnPause.Text = "⏸ Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(382, 337);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(91, 23);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "⏪ -5s";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnForward
            // 
            this.btnForward.Location = new System.Drawing.Point(529, 336);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(86, 23);
            this.btnForward.TabIndex = 7;
            this.btnForward.Text = "⏩ +5s";
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // TranscriptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnSaveDraft);
            this.Controls.Add(this.txtTranscription);
            this.Name = "TranscriptionForm";
            this.Text = "Transcription Form";
            this.Load += new System.EventHandler(this.TranscriptionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTranscription;
        private System.Windows.Forms.Button btnSaveDraft;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnForward;
    }
}