using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ShoesSystem
{
    public partial class Create : Form
    {
        public Create()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void Title_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            {
                AddAccount addaccount = new AddAccount();
                this.Hide();
                addaccount.Show();
            }
        }

        private void PassRecovery_Click(object sender, EventArgs e)
        {
            {
                Password password = new Password();
                this.Hide();
                password.Show();
            }
        }

        private void bLogin_Click_1(object sender, EventArgs e)
        {
            string username = this.username.Text;
            string password = this.password.Text;
            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString;
            myConnectionString = "server=localhost;uid=root;" +
            "pwd=qwerty12345;database=shoesystem";
            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection();
                conn.ConnectionString = myConnectionString;
                conn.Open();

                string selectSql = "SELECT COUNT(*) from users where Username = @Username AND Password = @Password";
                MySqlCommand selectCmd = new MySqlCommand(selectSql, conn);
                selectCmd.Parameters.AddWithValue("@Username", username);
                selectCmd.Parameters.AddWithValue("@Password", password);

                int count = Convert.ToInt32(selectCmd.ExecuteScalar());

                if (count > 0)
                {
                    // Update active_status to indicate that the user is logged in
                    string updateSql = "UPDATE users SET Status = 'Active' WHERE Username = @Username";
                    MySqlCommand updateCmd = new MySqlCommand(updateSql, conn);
                    updateCmd.Parameters.AddWithValue("@Username", username);
                    updateCmd.ExecuteNonQuery();

                    // MessageBox.Show("You are now logged in");
                    var home = new Dashboard();
                    this.Hide();
                    home.Show();
                }
                else
                {
                    MessageBox.Show("Invalid username/password");
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
