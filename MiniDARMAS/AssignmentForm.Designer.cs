namespace MiniDARMAS
{
    partial class AssignmentForm
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
            this.dgvRecordings = new System.Windows.Forms.DataGridView();
            this.lblTranscriber = new System.Windows.Forms.Label();
            this.cmbTranscribers = new System.Windows.Forms.ComboBox();
            this.btnAssign = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecordings)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRecordings
            // 
            this.dgvRecordings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecordings.Location = new System.Drawing.Point(78, 41);
            this.dgvRecordings.Name = "dgvRecordings";
            this.dgvRecordings.RowHeadersWidth = 51;
            this.dgvRecordings.RowTemplate.Height = 24;
            this.dgvRecordings.Size = new System.Drawing.Size(364, 227);
            this.dgvRecordings.TabIndex = 0;
            // 
            // lblTranscriber
            // 
            this.lblTranscriber.AutoSize = true;
            this.lblTranscriber.Location = new System.Drawing.Point(75, 321);
            this.lblTranscriber.Name = "lblTranscriber";
            this.lblTranscriber.Size = new System.Drawing.Size(76, 16);
            this.lblTranscriber.TabIndex = 1;
            this.lblTranscriber.Text = "Transcriber";
            // 
            // cmbTranscribers
            // 
            this.cmbTranscribers.FormattingEnabled = true;
            this.cmbTranscribers.Location = new System.Drawing.Point(183, 321);
            this.cmbTranscribers.Name = "cmbTranscribers";
            this.cmbTranscribers.Size = new System.Drawing.Size(169, 24);
            this.cmbTranscribers.TabIndex = 2;
            // 
            // btnAssign
            // 
            this.btnAssign.Location = new System.Drawing.Point(117, 382);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(169, 34);
            this.btnAssign.TabIndex = 3;
            this.btnAssign.Text = "Assign";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(668, 32);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 4;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // AssignmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.cmbTranscribers);
            this.Controls.Add(this.lblTranscriber);
            this.Controls.Add(this.dgvRecordings);
            this.Name = "AssignmentForm";
            this.Text = "AssignmentForm";
            this.Load += new System.EventHandler(this.AssignmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecordings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRecordings;
        private System.Windows.Forms.Label lblTranscriber;
        private System.Windows.Forms.ComboBox cmbTranscribers;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.Button backBtn;
    }
}