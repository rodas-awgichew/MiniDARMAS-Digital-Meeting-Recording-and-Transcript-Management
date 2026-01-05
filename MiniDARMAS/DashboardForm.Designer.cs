namespace MiniDARMAS
{
    partial class DashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.operatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transcriberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.approverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.grpAdminStats = new System.Windows.Forms.GroupBox();
            this.lblApprovedTranscriptions = new System.Windows.Forms.Label();
            this.lblPendingTranscriptions = new System.Windows.Forms.Label();
            this.lblTotalRecordings = new System.Windows.Forms.Label();
            this.lblTotalMeetings = new System.Windows.Forms.Label();
            this.grpActivityLog = new System.Windows.Forms.GroupBox();
            this.dgvActivityLogs = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.grpAdminStats.SuspendLayout();
            this.grpActivityLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivityLogs)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 28);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(14, 20);
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem1,
            this.operatorToolStripMenuItem,
            this.transcriberToolStripMenuItem,
            this.editorToolStripMenuItem,
            this.approverToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 28);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // adminToolStripMenuItem1
            // 
            this.adminToolStripMenuItem1.Name = "adminToolStripMenuItem1";
            this.adminToolStripMenuItem1.Size = new System.Drawing.Size(67, 24);
            this.adminToolStripMenuItem1.Text = "Admin";
            this.adminToolStripMenuItem1.Click += new System.EventHandler(this.adminToolStripMenuItem1_Click);
            // 
            // operatorToolStripMenuItem
            // 
            this.operatorToolStripMenuItem.Name = "operatorToolStripMenuItem";
            this.operatorToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.operatorToolStripMenuItem.Text = "Operator";
            this.operatorToolStripMenuItem.Click += new System.EventHandler(this.operatorToolStripMenuItem_Click);
            // 
            // transcriberToolStripMenuItem
            // 
            this.transcriberToolStripMenuItem.Name = "transcriberToolStripMenuItem";
            this.transcriberToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.transcriberToolStripMenuItem.Text = "Transcriber";
            this.transcriberToolStripMenuItem.Click += new System.EventHandler(this.transcriberToolStripMenuItem_Click);
            // 
            // editorToolStripMenuItem
            // 
            this.editorToolStripMenuItem.Name = "editorToolStripMenuItem";
            this.editorToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.editorToolStripMenuItem.Text = "Editor";
            this.editorToolStripMenuItem.Click += new System.EventHandler(this.editorToolStripMenuItem_Click);
            // 
            // approverToolStripMenuItem
            // 
            this.approverToolStripMenuItem.Name = "approverToolStripMenuItem";
            this.approverToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.approverToolStripMenuItem.Text = "Approver";
            this.approverToolStripMenuItem.Click += new System.EventHandler(this.approverToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(263, 90);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(171, 16);
            this.lblWelcome.TabIndex = 2;
            this.lblWelcome.Text = "Welcome to Mini-DARMAS!";
            
            // 
            // grpAdminStats
            // 
            this.grpAdminStats.Controls.Add(this.lblApprovedTranscriptions);
            this.grpAdminStats.Controls.Add(this.lblPendingTranscriptions);
            this.grpAdminStats.Controls.Add(this.lblTotalRecordings);
            this.grpAdminStats.Controls.Add(this.lblTotalMeetings);
            this.grpAdminStats.Location = new System.Drawing.Point(12, 124);
            this.grpAdminStats.Name = "grpAdminStats";
            this.grpAdminStats.Size = new System.Drawing.Size(328, 273);
            this.grpAdminStats.TabIndex = 3;
            this.grpAdminStats.TabStop = false;
            this.grpAdminStats.Text = "System Statistics";
            // 
            // lblApprovedTranscriptions
            // 
            this.lblApprovedTranscriptions.AutoSize = true;
            this.lblApprovedTranscriptions.Location = new System.Drawing.Point(45, 132);
            this.lblApprovedTranscriptions.Name = "lblApprovedTranscriptions";
            this.lblApprovedTranscriptions.Size = new System.Drawing.Size(168, 16);
            this.lblApprovedTranscriptions.TabIndex = 3;
            this.lblApprovedTranscriptions.Text = "Approved Transcriptions: 0";
            // 
            // lblPendingTranscriptions
            // 
            this.lblPendingTranscriptions.AutoSize = true;
            this.lblPendingTranscriptions.Location = new System.Drawing.Point(45, 98);
            this.lblPendingTranscriptions.Name = "lblPendingTranscriptions";
            this.lblPendingTranscriptions.Size = new System.Drawing.Size(158, 16);
            this.lblPendingTranscriptions.TabIndex = 2;
            this.lblPendingTranscriptions.Text = "Pending Transcriptions: 0";
            // 
            // lblTotalRecordings
            // 
            this.lblTotalRecordings.AutoSize = true;
            this.lblTotalRecordings.Location = new System.Drawing.Point(45, 65);
            this.lblTotalRecordings.Name = "lblTotalRecordings";
            this.lblTotalRecordings.Size = new System.Drawing.Size(124, 16);
            this.lblTotalRecordings.TabIndex = 1;
            this.lblTotalRecordings.Text = "Total Recordings: 0";
            // 
            // lblTotalMeetings
            // 
            this.lblTotalMeetings.AutoSize = true;
            this.lblTotalMeetings.Location = new System.Drawing.Point(45, 31);
            this.lblTotalMeetings.Name = "lblTotalMeetings";
            this.lblTotalMeetings.Size = new System.Drawing.Size(109, 16);
            this.lblTotalMeetings.TabIndex = 0;
            this.lblTotalMeetings.Text = "Total Meetings: 0";
            // 
            // grpActivityLog
            // 
            this.grpActivityLog.Controls.Add(this.dgvActivityLogs);
            this.grpActivityLog.Location = new System.Drawing.Point(373, 124);
            this.grpActivityLog.Name = "grpActivityLog";
            this.grpActivityLog.Size = new System.Drawing.Size(381, 273);
            this.grpActivityLog.TabIndex = 4;
            this.grpActivityLog.TabStop = false;
            this.grpActivityLog.Text = "Recent Activity";
            // 
            // dgvActivityLogs
            // 
            this.dgvActivityLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActivityLogs.Location = new System.Drawing.Point(21, 31);
            this.dgvActivityLogs.Name = "dgvActivityLogs";
            this.dgvActivityLogs.RowHeadersWidth = 51;
            this.dgvActivityLogs.RowTemplate.Height = 24;
            this.dgvActivityLogs.Size = new System.Drawing.Size(338, 221);
            this.dgvActivityLogs.TabIndex = 0;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpActivityLog);
            this.Controls.Add(this.grpAdminStats);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DashboardForm";
            this.Text = "DashboardForm";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.grpAdminStats.ResumeLayout(false);
            this.grpAdminStats.PerformLayout();
            this.grpActivityLog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivityLogs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem operatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transcriberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem approverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.GroupBox grpAdminStats;
        private System.Windows.Forms.Label lblApprovedTranscriptions;
        private System.Windows.Forms.Label lblPendingTranscriptions;
        private System.Windows.Forms.Label lblTotalRecordings;
        private System.Windows.Forms.Label lblTotalMeetings;
        private System.Windows.Forms.GroupBox grpActivityLog;
        private System.Windows.Forms.DataGridView dgvActivityLogs;
    }
}