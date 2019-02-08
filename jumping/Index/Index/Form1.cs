using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Index
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnadd_book_Click(object sender, EventArgs e)
        {
            AddBook add = new AddBook();
            add.Show();
        }

        private void btnshow_book_Click(object sender, EventArgs e)
        {
            Show ss = new Show();
            ss.Show();

    }
    }
}
