using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WinFormsApp1
{
    public partial class SearchDonorByBlood : Form
    {
        function1 fn = new function1();
        public SearchDonorByBlood()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SearchDonorByBlood_Load(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM new_Donnor";
                DataSet ds = fn.GetData(query);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Validate the input
            if (string.IsNullOrWhiteSpace(txtDonnorID2.Text))
            {
                MessageBox.Show("Please enter a valid Donor ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Attempt to parse the donor ID
            if (!int.TryParse(txtDonnorID2.Text.Trim(), out int id))
            {
                MessageBox.Show("Donor ID must be a numeric value.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Prepare the query
            string query = "SELECT * FROM new_Donnor WHERE did = @id;";
            var parameters = new List<SqlParameter>
            {
                new SqlParameter("@id", id)
            };

            try
            {
                // Execute the query
                DataSet ds = fn.GetData(query, parameters);

                // Check if the query returned any results
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    DataRow donnor = ds.Tables[0].Rows[0];
                    PopulateDonorDetails(donnor); // Populate the fields
                }
                else
                {
                    MessageBox.Show("No donor found with the provided ID.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Log or handle unexpected errors
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
    }

        private void PopulateDonorDetails(DataRow donnor)
        {
        
            try
            {
                //txtName.Text = donnor["dname"].ToString();        // Donor Nam
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error populating donor details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
    
    }
    }
}
