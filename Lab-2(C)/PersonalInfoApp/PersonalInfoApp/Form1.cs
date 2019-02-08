using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalInfoApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void info()
        {
            string firstName = txt_firstName.Text;
            string lastName = txt_lastName.Text;
            string name=firstName+"''"+lastName;
            string fatherName = txt_fathersName.Text;
            string motherName = txt_mothersName.Text;
            string address = txt_address.Text;

        
        }
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("");

        }

        private void btn_name_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your Name is :" +txt_firstName.Text+"   "+txt_lastName.Text);
        }

        private void btn_sve_Click(object sender, EventArgs e)
        {
            txt_lastName.Text = "";
            txt_mothersName.Text = "";
            txt_address.Text = "";
            txt_firstName.Text = "";
            txt_fathersName.Text = "";
            MessageBox.Show("Saved successfully.....");
            string firstName = txt_firstName.Text;
            string lastName = txt_lastName.Text;
            string name = firstName + "''" + lastName;
            string fatherName = txt_fathersName.Text;
            string motherName = txt_mothersName.Text;
            string address = txt_address.Text;



        }
    }
}
