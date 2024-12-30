using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace WinFormsApp1
{
    class function1
    {
        // Centralized connection string
        private const string ConnectionString = "Server=DESKTOP-NCIF9UT\\SQLEXPRESS;Database=blood_bank;Trusted_Connection=True;TrustServerCertificate=True;";

        protected SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }

        // Parameterized GetData Method
        public DataSet GetData(string query, List<SqlParameter>? parameters = null)
        {
            DataSet ds = new DataSet();

            try
            {
                using (SqlConnection con = GetConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        if (parameters != null)
                        {
                            cmd.Parameters.AddRange(parameters.ToArray());
                        }

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(ds);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return ds;
        }

        // Non-query execution with parameters
        public bool SetData(string query, List<SqlParameter>? parameters = null)
        {
            try
            {
                using (SqlConnection con = GetConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        if (parameters != null)
                        {
                            cmd.Parameters.AddRange(parameters.ToArray());
                        }

                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                return true; // Success
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; // Failure
            }
        }

        internal DataSet getDataWithParameter(Parameterized query, object value)
        {
            throw new NotImplementedException();
        }

        internal void setDate(string query)
        {
            throw new NotImplementedException();
        }

        internal int ExecuteScalar(string checkQuery, List<SqlParameter> sqlParameters)
        {
            int result = 0;
            string connectionString = "Your_Connection_String_Here"; // Replace with your actual connection string

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(checkQuery, connection))
                {
                    // Add parameters to the command
                    if (sqlParameters != null)
                    {
                        command.Parameters.AddRange(sqlParameters.ToArray());
                    }

                    try
                    {
                        connection.Open();
                        object scalarResult = command.ExecuteScalar();

                        if (scalarResult != null && scalarResult != DBNull.Value)
                        {
                            result = Convert.ToInt32(scalarResult);
                        }
                    }
                    catch (Exception ex)
                    {
                        // Log or handle exceptions as needed
                        throw new Exception("Error executing scalar query: " + ex.Message);
                    }
                }
            }

            return result;
        }

    }

    internal class Parameterized
    {

    }
}
