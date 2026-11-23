using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class ViewPage : Form
    {
        public string user;
        public ViewPage()
        {
            InitializeComponent();
        }
        public ViewPage(string a)
        {
            user = a;

            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection
               ("Data Source =.; Database = VirendraDB; integrated security=yes");
            string query = "Select * from ProjectData where UserName = @UserName";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@UserName", user);
            DataSet ds = new DataSet();
            da.Fill(ds, "ProjectData");
            dataGridView1.DataSource = ds.Tables["ProjectData"];
        }

       // Form5 obj = new Form5();
        private void button1_Click(object sender, EventArgs e)
        {
            Form5 obj = new Form5(user);
            obj.Show();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
