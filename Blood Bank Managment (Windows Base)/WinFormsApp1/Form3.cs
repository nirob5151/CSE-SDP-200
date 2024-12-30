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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnadmin_Click(object sender, EventArgs e)
        {
            AddNewDonor db = new AddNewDonor();
            db.Show();
            this.Hide();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {

            ALLDonor db = new ALLDonor();
            db.Show();
            this.Hide();
        }
    }
}
