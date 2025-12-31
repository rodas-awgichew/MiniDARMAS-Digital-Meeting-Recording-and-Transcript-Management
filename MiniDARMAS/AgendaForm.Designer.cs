namespace MiniDARMAS
{
    partial class AgendaForm
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
            this.dgvAgendas = new System.Windows.Forms.DataGridView();
            this.lblAgendaTitle = new System.Windows.Forms.Label();
            this.lblOffice = new System.Windows.Forms.Label();
            this.lblDocument = new System.Windows.Forms.Label();
            this.txtAgendaTitle = new System.Windows.Forms.TextBox();
            this.txtOffice = new System.Windows.Forms.TextBox();
            this.txtAgendaDescription = new System.Windows.Forms.TextBox();
            this.btnAddAgenda = new System.Windows.Forms.Button();
            this.btnDeleteAgenda = new System.Windows.Forms.Button();
            this.btnRecordings = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgendas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAgendas
            // 
            this.dgvAgendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgendas.Location = new System.Drawing.Point(23, 272);
            this.dgvAgendas.Name = "dgvAgendas";
            this.dgvAgendas.RowHeadersWidth = 51;
            this.dgvAgendas.RowTemplate.Height = 24;
            this.dgvAgendas.Size = new System.Drawing.Size(746, 150);
            this.dgvAgendas.TabIndex = 0;
            // 
            // lblAgendaTitle
            // 
            this.lblAgendaTitle.AutoSize = true;
            this.lblAgendaTitle.Location = new System.Drawing.Point(51, 55);
            this.lblAgendaTitle.Name = "lblAgendaTitle";
            this.lblAgendaTitle.Size = new System.Drawing.Size(84, 16);
            this.lblAgendaTitle.TabIndex = 1;
            this.lblAgendaTitle.Text = "Agenda Title";
            // 
            // lblOffice
            // 
            this.lblOffice.AutoSize = true;
            this.lblOffice.Location = new System.Drawing.Point(51, 105);
            this.lblOffice.Name = "lblOffice";
            this.lblOffice.Size = new System.Drawing.Size(41, 16);
            this.lblOffice.TabIndex = 2;
            this.lblOffice.Text = "Office";
            // 
            // lblDocument
            // 
            this.lblDocument.AutoSize = true;
            this.lblDocument.Location = new System.Drawing.Point(51, 151);
            this.lblDocument.Name = "lblDocument";
            this.lblDocument.Size = new System.Drawing.Size(136, 16);
            this.lblDocument.TabIndex = 3;
            this.lblDocument.Text = "Supporting Document";
            // 
            // txtAgendaTitle
            // 
            this.txtAgendaTitle.Location = new System.Drawing.Point(190, 55);
            this.txtAgendaTitle.Name = "txtAgendaTitle";
            this.txtAgendaTitle.Size = new System.Drawing.Size(100, 22);
            this.txtAgendaTitle.TabIndex = 4;
            // 
            // txtOffice
            // 
            this.txtOffice.Location = new System.Drawing.Point(190, 102);
            this.txtOffice.Name = "txtOffice";
            this.txtOffice.Size = new System.Drawing.Size(100, 22);
            this.txtOffice.TabIndex = 5;
            // 
            // txtAgendaDescription
            // 
            this.txtAgendaDescription.Location = new System.Drawing.Point(193, 148);
            this.txtAgendaDescription.Name = "txtAgendaDescription";
            this.txtAgendaDescription.Size = new System.Drawing.Size(100, 22);
            this.txtAgendaDescription.TabIndex = 6;
            // 
            // btnAddAgenda
            // 
            this.btnAddAgenda.Location = new System.Drawing.Point(68, 203);
            this.btnAddAgenda.Name = "btnAddAgenda";
            this.btnAddAgenda.Size = new System.Drawing.Size(119, 23);
            this.btnAddAgenda.TabIndex = 7;
            this.btnAddAgenda.Text = "Add Agenda";
            this.btnAddAgenda.UseVisualStyleBackColor = true;
            this.btnAddAgenda.Click += new System.EventHandler(this.btnAddAgenda_Click);
            // 
            // btnDeleteAgenda
            // 
            this.btnDeleteAgenda.Location = new System.Drawing.Point(222, 203);
            this.btnDeleteAgenda.Name = "btnDeleteAgenda";
            this.btnDeleteAgenda.Size = new System.Drawing.Size(110, 23);
            this.btnDeleteAgenda.TabIndex = 8;
            this.btnDeleteAgenda.Text = "Delete Agenda";
            this.btnDeleteAgenda.UseVisualStyleBackColor = true;
            this.btnDeleteAgenda.Click += new System.EventHandler(this.btnDeleteAgenda_Click);
            // 
            // btnRecordings
            // 
            this.btnRecordings.Location = new System.Drawing.Point(359, 203);
            this.btnRecordings.Name = "btnRecordings";
            this.btnRecordings.Size = new System.Drawing.Size(152, 23);
            this.btnRecordings.TabIndex = 9;
            this.btnRecordings.Text = "Manage Recordings";
            this.btnRecordings.UseVisualStyleBackColor = true;
            this.btnRecordings.Click += new System.EventHandler(this.btnRecordings_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(673, 37);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // AgendaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRecordings);
            this.Controls.Add(this.btnDeleteAgenda);
            this.Controls.Add(this.btnAddAgenda);
            this.Controls.Add(this.txtAgendaDescription);
            this.Controls.Add(this.txtOffice);
            this.Controls.Add(this.txtAgendaTitle);
            this.Controls.Add(this.lblDocument);
            this.Controls.Add(this.lblOffice);
            this.Controls.Add(this.lblAgendaTitle);
            this.Controls.Add(this.dgvAgendas);
            this.Name = "AgendaForm";
            this.Text = "Agenda Form";
            this.Load += new System.EventHandler(this.AgendaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgendas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAgendas;
        private System.Windows.Forms.Label lblAgendaTitle;
        private System.Windows.Forms.Label lblOffice;
        private System.Windows.Forms.Label lblDocument;
        private System.Windows.Forms.TextBox txtAgendaTitle;
        private System.Windows.Forms.TextBox txtOffice;
        private System.Windows.Forms.TextBox txtAgendaDescription;
        private System.Windows.Forms.Button btnAddAgenda;
        private System.Windows.Forms.Button btnDeleteAgenda;
        private System.Windows.Forms.Button btnRecordings;
        private System.Windows.Forms.Button btnBack;
    }
}
