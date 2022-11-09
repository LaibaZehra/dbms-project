using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class main : Form
    {
        Random rand;
        public main()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            rand = new Random();
            ngo_pic.Image = ngopictures.Images[rand.Next(0, 6)];  //showing images one by one in a random order
            aboutus.Image = uspictures.Images[rand.Next(0, 2)];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("We serve as a middle man between the ngos and donors", "About Us");
        }

        private void donate_Click(object sender, EventArgs e)
        {
            Donorlogin donor_Login = new Donorlogin();
            this.Visible = false;
            donor_Login.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void header_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void goals_Enter(object sender, EventArgs e)
        {

        }
    }
}
