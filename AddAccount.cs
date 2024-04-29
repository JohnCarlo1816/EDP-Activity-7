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
    public partial class AddAccount : Form
    {
        public AddAccount()
        {
            InitializeComponent();
        }

        private void PassReco_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BTL_Click(object sender, EventArgs e)
        {
            {
                Create create = new Create();
                this.Hide();
                create.Show();
            }
        }
    }
}
