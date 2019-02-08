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
    public partial class View_country : Form
    {
        public View_country()
        {
            InitializeComponent();
        }
        SqlConnection sc = new SqlConnection(@"Data Source=RAFI51\SQLEXPRESS;Initial Catalog=country;Integrated Security=True");
        private void btnsearch_Click(object sender, EventArgs e)
        {
            sc.Open();
            SqlCommand cm = sc.CreateCommand();
            cm.CommandType = CommandType.Text;
            cm.CommandText = "select * from tbl_country where Name='"+txtname.Text+"'";
            cm.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(dt);
            DGVsearch.DataSource = dt;
            sc.Close();
        }
    }
}
