using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FirstPage : Form
    {
        public FirstPage()
        {
            InitializeComponent();
        }

        // Admin Panel Button Click
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Form1 db = new Form1();
            db.Show();
            this.Hide();  // Hide current form (FirstPage)
        }

        // User Panel Button Click
        private void btnUser_Click(object sender, EventArgs e)
        {
            Form3 db = new Form3();
            db.Show();
            this.Hide();
        }

        // Dashboard Button Click
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Dashboard db = new Dashboard();
            db.Show();
            this.Hide();
        }

        // Emergency Contact Button Click
        private void txtE_Click_1(object sender, EventArgs e)
        {
            Form2 db = new Form2();
            db.Show();
            this.Hide();
        }

        // PictureBox Click (Currently empty, can be customized)
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // You can add some logic for picture click here if needed
        }
    }
}
