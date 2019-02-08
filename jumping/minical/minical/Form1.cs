using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace minical
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txt1st.Text);
            int b = Convert.ToInt32(txt2nd.Text);
            int sum = a + b;
            // MessageBox.Show("Summation is :" + sum);
            txtout.Text = sum.ToString();
        }

        private void btnsub_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txt1st.Text);
            int b = Convert.ToInt32(txt2nd.Text);
            int sub = a - b;
            //MessageBox.Show("Subtraction is :" + sub);
            txtout.Text = sub.ToString();
        }

        private void btnmul_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txt1st.Text);
            int b = Convert.ToInt32(txt2nd.Text);
            int mul = a * b;
            //MessageBox.Show("Multipication is :" + mul);
            txtout.Text = mul.ToString();
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            float a = Convert.ToInt32(txt1st.Text);
            float b = Convert.ToInt32(txt2nd.Text);
            float div = a / b;
            // MessageBox.Show("Division is :" + div);
            txtout.Text = div.ToString();
        }
    }
}
