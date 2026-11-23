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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Random random = new Random();
            int UserId = random.Next(100000, 999999);

            id.Text = UserId.ToString();

        }
        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
        LoginPage obj = new LoginPage();

        public object UserName { get; private set; }

        private void button1_Click(object sender, EventArgs e)
        {
            obj.Show();

            int Userid = Convert.ToInt32(id.Text);
            string UserName = UName.Text;

            string FirstName = FName.Text;
            string LastName = LName.Text;

            string Gender = "";
            if (radioButton1.Checked)
            {
                Gender = "Male";
            }
            else if (radioButton2.Checked)
            {
                Gender = "Female";
            }
            else if (radioButton3.Checked)
            {
                Gender = "Other";
            }

            int Age = Convert.ToInt32(Agee.Text);

            string Email = Mail.Text;
            string Phone = Phonee.Text;

            string Address = Add.Text;
            string Country = comboBox1.Text;

            string Language = "";
            if (checkBox1.Checked)
            {
                Language += "English, ";
            }
            if (checkBox2.Checked)
            {
                Language += "Hindi, ";
            }
            if (checkBox3.Checked)
            {
                Language += "Marathi,  ";
            }

            string Password = Pass.Text;
            string ConfirmPassword = CPass.Text;

            SqlConnection con = new SqlConnection
                ("Data Source =.; Database = VirendraDB; integrated security=yes");

            con.Open();
            string query = "Insert Into ProjectData Values(@Userid, @UserName, @FirstName, @LastName, @Gender, @Age,@Address,@Email,@Phone, @Password, @ConfirmPassword,@Language,@Country)";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@Userid", Userid);
            cmd.Parameters.AddWithValue("@UserName", UserName);
            cmd.Parameters.AddWithValue("@FirstName", FirstName);
            cmd.Parameters.AddWithValue("@LastName", LastName);
            cmd.Parameters.AddWithValue("@Gender", Gender);
            cmd.Parameters.AddWithValue("@Age", Age);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@Phone", Phone);
            cmd.Parameters.AddWithValue("@Address", Address);
            cmd.Parameters.AddWithValue("@Country", Country);
            cmd.Parameters.AddWithValue("@Language", Language);
            cmd.Parameters.AddWithValue("@Password", Password);
            cmd.Parameters.AddWithValue("@ConfirmPassword", ConfirmPassword);

            cmd.ExecuteNonQuery();
            con.Close();

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dictionary<string, string> codes = new Dictionary<string, string>()
    {
        {"India", "+91"},
        {"USA", "+1"},
        {"UK", "+44"},
        {"Australia", "+61"},
        {"Canada", "+1"},
        {"UAE", "+971"},
        {"Germany", "+49"},
        {"France", "+33"},
        {"Japan", "+81"},
        {"China", "+86"},
        {"Brazil", "+55"},
        {"Mexico", "+52"},
        {"Singapore", "+65"},
        {"Saudi Arabia", "+966"},
        {"South Africa", "+27"},
        {"Italy", "+39"},
        {"Spain", "+34"},
        {"South Korea", "+82"},
        {"Pakistan", "+92"},
        {"Bangladesh", "+880"}
    };

            if (codes.ContainsKey(comboBox1.Text))
            {
                    Phonee.Text = codes[comboBox1.Text] + " ";
                Phonee.SelectionStart = Phonee.Text.Length;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
