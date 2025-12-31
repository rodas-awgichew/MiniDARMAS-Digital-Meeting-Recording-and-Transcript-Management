using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;


namespace MiniDARMAS
{
    public partial class FinalDocumentForm : Form
    {
        public FinalDocumentForm(string transcriptionText)
        {
            InitializeComponent();
            richTextBox1.Text = transcriptionText;
        }



        private void btnExportTxt_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text Files|*.txt";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText(
      sfd.FileName,
      richTextBox1.Text
  );
                ;
            }
        }


        private void btnExportRtf_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Rich Text Files|*.rtf";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(sfd.FileName);
                MessageBox.Show("RTF exported successfully.");
            }
        }


        private void btnExportpdf_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF Files|*.pdf";

            if (sfd.ShowDialog() != DialogResult.OK)
                return;

            using (FileStream fs = new FileStream(
                sfd.FileName, FileMode.Create, FileAccess.Write))
            {
                Document doc = new Document(PageSize.A4, 40, 40, 40, 40);
                PdfWriter.GetInstance(doc, fs);

                doc.Open();

                // Font
                iTextSharp.text.Font font = FontFactory.GetFont(
                    FontFactory.HELVETICA, 11);

                Paragraph content = new Paragraph(
                    richTextBox1.Text, font);

                content.Alignment = Element.ALIGN_LEFT;

                doc.Add(content);
                doc.Close();
            }

            MessageBox.Show("PDF exported successfully.");
        }


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
