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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace dbProj
{
    public partial class removeInventory : Form
    {
        private string connectionString = "Data Source= DESKTOP-BCLJSMJ\\SQLEXPRESS ;" +
        "Database= campusbites;" +
        "Integrated Security = True;";
        public removeInventory()
        {
            InitializeComponent();
            popData();
        }
        public void popData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT inventID, inventName AS Name, UnitPrice AS Price, quantity AS Quantity " +
                               "FROM inventory";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Clear existing columns and rows in DataGridView1
                        dataGridView1.Columns.Clear();
                        dataGridView1.Rows.Clear();

                        // Check if the SqlDataReader has rows
                        if (reader.HasRows)
                        {
                            // Add columns to DataGridView1
                            dataGridView1.Columns.Add("inventID", "ID");
                            dataGridView1.Columns.Add("Name", "Name");
                            dataGridView1.Columns.Add("Price", "Price");
                            dataGridView1.Columns.Add("Quantity", "Quantity");

                            // Iterate through the SqlDataReader and add rows to DataGridView1
                            while (reader.Read())
                            {
                                string inventID = reader["inventID"].ToString();
                                string name = reader["Name"].ToString();
                                string price = reader["Price"].ToString();
                                string quantity = reader["Quantity"].ToString();

                                dataGridView1.Rows.Add(inventID, name, price, quantity);
                            }
                        }
                    }
                }
            }

        }
        private void remove_Click(object sender, EventArgs e)
        {
            try
            {
                int inventIDToDelete;

                // Check if the entered ID is a valid integer
                if (int.TryParse(idtextbox.Text, out inventIDToDelete))
                {
                    using (SqlConnection command = new SqlConnection(connectionString))
                    {
                        //command.CommandType = CommandType.Text;
                        command.Open();
                        // SQL DELETE statement
                        String query = "DELETE FROM inventory WHERE inventID = @InventID";
                        SqlCommand connection = new SqlCommand(query, command);
                        //connection.Open();

                        // Parameterized query to prevent SQL injection
                        connection.Parameters.AddWithValue("@InventID", inventIDToDelete);


                        // Execute the DELETE query
                        int rowsAffected = connection.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            popData();
                            MessageBox.Show("Item removed from inventory successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Item with the provided ID not found in inventory.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid numeric ID.", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //if (command.State == ConnectionState.Open)
                //{
                //    connection.Close();
                //}
            }
        }
    }
}
