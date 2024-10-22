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
    public partial class report_staffPerform : Form
    {
        private string connectionString = "Data Source= DESKTOP-BCLJSMJ\\SQLEXPRESS ;" +
                "Database= campusbites;" +
                "Integrated Security = True;";
        public report_staffPerform()
        {
            InitializeComponent();
            PopulateDataGridView1();
        }

        private void report_staffPerform_Load(object sender, EventArgs e)
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
                    SELECT +
                        staffID,
                        firstName,
                        lastName,
                        role,
                        salary,
                        COUNT(orders.orderID) AS totalOrders,
                        SUM(orders.orderPrice) AS totalRevenue
                    FROM staff
                    LEFT JOIN transactions ON staff.staffID = transactions.CashierID
                    LEFT JOIN orders ON transactions.orderID = orders.orderID
                    GROUP BY staff.staffID, staff.firstName, staff.lastName, staff.role, staff.salary
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
                                dataGridView1.Columns.Add("staffID", "Staff ID");
                                dataGridView1.Columns.Add("firstName", "First Name");
                                dataGridView1.Columns.Add("lastName", "Last Name");
                                dataGridView1.Columns.Add("role", "Role");
                                dataGridView1.Columns.Add("salary", "Salary");
                                dataGridView1.Columns.Add("totalOrders", "Total Orders");
                                dataGridView1.Columns.Add("totalRevenue", "Total Revenue");

                                // Iterate through the SqlDataReader and add rows to DataGridView1
                                while (reader.Read())
                                {
                                    string staffID = reader["staffID"].ToString();
                                    string firstName = reader["firstName"].ToString();
                                    string lastName = reader["lastName"].ToString();
                                    string role = reader["role"].ToString();
                                    string salary = reader["salary"].ToString();
                                    string totalOrders = reader["totalOrders"].ToString();
                                    string totalRevenue = reader["totalRevenue"].ToString();

                                    dataGridView1.Rows.Add(staffID, firstName, lastName, role, salary, totalOrders, totalRevenue);
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
