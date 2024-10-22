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
    public partial class SalesAndRev : Form
    {
        private string connectionString = "Data Source= DESKTOP-BCLJSMJ\\SQLEXPRESS ;" +
        "Database= campusbites;" +
        "Integrated Security = True;";
        public SalesAndRev()
        {
            InitializeComponent();
            PopulateDataGridView1();
        }

        private void SalesAndRev_Load(object sender, EventArgs e)
        {

        }

        private void PopulateDataGridView1()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandType = CommandType.Text;

                        // SQL SELECT statement to retrieve data based on the provided query
                        command.CommandText = @"
                    SELECT 
                        orders.orderID,
                        orderDate,
                        orderStatus,
                        SUM(orderPrice) AS totalOrderPrice
                    FROM orders
                    LEFT JOIN transactions ON orders.orderID = transactions.orderID
                    GROUP BY orders.orderID, orderDate, orderStatus
                ";

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Clear existing columns and rows in DataGridView1
                            dataGridView1.Columns.Clear();
                            dataGridView1.Rows.Clear();

                            // Check if the SqlDataReader has rows
                            if (reader.HasRows)
                            {
                                // Add columns to DataGridView1
                                dataGridView1.Columns.Add("orderID", "Order ID");
                                dataGridView1.Columns.Add("orderDate", "Order Date");
                                dataGridView1.Columns.Add("orderStatus", "Order Status");
                                dataGridView1.Columns.Add("totalOrderPrice", "Total Order Price");

                                // Iterate through the SqlDataReader and add rows to DataGridView1
                                while (reader.Read())
                                {
                                    string orderID = reader["orderID"].ToString();
                                    string orderDate = reader["orderDate"].ToString();
                                    string orderStatus = reader["orderStatus"].ToString();
                                    string totalOrderPrice = reader["totalOrderPrice"].ToString();

                                    dataGridView1.Rows.Add(orderID, orderDate, orderStatus, totalOrderPrice);
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
