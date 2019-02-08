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

namespace add_city
{
    public partial class Country_Entry : Form
    {
        public Country_Entry()
        {
            InitializeComponent();
        }

        private void btncancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        SqlConnection con = new SqlConnection(@"Data Source=RAFI51\SQLEXPRESS;Initial Catalog=country;Integrated Security=True");
        private void btnsave_Click(object sender, EventArgs e)
        {
            con.Open();
            string qu= "insert into tbl_country values('" + txtname.Text + "','" + txtabout.Text + "')";
            SqlDataAdapter da = new SqlDataAdapter(qu,con);
            da.SelectCommand.ExecuteNonQuery();
            /* SqlCommand cmd = con.CreateCommand();
             cmd.CommandType = CommandType.Text;
             cmd.CommandText = "insert into tbl_country values('" + txtname.Text + "','" + txtabout.Text + "')";
             cmd.ExecuteNonQuery();*/
            con.Close();
            dis_data();
            MessageBox.Show("Save successfully!!!...");
        }
        public void dis_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from tbl_country";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            DGVshow.DataSource = dt;
            con.Close();
        }

        private void Country_Entry_Load(object sender, EventArgs e)
        {
            dis_data();
        }
    }
}
