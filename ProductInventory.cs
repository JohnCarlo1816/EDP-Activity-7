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
    public partial class ProductInventory : Form
    {
        public ProductInventory()
        {
            InitializeComponent();
            LoadDataIntoDataGridView();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ExportProd_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    // Create a new Excel application
                    Excel.Application excelApp = new Excel.Application();
                    excelApp.Visible = false; // Optional: Set to true to make Excel visible

                    // Open the Excel template file
                    string templatePath = "E:\\Exported Files\\ProductInventory.xlsx"; // Change this to the path of your Excel template file
                    Excel.Workbook workbook = excelApp.Workbooks.Open(templatePath);
                    Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Sheets[1]; // Assuming data goes into the first worksheet

                    // Populate Excel template with DataGridView data
                    int row = 11; // Start from the second row (assuming the first row is for headers)
                    foreach (DataGridViewRow dgvRow in dataGridView2.Rows)
                    {
                        worksheet.Cells[row, 3] = dgvRow.Cells["ProductID"].Value;
                        worksheet.Cells[row, 4] = dgvRow.Cells["ProductName"].Value;
                        worksheet.Cells[row, 5] = dgvRow.Cells["Brand"].Value;
                        worksheet.Cells[row, 6] = dgvRow.Cells["Size"].Value;
                        worksheet.Cells[row, 7] = dgvRow.Cells["Price"].Value;
                        worksheet.Cells[row, 8] = dgvRow.Cells["ProductQuantity"].Value;
                        worksheet.Cells[row, 9] = dgvRow.Cells["Status"].Value;

                        row++;
                    }

                    // Save the modified Excel file as a new file
                    string outputPath = "E:\\Exported Files\\ProductInventory_Output.xlsx"; // Change this to the desired output path
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
        }
        private void LoadDataIntoDataGridView()
        {
            MySql.Data.MySqlClient.MySqlConnection conn = null;
            string myConnectionString;
            myConnectionString = "server=localhost;uid=root;" +
                "pwd=qwerty12345;database=shoesystem";

            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
                conn.Open();

                string sql = "SELECT * FROM products";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                // Changed this line to combine both queries into one command
                cmd.CommandText = sql + ";";

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);

                // Assuming the tables in the DataSet are named "Table1" and "Table2" respectively
                dataGridView2.DataSource = dataSet.Tables[0]; // product
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

        }

        private void returnbtn_Click(object sender, EventArgs e)
        {
            {
                Dashboard about = new Dashboard();
                this.Hide();
                about.Show();
            }
        }
    }
}
