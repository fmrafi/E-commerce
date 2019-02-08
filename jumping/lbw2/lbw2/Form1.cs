using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lbw2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void info()
        {
            string n = txt1st.Text;
            string last = txtlast.Text;
            string full = n + "''" + last;
            string father = txtfather.Text;
            string M = txtmother.Text;
            string A = txtadd.Text;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            txt1st.Text = "";
            txtlast.Text = "";
            txtfather.Text = "";
            txtmother.Text = "";
            MessageBox.Show("Save is succesfull");
            string n = txt1st.Text;
            string last = txtlast.Text;
            string full = n + "''" + last;
            string father = txtfather.Text;
            string M = txtmother.Text;
            string A = txtadd.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("MY Name Is :"+ txt1st.Text + " " + txtlast.Text);
        }
    }
}
