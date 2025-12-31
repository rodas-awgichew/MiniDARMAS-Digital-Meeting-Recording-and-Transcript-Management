namespace MiniDARMAS
{
    partial class ReviewForm
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
            this.dgvSubmissions = new System.Windows.Forms.DataGridView();
            this.txtTranscriptionText = new System.Windows.Forms.TextBox();
            this.txtEditorComments = new System.Windows.Forms.TextBox();
            this.btnApprove = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.lblComment = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubmissions)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSubmissions
            // 
            this.dgvSubmissions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubmissions.Location = new System.Drawing.Point(28, 281);
            this.dgvSubmissions.Name = "dgvSubmissions";
            this.dgvSubmissions.RowHeadersWidth = 51;
            this.dgvSubmissions.RowTemplate.Height = 24;
            this.dgvSubmissions.Size = new System.Drawing.Size(737, 157);
            this.dgvSubmissions.TabIndex = 0;
            this.dgvSubmissions.SelectionChanged += new System.EventHandler(this.dgvSubmissions_SelectionChanged);
            // 
            // txtTranscriptionText
            // 
            this.txtTranscriptionText.Location = new System.Drawing.Point(161, 40);
            this.txtTranscriptionText.Multiline = true;
            this.txtTranscriptionText.Name = "txtTranscriptionText";
            this.txtTranscriptionText.Size = new System.Drawing.Size(335, 104);
            this.txtTranscriptionText.TabIndex = 1;
            // 
            // txtEditorComments
            // 
            this.txtEditorComments.Location = new System.Drawing.Point(161, 167);
            this.txtEditorComments.Name = "txtEditorComments";
            this.txtEditorComments.Size = new System.Drawing.Size(155, 22);
            this.txtEditorComments.TabIndex = 2;
            // 
            // btnApprove
            // 
            this.btnApprove.Location = new System.Drawing.Point(151, 225);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(90, 23);
            this.btnApprove.TabIndex = 3;
            this.btnApprove.Text = "Approve";
            this.btnApprove.UseVisualStyleBackColor = true;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(286, 225);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(111, 23);
            this.btnReturn.TabIndex = 4;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(690, 26);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 5;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Location = new System.Drawing.Point(70, 167);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(64, 16);
            this.lblComment.TabIndex = 6;
            this.lblComment.Text = "Comment";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Text";
            // 
            // ReviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblComment);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.txtEditorComments);
            this.Controls.Add(this.txtTranscriptionText);
            this.Controls.Add(this.dgvSubmissions);
            this.Name = "ReviewForm";
            this.Text = "ReviewForm";
            this.Load += new System.EventHandler(this.ReviewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubmissions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSubmissions;
        private System.Windows.Forms.TextBox txtTranscriptionText;
        private System.Windows.Forms.TextBox txtEditorComments;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.Label label1;
    }
}