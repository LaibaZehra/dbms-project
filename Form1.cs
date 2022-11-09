using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace donor_detail
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            if (comboBox1.Text == "Karachi")
            {
                comboBox2.Items.Add("PECHS");
                comboBox2.Items.Add("Saddar");
                comboBox2.Items.Add("North Nazimabad");
                comboBox2.Items.Add("Gulistan e Johar");
                comboBox2.Items.Add("Korangi");
                comboBox2.Items.Add("Gulshan e Iqbal");
                comboBox2.Items.Add("Lyari");
                comboBox2.Items.Add("Nazimabad");
                comboBox2.Items.Add("Taqir Road");
                comboBox2.Items.Add("DHA");
                comboBox2.Items.Add("Defence");
            }
            else if (comboBox1.Text == "Lahore")
            {
                comboBox2.Items.Add("Ravi");
                comboBox2.Items.Add("Shalamar");
                comboBox2.Items.Add("Wagha");
                comboBox2.Items.Add("Aziz Bhatti");
                comboBox2.Items.Add("Korangi");
                comboBox2.Items.Add("Data Ganj Baksh");
                comboBox2.Items.Add("Gulberg");
                comboBox2.Items.Add("Samanabad");
                comboBox2.Items.Add("Iqbal Town");
                comboBox2.Items.Add("DHA");
                comboBox2.Items.Add("Nishtar");

            }
            else if (comboBox1.Text == "Quetta")
            {
                comboBox2.Items.Add("Tehsil Quetta City");
                comboBox2.Items.Add("Tehsil Quetta Saddar");
                comboBox2.Items.Add("Sub-Tehsil Panjpai");

            }
            else if (comboBox1.Text == "Islamabad")
            {
                comboBox2.Items.Add("DHA");
                comboBox2.Items.Add("Bahria Town");
                comboBox2.Items.Add("E-11");
                comboBox2.Items.Add("G-13");
                comboBox2.Items.Add("I-8");
                comboBox2.Items.Add("Data Ganj Baksh");
                comboBox2.Items.Add("Gulberg");
                comboBox2.Items.Add("Samanabad");
                comboBox2.Items.Add("Iqbal Town");
                comboBox2.Items.Add("DHA");
                comboBox2.Items.Add("Nishtar");

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "" || textBox5.Text == "" || textBox6.Text=="" || textBox7.Text == ""|| textBox8.Text == "")
            {
                MessageBox.Show("Please fill in all the fields.");
            }
            else
            MessageBox.Show("Your donation has been recorded. Kindly visit ______ warehouse to submit your donation.");
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
