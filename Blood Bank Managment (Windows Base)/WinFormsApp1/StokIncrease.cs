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
    public partial class StokIncrease : Form
    {
        function1 fn = new function1();
        private string? query;

        private void StokIncrease_Load(object sender, EventArgs? e)
        {
            query = "select * form blood_group , quantity from stock";
            DataSet ds = fn.GetData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            query = "update stock set quantity-quantity+ fn.setDate(query); + txtUnits. Text + where blood group + txtBloodGroup. Text + ";
            fn.SetData(query);
            StokIncrease_Load(this,null);


        }
    }
}
