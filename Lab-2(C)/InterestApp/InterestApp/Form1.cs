using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterestApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            int time = Convert.ToInt32(txt_time.Text);
            double balance = Convert.ToDouble(txt_balance.Text);
            double interest = (balance * time * 6) / 100;
            lbl_show.Text = interest.ToString();


        }
    }
}
