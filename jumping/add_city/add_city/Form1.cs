using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace add_city
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncountry_Click(object sender, EventArgs e)
        {
            Country_Entry ce = new Country_Entry();
            ce.Show();
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            View_country vc = new View_country();
            vc.Show();
        }
    }
}
