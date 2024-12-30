using System;
using System.Data;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class SearchBlood : Form
    {
        // Reference to the database helper class
        function1 fn = new function1();

        public SearchBlood()
        {
            InitializeComponent();
        }

        // Close the form on button click
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Load all donor data when the form loads
        private void SearchBlood_Load(object sender, EventArgs e)
        {
            LoadDonorData();
        }

        // Method to load all donor data
        private void LoadDonorData()
        {
            try
            {
                string query = "SELECT * FROM new_Donnor";
                DataSet ds = fn.GetData(query);
                dataGridView1.DataSource = ds.Tables[0]; // Bind data to DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        // Dynamically search donor data based on address or city
        /* private void txtAddress_TextChanged(object sender, EventArgs e)
         {
             try
             {
                 if (!string.IsNullOrEmpty(txtAddress.Text))
                 {
                     Parameterized query for secure dynamic search
                     string query = "SELECT * FROM newDonor WHERE city LIKE @searchText OR daddress LIKE @searchText"{
                         ;
                     }

                     DataSet ds = fn.getDataWithParameter(query, new { searchText = txtAddress.Text + "%" });
                     dataGridView1.DataSource = ds.Tables[0];
                 }
                 else
                 {
                     // Reload all data if the search field is empty
                     LoadDonorData();
                 }
             }
             catch (Exception ex)
             {
                 MessageBox.Show("Error searching data: " + ex.Message);
             }
         }
         */
    }
}
