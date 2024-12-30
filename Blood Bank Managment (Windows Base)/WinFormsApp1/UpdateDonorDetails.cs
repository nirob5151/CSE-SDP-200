using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class UpdateDonorDetails : Form
    {
        function1 fn = new function1(); // Database helper class

        public UpdateDonorDetails()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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
                    // Collect data
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

                    // Check if record exists
                    string checkQuery = "SELECT COUNT(*) FROM new_Donnor WHERE mobile = @mobile";
                    SqlParameter checkParam = new SqlParameter("@mobile", mobile);
                    int recordCount = fn.ExecuteScalar(checkQuery, [checkParam]);

                    if (recordCount > 0)
                    {
                        // Update existing record
                        string updateQuery = "UPDATE new_Donnor SET " +
                                             "dname = @dname, fname = @fname, mname = @mname, dob = @dob, " +
                                             "gender = @gender, email = @email, bloodgroup = @bgroup, city = @city, daddress = @address " +
                                             "WHERE mobile = @mobile";
                        List<SqlParameter> updateParams = new List<SqlParameter>
                {
                    new SqlParameter("@dname", dname),
                    new SqlParameter("@fname", fname),
                    new SqlParameter("@mname", mname),
                    new SqlParameter("@dob", dob),
                    new SqlParameter("@gender", gender),
                    new SqlParameter("@email", email),
                    new SqlParameter("@bgroup", bgroup),
                    new SqlParameter("@city", city),
                    new SqlParameter("@address", address),
                    new SqlParameter("@mobile", mobile)
                };

                        fn.SetData(updateQuery, updateParams);
                        MessageBox.Show("Record updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // Insert new record
                        string insertQuery = "INSERT INTO new_Donnor (dname, fname, mname, dob, mobile, gender, email, bloodgroup, city, daddress) " +
                                             "VALUES (@dname, @fname, @mname, @dob, @mobile, @gender, @email, @bgroup, @city, @address)";
                        List<SqlParameter> insertParams = new List<SqlParameter>
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

                        fn.SetData(insertQuery, insertParams);
                        MessageBox.Show("Record inserted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
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



        private void button1_Click(object sender, EventArgs e)
        {
            // Validate the input
            if (string.IsNullOrWhiteSpace(txtDonnorID.Text))
            {
                MessageBox.Show("Please enter a valid Donor ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Attempt to parse the donor ID
            if (!int.TryParse(txtDonnorID.Text.Trim(), out int id))
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
                    DataRow donor = ds.Tables[0].Rows[0];
                    PopulateDonorDetails(donor); // Populate the fields
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

        // Populate donor details into form fields
        private void PopulateDonorDetails(DataRow donor)
        {
            try
            {
                txtName.Text = donor["dname"].ToString();        // Donor Name
                txtFather.Text = donor["fname"].ToString();      // Father's Name
                txtMother.Text = donor["mname"].ToString();      // Mother's Name
                txtDOB.Text = donor["dob"].ToString();           // Date of Birth
                txtMobile.Text = donor["mobile"].ToString();     // Mobile Number
                txtGender.Text = donor["gender"].ToString();     // Gender
                txtEmail.Text = donor["email"].ToString();       // Email Address
                txtBG.Text = donor["bloodgroup"].ToString();     // Blood Group
                txtCity.Text = donor["city"].ToString();         // City
                txtAddress.Text = donor["daddress"].ToString();  // Address
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error populating donor details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateDonorDetails_Load(object sender, EventArgs e)
        {
            // Logic to initialize the form (if needed)
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
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
