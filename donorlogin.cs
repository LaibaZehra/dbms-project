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
    public partial class Donorlogin : Form
    {
        public Donorlogin()
        {
            InitializeComponent();
        }

        private void Donorlogin_Load(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            main main = new main();
            this.Visible = false;
            main.ShowDialog();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            donorpage donorpage = new donorpage();
            this.Visible = false;
            donorpage.ShowDialog();
        }
    }
}
