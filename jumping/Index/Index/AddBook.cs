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

namespace Index
{
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
        }
        SqlConnection sc = new SqlConnection(@"Data Source=RAFI51\SQLEXPRESS;Initial Catalog=save;Integrated Security=True");
        private void btnsave_Click(object sender, EventArgs e)
        {
            
            sc.Open();
            string query = "insert into tbl_insertion values('" + txtname.Text + "','" + txtISBN.Text + "','" + txtauthor.Text + "')";
            SqlDataAdapter sda = new SqlDataAdapter(query, sc);
            sda.SelectCommand.ExecuteNonQuery();
            sc.Close();
            MessageBox.Show("Save successfully...!!!!");
            
        }
    }
}
