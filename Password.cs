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
    public partial class Password : Form
    {
        public Password()
        {
            InitializeComponent();
        }

        private void Send_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult iExit;

                iExit = MessageBox.Show("The Email Has Been Sent!", "Shoe System", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (iExit == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
