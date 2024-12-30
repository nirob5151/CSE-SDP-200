using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace WinFormsApp1
{
    // DatabaseHelper class for managing database operations
    public class DatabaseHelper
    {
        private string connectionString;

        // Constructor to initialize the connection string
        public DatabaseHelper(string connString)
        {
            connectionString = connString;
        }

        // Method to execute non-query SQL commands (e.g., INSERT)
        public void SetData(string query, List<SqlParameter> parameters)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddRange(parameters.ToArray());
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Method to fetch data (e.g., SELECT queries)
        public DataSet GetData(string query)
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    da.Fill(ds);
                }
            }
            catch (SqlException sqlEx)
            {
                // Log the exception (or show an error message, depending on your requirements)
                Console.WriteLine("Database error: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                // Log the exception (or show an error message, depending on your requirements)
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            return ds;
        }
    }

    // Form class for signing up a donor
    public partial class SING_UP : Form
    {
        private DatabaseHelper fn;

        // Constructor to initialize components and the DatabaseHelper
        public SING_UP()
        {
            InitializeComponent();
            fn = new DatabaseHelper("your_connection_string_here"); // Replace with actual connection string
        }

        // Method to handle the close button click
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Method to handle the form load event
        private void SING_UP_Load(object sender, EventArgs e)
        {
            // Query to get the maximum ID from the donor table
            string query = "SELECT MAX(did) FROM new_Donnor";

            try
            {
                using (DataSet ds = fn.GetData(query))
                {
                    // Ensure that the table exists and has rows
                    if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                    {
                        object maxId = ds.Tables[0].Rows[0][0];
                        if (maxId != DBNull.Value)
                        {
                            MessageBox.Show("Max ID: " + maxId.ToString());
                        }
                        else
                        {
                            MessageBox.Show("No data available for the maximum ID.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("The query did not return any data.");
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any other exceptions
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }


        // Method to handle the Save button click
        private void btnsave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtName.Text) &&
                !string.IsNullOrEmpty(txtFather.Text) &&
                !string.IsNullOrEmpty(txtMother.Text) &&
                !string.IsNullOrEmpty(txtDOB.Text) &&
                !string.IsNullOrEmpty(txtMobile.Text) &&
                !string.IsNullOrEmpty(txtGender.Text) &&
                !string.IsNullOrEmpty(txtEmail.Text) &&
                !string.IsNullOrEmpty(txtAddress.Text))
            {
                try
                {
                    // Collect data from form fields
                    string dname = txtName.Text;
                    string fname = txtFather.Text;
                    string mname = txtMother.Text;
                    string dob = txtDOB.Text;
                    Int64 mobile = Int64.Parse(txtMobile.Text);
                    string gender = txtGender.Text;
                    string email = txtEmail.Text;
                    string bgroup = txtBG.Text;
                    string city = txtCity.Text;
                    string address = txtAddress.Text;

                    // Parameterized query to prevent SQL injection
                    string query = "INSERT INTO new_Donnor (dname, fname, mname, dob, mobile, gender, email, bloodgroup, city, daddress) " +
                                   "VALUES (@dname, @fname, @mname, @dob, @mobile, @gender, @email, @bgroup, @city, @address)";
                    List<SqlParameter> parameters = new List<SqlParameter>
                    {
                        new SqlParameter("@dname", dname),
                        new SqlParameter("@fname", fname),
                        new SqlParameter("@mname", mname),
                        new SqlParameter("@dob", dob),
                        new SqlParameter("@mobile", mobile),
                        new SqlParameter("@gender", gender),
                        new SqlParameter("@email", email),
                        new SqlParameter("@bgroup", bgroup),
                        new SqlParameter("@city", city),
                        new SqlParameter("@address", address)
                    };

                    // Save data using DatabaseHelper
                    fn.SetData(query, parameters);
                    MessageBox.Show("Data saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please fill all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method to handle the Reset button click
        private void btnReset_Click(object sender, EventArgs e)
        {
            // Clear all text fields
            txtName.Clear();
            txtFather.Clear();
            txtMother.Clear();
            txtMobile.Clear();
            txtEmail.Clear();
            txtCity.Clear();
            txtAddress.Clear();
        }
    }
}
