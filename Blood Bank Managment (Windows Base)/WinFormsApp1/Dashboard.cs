using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        // Search menu item click event
        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Implement search functionality here, if needed.
        }

        // Log out menu item click event
        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1(); // Assuming Form1 is the login form
            fm.Show();
            this.Hide(); // Hide the dashboard
        }

        // Add new donor menu item click event
        private void addNewDonerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewDonor and = new AddNewDonor(); // Assuming AddNewDonor is a form for adding donors
            and.Show();
        }

        // Dashboard load event
        private void Dashboard_Load(object sender, EventArgs e)
        {
            // Any initialization code can go here.
        }

        // Update donor details menu item click event
        private void updateDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateDonorDetails udd = new UpdateDonorDetails(); // Assuming UpdateDonorDetails is a form for updating donor details
            udd.Show();
            this.Hide(); // Optionally hide the dashboard while updating details
        }

        // All donor details menu item click event
        private void allDonorDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddDonorDetails add = new AddDonorDetails(); // Assuming AddDonorDetails is a form for viewing all donor details
            add.Show();
        }

        // Location menu item click event
        private void locationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchBlood sba = new SearchBlood(); // Assuming SearchBlood is a form for searching by location
            sba.Show();
        }

        private void bloodGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchDonorByBlood sd = new SearchDonorByBlood();
            sd.Show();
        }

        private void increaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockIncrease si = new StockIncrease();

            si.Show();
        }

        private void decreaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockDecrease sd = new StockDecrease();
            sd.Show();
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockDetails sk = new StockDetails(); 
            sk.Show();
        }
    }
}
