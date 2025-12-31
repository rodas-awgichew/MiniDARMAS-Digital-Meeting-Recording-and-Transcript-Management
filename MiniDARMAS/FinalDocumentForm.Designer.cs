namespace MiniDARMAS
{
    partial class FinalDocumentForm
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnExportTxt = new System.Windows.Forms.Button();
            this.btnExportRtf = new System.Windows.Forms.Button();
            this.btnExportpdf = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(57, 33);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(499, 204);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // btnExportTxt
            // 
            this.btnExportTxt.Location = new System.Drawing.Point(69, 288);
            this.btnExportTxt.Name = "btnExportTxt";
            this.btnExportTxt.Size = new System.Drawing.Size(129, 23);
            this.btnExportTxt.TabIndex = 1;
            this.btnExportTxt.Text = "Export TXT";
            this.btnExportTxt.UseVisualStyleBackColor = true;
            this.btnExportTxt.Click += new System.EventHandler(this.btnExportTxt_Click);
            // 
            // btnExportRtf
            // 
            this.btnExportRtf.Location = new System.Drawing.Point(269, 288);
            this.btnExportRtf.Name = "btnExportRtf";
            this.btnExportRtf.Size = new System.Drawing.Size(147, 23);
            this.btnExportRtf.TabIndex = 2;
            this.btnExportRtf.Text = "Export  RTF";
            this.btnExportRtf.UseVisualStyleBackColor = true;
            this.btnExportRtf.Click += new System.EventHandler(this.btnExportRtf_Click);
            // 
            // btnExportpdf
            // 
            this.btnExportpdf.Location = new System.Drawing.Point(471, 288);
            this.btnExportpdf.Name = "btnExportpdf";
            this.btnExportpdf.Size = new System.Drawing.Size(109, 23);
            this.btnExportpdf.TabIndex = 3;
            this.btnExportpdf.Text = "Export PDF";
            this.btnExportpdf.UseVisualStyleBackColor = true;
            this.btnExportpdf.Click += new System.EventHandler(this.btnExportpdf_Click);
            // 
            // FinalDocumentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExportpdf);
            this.Controls.Add(this.btnExportRtf);
            this.Controls.Add(this.btnExportTxt);
            this.Controls.Add(this.richTextBox1);
            this.Name = "FinalDocumentForm";
            this.Text = "FinalDocumentForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnExportTxt;
        private System.Windows.Forms.Button btnExportRtf;
        private System.Windows.Forms.Button btnExportpdf;
    }
}