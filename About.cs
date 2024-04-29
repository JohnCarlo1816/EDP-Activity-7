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
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void aboutshoe_Click(object sender, EventArgs e)
        {

        }

        private void ShoeBrand_Click(object sender, EventArgs e)
        {
            {
                Brand brand = new Brand();
                this.Hide();
                brand.Show();
            }
        }

        private void LUsers_Click(object sender, EventArgs e)
        {
            {
                Users users = new Users();
                this.Hide();
                users.Show();
            }
        }

        private void DashB_Click(object sender, EventArgs e)
        {
            {
                Dashboard dashboard = new Dashboard();
                this.Hide();
                dashboard.Show();
            }
        }
    }
}
