namespace MiniDARMAS
{
    partial class ApprovedTranscriptionsForm
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
            this.dgvApproved = new System.Windows.Forms.DataGridView();
            this.btnOpenFinal = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApproved)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvApproved
            // 
            this.dgvApproved.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApproved.Location = new System.Drawing.Point(60, 64);
            this.dgvApproved.Name = "dgvApproved";
            this.dgvApproved.RowHeadersWidth = 51;
            this.dgvApproved.RowTemplate.Height = 24;
            this.dgvApproved.Size = new System.Drawing.Size(570, 236);
            this.dgvApproved.TabIndex = 0;
            // 
            // btnOpenFinal
            // 
            this.btnOpenFinal.Location = new System.Drawing.Point(142, 346);
            this.btnOpenFinal.Name = "btnOpenFinal";
            this.btnOpenFinal.Size = new System.Drawing.Size(172, 23);
            this.btnOpenFinal.TabIndex = 1;
            this.btnOpenFinal.Text = "Open ";
            this.btnOpenFinal.UseVisualStyleBackColor = true;
            this.btnOpenFinal.Click += new System.EventHandler(this.btnOpenFinal_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(676, 36);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ApprovedTranscriptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnOpenFinal);
            this.Controls.Add(this.dgvApproved);
            this.Name = "ApprovedTranscriptionsForm";
            this.Text = "ApprovedTranscriptionsForm";
            this.Load += new System.EventHandler(this.ApprovedTranscriptionsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvApproved)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvApproved;
        private System.Windows.Forms.Button btnOpenFinal;
        private System.Windows.Forms.Button btnBack;
    }
}