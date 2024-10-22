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
    public partial class makeMenu : Form
    {
        private string connectionString = "Data Source= DESKTOP-BCLJSMJ\\SQLEXPRESS ;" +
        "Database= campusbites;" +
        "Integrated Security = True;";
        public makeMenu()
        {
            InitializeComponent();
            PopulateDataGridView1();
            PopulateDataGridView2();
        }
        private int mgr;
        public makeMenu(int id)
        {
            InitializeComponent();
            PopulateDataGridView1();
            PopulateDataGridView2();
            mgr = id;
        }

        private void addbt_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(add.Text, out int inventID))
            {
                MessageBox.Show("Invalid ID. Please enter a valid numeric value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandType = CommandType.Text;

                        // SQL INSERT statement to add an item to the menu
                        command.CommandText = "INSERT INTO menu (inventID, menuMgr) VALUES (@InventID, @meMgr)";

                        // Parameterized query to prevent SQL injection
                        command.Parameters.AddWithValue("@InventID", inventID);
                        command.Parameters.AddWithValue("@meMgr", mgr);


                        connection.Open();

                        // Execute the INSERT query
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Item added to the menu successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            PopulateDataGridView2();
                        }
                        else
                        {
                            MessageBox.Show("Item with the provided ID not found in the inventory.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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

                        // SQL SELECT statement to retrieve inventory data
                        command.CommandText = "SELECT inventID, inventName, quantity, category, UnitPrice FROM inventory";

                        connection.Open();

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            // Bind the DataTable to DataGridView1
                            dataGridView1.DataSource = dataTable;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void PopulateDataGridView2()
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandType = CommandType.Text;

                        // SQL SELECT statement to retrieve data from menu and inventory tables
                        command.CommandText = @"SELECT     
                                                m.menuItemID,  
                                                m.inventID,   
                                                i.inventName,    
                                                m.menuMgr,   
                                                s.firstName AS managerFirstName,    
                                                s.lastName AS managerLastName 
                                                FROM     
                                                menu m  
                                                JOIN  
                                                inventory i ON m.inventID = i.inventID 
                                                JOIN  
                                                staff s ON m.menuMgr = s.staffID;";

                        connection.Open();

                        //connection.Open();

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            // Bind the DataTable to DataGridView1
                            dataGridView2.DataSource = dataTable;
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void removebt_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(remove.Text, out int menuItemID))
            {
                MessageBox.Show("Invalid Menu Item ID. Please enter a valid numeric value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandType = CommandType.Text;

                        // SQL DELETE statement to remove a row from the menu
                        command.CommandText = "DELETE FROM menu WHERE menuItemID = @MenuItemID";

                        // Parameterized query to prevent SQL injection
                        command.Parameters.AddWithValue("@MenuItemID", menuItemID);

                        connection.Open();

                        // Execute the DELETE query
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Menu item removed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            PopulateDataGridView2();

                        }
                        else
                        {
                            MessageBox.Show("Menu item with the provided ID not found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
