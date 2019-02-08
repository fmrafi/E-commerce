using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtshow.Text = "";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtshow.Text = "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtshow.Text = "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtshow.Text = "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtshow.Text = "4";
        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            txtshow.Text = "+";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtshow.Text = "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtshow.Text = "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtshow.Text = "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtshow.Text = "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtshow.Text = "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtshow.Text = "0";
        }

        private void btndot_Click(object sender, EventArgs e)
        {
            txtshow.Text = ".";
        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtshow.Text);
            float b = Convert.ToInt32(txtshow.Text);
            float sum = a + b;
            txtshow.Text = sum.ToString();
        }
    }
}
