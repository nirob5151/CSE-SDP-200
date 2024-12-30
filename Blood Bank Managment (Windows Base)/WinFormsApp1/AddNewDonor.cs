using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class AddNewDonor : Form
    {
        function1 fn = new function1();
        public AddNewDonor()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        /* private void AddNewDonor_Load(object sender, EventArgs e)
         {
             // Query to get the maximum ID
             string query = "select max(did) from new_Donnor";
             DataSet ds = fn.GetData(query);

             // Check if the result is NULL or empty
             object maxIdValue = ds.Tables[10].Rows[5][5];

             int count = 0; // Default value in case of NULL or empty result
             if (maxIdValue != DBNull.Value && maxIdValue != null)
             {
                 // Attempt to parse the value
                 if (!int.TryParse(maxIdValue.ToString(), out count))
                 {
                     MessageBox.Show("Failed to parse the maximum ID.");
                     return; // Exit early if parsing fails
                 }
             }

             // Increment the ID and display it
             labelNewID.Text = (count + 1).ToString();
         }
        */



        private void AddNewDonor_Load(object sender, EventArgs e)
        {
            try
            {
                // Query to get the maximum ID
                string query = "SELECT MAX(did) FROM new_Donnor";
                DataSet ds = fn.GetData(query);

                int maxId = 0; // Default value
                if (ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0][0] != DBNull.Value)
                {
                    maxId = Convert.ToInt32(ds.Tables[0].Rows[0][0]); // Retrieve the first column of the first row
                }

                // Increment the ID and display it
                labelNewID.Text = (maxId + 1).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading donor data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /*
                private void btnsave_Click(object sender, EventArgs e)
                {
                    // Check if any of the fields are empty or null
                    if (!string.IsNullOrEmpty(txtName.Text) &&
                        !string.IsNullOrEmpty(txtFather.Text) &&
                        !string.IsNullOrEmpty(txtMother.Text) &&
                        !string.IsNullOrEmpty(txtDOB.Text) &&
                        !string.IsNullOrEmpty(txtMobile.Text) &&
                        !string.IsNullOrEmpty(txtGender.Text) &&
                        !string.IsNullOrEmpty(txtEmail.Text) &&
                        !string.IsNullOrEmpty(txtAddress.Text))
                    {
                        // All fields are filled, proceed with saving data
                        // Your saving logic goes here
                        string dname = txtName.Text;
                        string fname = txtFather.Text;
                        string mname = txtMother.Text;
                        string dob   = txtDOB.Text;
                        Int64 mobile = Int64.Parse(txtMobile.Text);

                        string gender = txtGender.Text;

                        string email = txtEmail.Text;


                        string bgroup = txtBG.Text;
                        string city = txtCity.Text; 
                        string address = txtAddress.Text;
                        string query = "insert into new_Donnor (dname,fname,mname,dob,mobile,gender,email,bloodgroup,city,daddress) values ('" + dname + "','" + fname + "','" + dob + "','" + mname + "','"+mobile+"','"+email+"','"+bgroup+ "','"+city+"','"+address+"')";
                        fn.setData(query);



                        MessageBox.Show("Data saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // If any field is empty, show an error message
                        MessageBox.Show("Please fill all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
        */
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

