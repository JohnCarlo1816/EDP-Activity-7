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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void OrderD_Click(object sender, EventArgs e)
        {
            {
                OrderDetails users = new OrderDetails();
                this.Hide();
                users.Show();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void DashB_Click(object sender, EventArgs e)
        {

        }

        private void UserName_Click(object sender, EventArgs e)
        {

        }

        private void Logout_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            {
                Users users = new Users();
                this.Hide();
                users.Show();
            }
        }

        private void ShoeBrand_Click(object sender, EventArgs e)
        {
            {
                Brand brand = new Brand();
                this.Hide();
                brand.Show();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            {
                About about = new About();
                this.Hide();
                about.Show();
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void Products_Click(object sender, EventArgs e)
        {
            {
                ProductInventory about = new ProductInventory();
                this.Hide();
                about.Show();
            }
        }
    }
}
