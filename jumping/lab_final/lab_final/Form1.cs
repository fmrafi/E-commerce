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

namespace lab_final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnseacr_Click(object sender, EventArgs e)
        {
            Search sa = new Search();
            sa.Show();
        }
        SqlConnection sc = new SqlConnection(@"Data Source=RAFI51\SQLEXPRESS;Initial Catalog=test;Integrated Security=True");
        private void btnsave_Click(object sender, EventArgs e)
        {
            sc.Open();
            SqlCommand sm = sc.CreateCommand();
            sm.CommandType = CommandType.Text;
            sm.CommandText= "insert into tbl_info values('" + txtinfo1.Text + "','" + txtinfo2.Text + "'',''" + txtinfo3.Text + "'',''" + cominfo4.Text + "')";
            sm.ExecuteNonQuery();
            sc.Close();
            dis_data();
            MessageBox.Show("Save successfully!!!...");
        }
        public void dis_data()
        {
            sc.Open();
            SqlCommand sm = sc.CreateCommand();
            sm.CommandType = CommandType.Text;
            sm.CommandText = "select * from tbl_info";
            sm.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sm);
            da.Fill(dt);
            dgvshow.DataSource = dt;
            sc.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            dis_data();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //dis_data();
        }
    }
}
