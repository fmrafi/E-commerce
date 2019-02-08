using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ATM_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void clear()
        {
            string username = txtuser.Text;
            string pin = txtpin.Text;
        }

        private void btnabout_Click(object sender, EventArgs e)
        {
           
                rafi ab = new rafi();
                ab.Show();
            
        }

        private void btnadmin_Click(object sender, EventArgs e)
        {
            admin A = new admin();
            A.Show();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtuser.Text = "";
            txtpin.Text = "";
            MessageBox.Show("Clear");
            string username = txtuser.Text;
            string pin = txtpin.Text;
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            /*if (txtuser.Text == "Rafi" && txtpin.Text == "51")
            {
                MessageBox.Show("log in successfully!");
                ok ab = new ok();
                ab.Show();
            }
            else
            {
                MessageBox.Show("User name/ Password is not correct");
            }*/
            SqlConnection conn = new SqlConnection("Data Source = RAFI51\\SQLEXPRESS; Initial Catalog = test; Integrated Security = True");
            conn.Open();
            conn.Close();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from login",conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows[0][0]=="1")
            {
                MessageBox.Show("Database login successfull...!!!");
            }
            else
            {
                MessageBox.Show("Check your database connection... error!!!");
            }
        }

        private void time_Tick(object sender, EventArgs e)
        {

        }

        private void btntime_Click(object sender, EventArgs e)
        {
            
        }

        private void txtpin_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //txtpin.Text = "1234";
        }

        private void txtpin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
