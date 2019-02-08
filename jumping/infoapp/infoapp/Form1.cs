using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace infoapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void info()
        {
            string firstName = txt1stname.Text;
            string lastName = txtlast.Text;
            string name = firstName + "''" + lastName;
            string fatherName = txtfather.Text;
            string motherName = txtmother.Text;
            string address = txtaddress.Text;
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            txtlast.Text = "";
            txtmother.Text = "";
            txtaddress.Text = "";
            txt1stname.Text = "";
            txtfather.Text = "";
            MessageBox.Show("Saved successfully.....");
            string firstName = txt1stname.Text;
            string lastName = txtlast.Text;
            string name = firstName + "''" + lastName;
            string fatherName = txtfather.Text;
            string motherName = txtmother.Text;
            string address = txtaddress.Text;
        }

        private void btnname_Click(object sender, EventArgs e)
        {
            MessageBox.Show("My Name is :" + txt1stname.Text + "   " + txtlast.Text);
        }

        private void btnpname_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Father Name is :" + txtfather.Text +"       "  +    "Mother Name is: " + txtmother.Text);

        }

        private void btnaddress_Click(object sender, EventArgs e)
        {
            MessageBox.Show("My Address is :" + txtaddress.Text);
        }

        private void btninfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("First Name :" + txt1stname.Text + "   " + "Last Name :" + txtlast.Text + "   " + "Father Name :" + txtfather.Text + "   " + "Mother Name :" + txtmother.Text + "   " + "Adress :" + txtaddress.Text);

        }
    }
}
