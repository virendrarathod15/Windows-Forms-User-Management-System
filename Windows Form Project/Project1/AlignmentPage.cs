using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Project1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        public string UserName;

        public Form5(string username)
        {
            InitializeComponent();

            UserName = username;
            t1.Text = UserName;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                t1.TextAlign = HorizontalAlignment.Left;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                t1.TextAlign = HorizontalAlignment.Center;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                t1.TextAlign = HorizontalAlignment.Right;
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (blue.Checked)
            {
                t1.ForeColor = Color.Blue;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (red.Checked)
            {
                t1.ForeColor = Color.Red;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (yellow.Checked)
            {
                t1.ForeColor = Color.Yellow;
            }
        }

        private void vheyr_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
