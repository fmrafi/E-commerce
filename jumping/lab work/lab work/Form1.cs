using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_work
{
    public partial class homepage : Form
    {
        public homepage()
        {
            InitializeComponent();
        }

        private void btnlog_Click(object sender, EventArgs e)
        {
            if(txtuser.Text=="mm" && txtpass.Text=="123")
            {
                MessageBox.Show("log in successfully!");
                MainFrom ab = new MainFrom();
                ab.Show();
            }
            else
            {
                MessageBox.Show("User name/ Password is not correct");
            }
        }
    }
}
