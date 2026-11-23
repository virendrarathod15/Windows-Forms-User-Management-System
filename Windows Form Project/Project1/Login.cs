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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
       
        private void button1_Click(object sender, EventArgs e)
        {  
          
            string UserName = UName.Text;
            string Password = Pass.Text;

            SqlConnection con = new SqlConnection
                ("Data Source =.; Database = VirendraDB; integrated security=yes");
            con.Open();
            string query = @"SELECT COUNT(*) 
                 FROM ProjectData 
                 WHERE UserName COLLATE Latin1_General_100_CS_AS = @UserName
                 AND Password COLLATE Latin1_General_100_CS_AS = @Password";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@UserName", UserName);
            cmd.Parameters.AddWithValue("@Password", Password);

            int c = Convert.ToInt32(cmd.ExecuteScalar());
            if (c == 0)
            {
                MessageBox.Show("Invalid Username or Password");
              
            }
            else
            {
                MessageBox.Show("Login Successful");
                ViewPage obj = new ViewPage(UName.Text);
                obj.Show();
               
            }
            con.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
