using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace multiplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnmul_Click(object sender, EventArgs e)
        {
             int a = Convert.ToInt32(tex1.Text);
            int b = Convert.ToInt32(tex2.Text);
            int c = Convert.ToInt32(tex3.Text);
            int mul = a * b*c;
            MessageBox.Show("Multiply is: " + mul);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        }
    }

