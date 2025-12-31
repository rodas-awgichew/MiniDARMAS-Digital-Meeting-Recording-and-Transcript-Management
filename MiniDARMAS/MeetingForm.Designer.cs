namespace MiniDARMAS
{
    partial class MeetingForm
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
            this.dgvMeetings = new System.Windows.Forms.DataGridView();
            this.lblMeetingNo = new System.Windows.Forms.Label();
            this.txtMeetingNo = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblChairperson = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.txtChairperson = new System.Windows.Forms.TextBox();
            this.btnAddMeeting = new System.Windows.Forms.Button();
            this.btnDeleteMeeting = new System.Windows.Forms.Button();
            this.btnManageAgendas = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeetings)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMeetings
            // 
            this.dgvMeetings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMeetings.Location = new System.Drawing.Point(37, 259);
            this.dgvMeetings.Name = "dgvMeetings";
            this.dgvMeetings.RowHeadersWidth = 51;
            this.dgvMeetings.RowTemplate.Height = 24;
            this.dgvMeetings.Size = new System.Drawing.Size(721, 168);
            this.dgvMeetings.TabIndex = 0;
            // 
            // lblMeetingNo
            // 
            this.lblMeetingNo.AutoSize = true;
            this.lblMeetingNo.Location = new System.Drawing.Point(60, 36);
            this.lblMeetingNo.Name = "lblMeetingNo";
            this.lblMeetingNo.Size = new System.Drawing.Size(76, 16);
            this.lblMeetingNo.TabIndex = 1;
            this.lblMeetingNo.Text = "Meeting No";
            // 
            // txtMeetingNo
            // 
            this.txtMeetingNo.Location = new System.Drawing.Point(173, 33);
            this.txtMeetingNo.Name = "txtMeetingNo";
            this.txtMeetingNo.Size = new System.Drawing.Size(100, 22);
            this.txtMeetingNo.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(173, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 3;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(60, 73);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(36, 16);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Date";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(60, 114);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(58, 16);
            this.lblLocation.TabIndex = 5;
            this.lblLocation.Text = "Location";
            // 
            // lblChairperson
            // 
            this.lblChairperson.AutoSize = true;
            this.lblChairperson.Location = new System.Drawing.Point(60, 148);
            this.lblChairperson.Name = "lblChairperson";
            this.lblChairperson.Size = new System.Drawing.Size(80, 16);
            this.lblChairperson.TabIndex = 6;
            this.lblChairperson.Text = "Chairperson";
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(173, 114);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(100, 22);
            this.txtLocation.TabIndex = 7;
            // 
            // txtChairperson
            // 
            this.txtChairperson.Location = new System.Drawing.Point(173, 157);
            this.txtChairperson.Name = "txtChairperson";
            this.txtChairperson.Size = new System.Drawing.Size(100, 22);
            this.txtChairperson.TabIndex = 8;
            // 
            // btnAddMeeting
            // 
            this.btnAddMeeting.Location = new System.Drawing.Point(37, 198);
            this.btnAddMeeting.Name = "btnAddMeeting";
            this.btnAddMeeting.Size = new System.Drawing.Size(103, 23);
            this.btnAddMeeting.TabIndex = 9;
            this.btnAddMeeting.Text = "Add Meeting";
            this.btnAddMeeting.UseVisualStyleBackColor = true;
            this.btnAddMeeting.Click += new System.EventHandler(this.btnAddMeeting_Click);
            // 
            // btnDeleteMeeting
            // 
            this.btnDeleteMeeting.Location = new System.Drawing.Point(183, 198);
            this.btnDeleteMeeting.Name = "btnDeleteMeeting";
            this.btnDeleteMeeting.Size = new System.Drawing.Size(113, 23);
            this.btnDeleteMeeting.TabIndex = 10;
            this.btnDeleteMeeting.Text = "Delete Meeting";
            this.btnDeleteMeeting.UseVisualStyleBackColor = true;
            this.btnDeleteMeeting.Click += new System.EventHandler(this.btnDeleteMeeting_Click);
            // 
            // btnManageAgendas
            // 
            this.btnManageAgendas.Location = new System.Drawing.Point(345, 198);
            this.btnManageAgendas.Name = "btnManageAgendas";
            this.btnManageAgendas.Size = new System.Drawing.Size(132, 23);
            this.btnManageAgendas.TabIndex = 11;
            this.btnManageAgendas.Text = "Manage Agendas";
            this.btnManageAgendas.UseVisualStyleBackColor = true;
            this.btnManageAgendas.Click += new System.EventHandler(this.btnManageAgendas_Click);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(683, 29);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 12;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // MeetingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.btnManageAgendas);
            this.Controls.Add(this.btnDeleteMeeting);
            this.Controls.Add(this.btnAddMeeting);
            this.Controls.Add(this.txtChairperson);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.lblChairperson);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtMeetingNo);
            this.Controls.Add(this.lblMeetingNo);
            this.Controls.Add(this.dgvMeetings);
            this.Name = "MeetingForm";
            this.Text = "MeetingForm";
            this.Load += new System.EventHandler(this.dtpMeetingDate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeetings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMeetings;
        private System.Windows.Forms.Label lblMeetingNo;
        private System.Windows.Forms.TextBox txtMeetingNo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblChairperson;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.TextBox txtChairperson;
        private System.Windows.Forms.Button btnAddMeeting;
        private System.Windows.Forms.Button btnDeleteMeeting;
        private System.Windows.Forms.Button btnManageAgendas;
        private System.Windows.Forms.Button backBtn;
    }
}