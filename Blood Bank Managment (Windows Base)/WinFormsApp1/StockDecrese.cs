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

namespace WinFormsApp1
{
    public partial class StockDecrese : Form
    {
        function1 fn = new function1();
        string query;

        public StockDecrese()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StockDecrese_Load(object sender, EventArgs? e)
        {
            query = "select * form blood_group, quantity from stock";
            DataSet ds = fn.GetData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            query = "update stock set quantity quantity " + txtUnits.Text + " where blood_group=" + "txtBloodGroup.Text + ";
            fn.setDate(query); 
            StockDecrese_Load(this, null);
        }
    }
}
