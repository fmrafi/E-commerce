using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_app
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "Rafi" && txtpassword.Text == "51")
            {
                MessageBox.Show("log in successfully!");
                Form1 ab = new Form1();
                ab.Show();
            }
            else
            {
                MessageBox.Show("User name/ Password is not correct");
            }
        }
    }
}
