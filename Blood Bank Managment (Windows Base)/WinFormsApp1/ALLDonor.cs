using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class ALLDonor : Form
    {
        function1 fn = new function1();
        PrintDocument printDocument = new PrintDocument();
        int currentPage = 0;
        const int pageHeight = 50; // Number of rows per page, adjust as needed

        public ALLDonor()
        {
            InitializeComponent();
            printDocument.PrintPage += PrintDocument_PrintPage; // Attach the event handler for printing
        }

        private void ALLDonor_Load(object sender, EventArgs e)
        {
            try
            {
                string query = "select * from new_Donnor";
                DataSet ds = fn.GetData(query);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog
            {
                Document = printDocument,
                Width = 800,
                Height = 600
            };

            if (printPreviewDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            try
            {
                if (dataGridView1 == null || e.Graphics == null)
                {
                    MessageBox.Show("Unable to print because of a null reference.");
                    return;
                }

                // Create a bitmap that fits the printable area
                int width = dataGridView1.Width;
                int height = dataGridView1.Height;

                // Create the bitmap based on dataGridView's size
                Bitmap bitmap = new Bitmap(width, height);

                // Draw the DataGridView content to the bitmap
                dataGridView1.DrawToBitmap(bitmap, new Rectangle(0, 0, width, height));

                // Draw the bitmap on the page
                e.Graphics.DrawImage(bitmap, 0, 0);

                // Check if there are more pages of content to print
                if (currentPage < Math.Ceiling((double)dataGridView1.RowCount / pageHeight))
                {
                    currentPage++;
                    e.HasMorePages = true;
                }
                else
                {
                    currentPage = 0; // Reset for next print job
                    e.HasMorePages = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while printing: {ex.Message}");
            }
        }
    }
}
