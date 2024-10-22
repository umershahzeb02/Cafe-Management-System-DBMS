using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbProj
{
    public partial class mostOrderedForm : Form
    {
        private string connectionString = "Data Source= DESKTOP-BCLJSMJ\\SQLEXPRESS ;" +
        "Database= campusbites;" +
        "Integrated Security = True;";
        public mostOrderedForm()
        {
            InitializeComponent();
            PopulateDataGridView();
        }
        private void PopulateDataGridView()
        {
            // Connection string (replace with your actual connection string)
            //string connectionString = "Your_Connection_String_Here";

            // SQL query to fetch data
            string query = @"
                SELECT 
                    i.inventID,
                    i.inventName,
                    i.quantity AS availableQuantity,
                    SUM(oi.quantity) AS totalOrderedQuantity
                FROM 
                    inventory i
                JOIN 
                    orderItem oi ON i.inventID = oi.itemID
                GROUP BY 
                    i.inventID, i.inventName, i.quantity;
            ";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);

                    DataTable dataTable = new DataTable();

                    dataAdapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
