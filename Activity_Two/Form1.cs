using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void WishList_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = WishList.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WishList.Sorted = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WishList.Items.Add("ASUS TUF GAMING LAPTOP");
            WishList.Items.Add("Mustang");
            WishList.Items.Add("Iphone 14 Pro max");
            WishList.Items.Add("House");
            WishList.Items.Add("Beach House");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WishList.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Text = Convert.ToString(WishList.Items.Count);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
