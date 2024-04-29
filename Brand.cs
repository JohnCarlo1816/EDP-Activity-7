using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoesSystem
{
    public partial class Brand : Form
    {
        public Brand()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void OrderD_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {
            {
                Users users = new Users();
                this.Hide();
                users.Show();
            }
        }

        private void ShoeBrand_Click(object sender, EventArgs e)
        {

        }

        private void DashB_Click(object sender, EventArgs e)
        {
            {
                Dashboard dashboard = new Dashboard();
                this.Hide();
                dashboard.Show();
            }
        }

        private void label17_Click(object sender, EventArgs e)
        {
            {
                About about = new About();
                this.Hide();
                about.Show();
            }
        }
    }
}
