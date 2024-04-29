using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;
using System.Runtime.InteropServices;

namespace ShoesSystem
{
    public partial class Users : Form
    {
        MySqlConnection sqlConn = new MySqlConnection();
        MySqlCommand sqlCmd = new MySqlCommand();
        DataTable sqlDt = new DataTable();
        String sqlQuery;
        MySqlDataAdapter DtA = new MySqlDataAdapter();
        MySqlDataReader sqlRd;

        DataSet DS = new DataSet();

        String server = "localhost";
        String username = "root";
        String password = "qwerty12345";
        String database = "shoesystem";
        public Users()
        {
            InitializeComponent();
        }

        private DataTable GetSqlDt()
        {
            return sqlDt;
        }

        private void uploadData()
        {
            sqlConn.ConnectionString = "server=" + server + ";"
                + "username =" + username + ";"
                + "password =" + password + ";"
                + "database =" + database;

            sqlConn.Open();
            sqlCmd.Connection = sqlConn;
            sqlCmd.CommandText = "select * from shoesystem.users";
            sqlRd = sqlCmd.ExecuteReader(); 
            sqlDt.Load(sqlRd);
            sqlRd.Close();
            sqlConn.Close();
            dataGridView1.DataSource = sqlDt;
        }

        private void DashB_Click(object sender, EventArgs e)
        {
            {
                Dashboard dashboard = new Dashboard();
                this.Hide();
                dashboard.Show();
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bExit_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult iExit;

                iExit = MessageBox.Show("PLEASE Confirm if you want to Exit!", "Shoe System", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (iExit == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bReset_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Control c in panel3.Controls)
                {
                    if (c is TextBox)
                    {
                        ((TextBox)c).Clear();
                    }
                }
                txtSearch.Clear();  
                txtBirth.Clear();
                txtEmail.Clear();
                txtUsername.Clear();
                txtFirstName.Clear();
                txtSurname.Clear();
                txtPass.Clear();
                cbGender.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            {
                About about = new About();
                this.Hide();
                about.Show();
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

        private void Users_Load(object sender, EventArgs e)
        {
            uploadData();
        }
        private void LogOut()
        {
            string myConnectionString = "server=localhost;uid=root;pwd=qwerty12345;database=shoesystem";

            try
            {
                // Read the username from wherever you store it
                string username = ReadUsernameFromDatabase();

                // Ensure the username is not empty
                if (string.IsNullOrWhiteSpace(username))
                {
                    MessageBox.Show("Error: Username cannot be empty.", "Error");
                    return;
                }

                using (MySqlConnection conn = new MySqlConnection(myConnectionString))
                {
                    conn.Open();

                    // Perform the logout operation by updating the "status" column to 'Inactive'
                    string logoutSql = "UPDATE users SET Status = 'Inactive' WHERE username = @Username";
                    using (MySqlCommand logoutCmd = new MySqlCommand(logoutSql, conn))
                    {
                        logoutCmd.Parameters.AddWithValue("@username", username);
                        logoutCmd.ExecuteNonQuery();
                    }

                    // Optionally, clear any user-specific data

                    // Optionally, hide or close the current form

                    MessageBox.Show("Logout successful.", "Success");

                    // Show the login form
                    Create loginFormInstance = new Create(); // Assuming the login form is named LogInForm
                    loginFormInstance.Show();
                    this.Hide();
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
            }
        }


        private string ReadUsernameFromDatabase()
        {
            string myConnectionString = "server=localhost;uid=root;pwd=qwerty12345;database=shoesystem";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(myConnectionString))
                {
                    conn.Open();

                    // Retrieve the username from the database where the status is 'active'
                    string selectUsernameSql = "SELECT Username FROM users WHERE Status = 'Active' LIMIT 1";
                    using (MySqlCommand selectUsernameCmd = new MySqlCommand(selectUsernameSql, conn))
                    {
                        object result = selectUsernameCmd.ExecuteScalar();

                        if (result != null)
                        {
                            return result.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Error: No active user found in the database.", "Error");
                            return null;
                        }
                    }
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
                return null;
            }
        }
        private void Logout_Click(object sender, EventArgs e)
        {
            LogOut();
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate input fields
                if (string.IsNullOrWhiteSpace(txtEmail.Text) ||
                    string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                    string.IsNullOrWhiteSpace(txtSurname.Text) ||
                    string.IsNullOrWhiteSpace(txtBirth.Text) || // Assuming textbirthdate is a valid date string
                    string.IsNullOrWhiteSpace(cbGender.Text) ||
                    string.IsNullOrWhiteSpace(UserName.Text) ||
                    string.IsNullOrWhiteSpace(txtPass.Text))
                {
                    MessageBox.Show("Please fill in all the required fields.", "Error");
                    return; // Stop processing if any field is empty
                }

                sqlConn.ConnectionString = "server=" + server + ";"
                    + "username=" + username + ";"
                    + "password=" + password + ";"
                    + "database=" + database;

                sqlConn.Open();

                // Corrected the SQL query and added parameter placeholders
                sqlQuery = "INSERT INTO shoesystem.users (Email, FirstName, Surname, Birthdate, Gender, Username, Password) " +
                            "VALUES (@Email, @FirstName, @Surname, @Birthdate, @Gender, @Username, @Password)";

                // Use parameters to avoid SQL injection
                sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
                sqlCmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                sqlCmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                sqlCmd.Parameters.AddWithValue("@Surname", txtSurname.Text);
                sqlCmd.Parameters.AddWithValue("@Birthdate", txtBirth.Text);
                sqlCmd.Parameters.AddWithValue("@Gender", cbGender.Text);
                sqlCmd.Parameters.AddWithValue("@UserName", UserName.Text);
                sqlCmd.Parameters.AddWithValue("@Password", txtPass.Text);

                // Use ExecuteNonQuery for INSERT queries
                int rowsAffected = sqlCmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("User added successfully.", "Success");
                }
                else
                {
                    MessageBox.Show("Failed to add user.", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
            }
            finally
            {
                sqlConn.Close();

                // Assuming uploadData is a method in the same class; if not, replace it with the correct method call
                uploadData();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtFirstName.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                txtSurname.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                txtEmail.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                txtBirth.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                txtUsername.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                txtPass.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                cbGender.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bDisplay_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConn.Open();
                sqlQuery = "select * from shoesystem.users where UserID ='" + txtDisplay.Text + "'";
                sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
                sqlRd = sqlCmd.ExecuteReader();

                if (sqlRd.Read())
                {
                    txtFirstName.Text = sqlRd.GetString("FirstName");
                    txtSurname.Text = sqlRd.GetString("Surname");
                    txtEmail.Text = sqlRd.GetString("Email");
                    txtBirth.Text = sqlRd.GetString("Birthdate");
                    txtUsername.Text = sqlRd.GetString("Username");
                    txtPass.Text = sqlRd.GetString("Password");
                    cbGender.Text = sqlRd.GetString("Gender");
                }
                    sqlConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bSearch_Click(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // Clear other controls
            txtBirth.Clear();
            txtEmail.Clear();
            txtUsername.Clear();
            txtFirstName.Clear();
            txtSurname.Clear();
            txtPass.Clear();
            cbGender.Text = "";
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConn.ConnectionString = "server=" + server + ";"
                    + "username=" + username + ";"
                    + "password=" + password + ";"
                    + "database=" + database;

                sqlConn.Open();

                // Assuming you have a user_id column in your DataGridView
                foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
                {
                    int userId = Convert.ToInt32(item.Cells["UserID"].Value); // Replace "user_id" with the actual column name

                    // Create a new MySqlCommand and set its command text
                    sqlCmd = new MySqlCommand("DELETE FROM shoesystem.users WHERE UserID = @UserID", sqlConn);

                    // Add the parameter to the command
                    sqlCmd.Parameters.AddWithValue("@UserID", userId);

                    // Execute the command
                    int rowsAffected = sqlCmd.ExecuteNonQuery();

                    // Check if the delete operation was successful
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("User deleted successfully.", "Success");

                        // Remove the row from the DataGridView
                        dataGridView1.Rows.RemoveAt(item.Index);
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete user.", "Error");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
            }
            finally
            {
                sqlConn.Close();
            }
        }

        private void bUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate input fields
                if (string.IsNullOrWhiteSpace(txtEmail.Text) ||
                    string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                    string.IsNullOrWhiteSpace(txtSurname.Text) ||
                    string.IsNullOrWhiteSpace(txtBirth.Text) ||
                    string.IsNullOrWhiteSpace(cbGender.Text) ||
                    string.IsNullOrWhiteSpace(txtUsername.Text) ||
                    string.IsNullOrWhiteSpace(txtPass.Text))
                {
                    MessageBox.Show("Please fill in all the required fields.", "Error");
                    return; // Stop processing if any field is empty
                }

                using (MySqlConnection sqlConn = new MySqlConnection())
                {
                    sqlConn.ConnectionString = "server=" + server + ";"
                        + "username=" + username + ";"  // Corrected the keyword to 'user' for specifying the username
                        + "password=" + password + ";"
                        + "database=" + database;

                    sqlConn.Open();

                    // Corrected the SQL query for UPDATE
                    string sqlQuery = "UPDATE shoesystem.users SET " +
                                      "email = @Email, " +
                                      "firstname = @Firstname, " +
                                      "surname = @Surname, " +
                                      "birthdate = @Birthdate, " +
                                      "gender = @Gender, " +
                                      "password = @Password " +
                                      "WHERE username = @Username";

                    // Use parameters to avoid SQL injection
                    using (MySqlCommand sqlCmd = new MySqlCommand(sqlQuery, sqlConn))
                    {
                        sqlCmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                        sqlCmd.Parameters.AddWithValue("@Firstname", txtFirstName.Text);
                        sqlCmd.Parameters.AddWithValue("@Surname", txtSurname.Text);
                        sqlCmd.Parameters.AddWithValue("@Birthdate", txtBirth.Text);
                        sqlCmd.Parameters.AddWithValue("@Gender", cbGender.Text);
                        sqlCmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                        sqlCmd.Parameters.AddWithValue("@Password", txtPass.Text);

                        // Use ExecuteNonQuery for UPDATE queries
                        int rowsAffected = sqlCmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User's profile updated successfully.", "Success");
                        }
                        else
                        {
                            MessageBox.Show("Failed to update data.", "Error");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
            }
            finally
            {
                sqlConn.Close();
                uploadData();
            }
        }

        

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Export_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a new Excel application
                Excel.Application excelApp = new Excel.Application();
                excelApp.Visible = false; // Optional: Set to true to make Excel visible

                // Open the Excel template file
                string templatePath = "E:\\Exported Files\\UserInventory.xlsx"; // Change this to the path of your Excel template file
                Excel.Workbook workbook = excelApp.Workbooks.Open(templatePath);
                Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Sheets[1]; // Assuming data goes into the first worksheet

                // Populate Excel template with DataGridView data
                int row = 12; // Start from the second row (assuming the first row is for headers)
                foreach (DataGridViewRow dgvRow in dataGridView1.Rows)
                {
                    worksheet.Cells[row, 5] = dgvRow.Cells["UserID"].Value;
                    worksheet.Cells[row, 6] = dgvRow.Cells["Firstname"].Value;
                    worksheet.Cells[row, 7] = dgvRow.Cells["Surname"].Value;
                    worksheet.Cells[row, 8] = dgvRow.Cells["Email"].Value;
                    worksheet.Cells[row, 9] = dgvRow.Cells["Birthdate"].Value;
                    worksheet.Cells[row, 10] = dgvRow.Cells["Username"].Value;
                    worksheet.Cells[row, 11] = dgvRow.Cells["Password"].Value;
                    worksheet.Cells[row, 12] = dgvRow.Cells["Gender"].Value;
                    worksheet.Cells[row, 13] = dgvRow.Cells["Status"].Value;
                    row++;
                }

                // Save the modified Excel file as a new file
                string outputPath = "E:\\Exported Files\\UserInventory_Output.xlsx"; // Change this to the desired output path
                workbook.SaveAs(outputPath);

                // Close Excel workbook and application
                workbook.Close();
                excelApp.Quit();

                MessageBox.Show("Excel file exported successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error exporting data to Excel: " + ex.Message);
            }
        }

        private void ExportDetails_Click(object sender, EventArgs e)
        {

        }

        private void ExportProd_Click(object sender, EventArgs e)
        {

        }

        private void OrderD_Click(object sender, EventArgs e)
        {
            {
                OrderDetails orderdetails = new OrderDetails();
                this.Hide();
                orderdetails.Show();
            }
        }

        private void Products_Click(object sender, EventArgs e)
        {
            {
                ProductInventory productInventory = new ProductInventory();
                this.Hide();
                productInventory.Show();
            }
        }
    }
    }
    

