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
    public partial class transacreport : Form
    {
        public transacreport()
        {
            InitializeComponent();
            PopulateDataGridView1();
        }
        private string connectionString = "Data Source= DESKTOP-BCLJSMJ\\SQLEXPRESS ;" +
                "Database= campusbites;" +
                "Integrated Security = True;";

        private void transacreport_Load(object sender, EventArgs e)
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

                        // SQL SELECT statement to retrieve data from the transactions table
                        command.CommandText = @"
                    SELECT 
                        transID,
                        transDate,
                        paymentMethod,
                        amount,
                        CstID,
                        CashierID,
                        orderID
                    FROM transactions
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
                                dataGridView1.Columns.Add("transID", "Transaction ID");
                                dataGridView1.Columns.Add("transDate", "Transaction Date");
                                dataGridView1.Columns.Add("paymentMethod", "Payment Method");
                                dataGridView1.Columns.Add("amount", "Amount");
                                dataGridView1.Columns.Add("CstID", "Customer ID");
                                dataGridView1.Columns.Add("CashierID", "Cashier ID");
                                dataGridView1.Columns.Add("orderID", "Order ID");

                                // Iterate through the SqlDataReader and add rows to DataGridView1
                                while (reader.Read())
                                {
                                    string transID = reader["transID"].ToString();
                                    string transDate = reader["transDate"].ToString();
                                    string paymentMethod = reader["paymentMethod"].ToString();
                                    string amount = reader["amount"].ToString();
                                    string CstID = reader["CstID"].ToString();
                                    string CashierID = reader["CashierID"].ToString();
                                    string orderID = reader["orderID"].ToString();

                                    dataGridView1.Rows.Add(transID, transDate, paymentMethod, amount, CstID, CashierID, orderID);
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
