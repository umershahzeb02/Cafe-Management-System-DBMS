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
    public partial class updateInventory : Form
    {
        private string connectionString = "Data Source= DESKTOP-BCLJSMJ\\SQLEXPRESS ;" +
                "Database= campusbites;" +
                "Integrated Security = True;";
        public updateInventory()
        {
            InitializeComponent();
            popData();
        }

        private void update_Click(object sender, EventArgs e)
        {
            //string connectionString = "your_connection_string";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    int inventIDToUpdate;
                    int newQuantity;

                    // Check if the entered ID and new quantity are valid integers
                    if (int.TryParse(idtext.Text, out inventIDToUpdate) && int.TryParse(newQuant.Text, out newQuantity))
                    {
                        using (SqlCommand command = new SqlCommand())
                        {
                            command.Connection = connection;
                            command.CommandType = CommandType.Text;

                            // SQL UPDATE statement to modify the quantity
                            command.CommandText = "UPDATE inventory SET quantity = @NewQuantity WHERE inventID = @InventID";

                            // Parameterized query to prevent SQL injection
                            command.Parameters.AddWithValue("@NewQuantity", newQuantity);
                            command.Parameters.AddWithValue("@InventID", inventIDToUpdate);

                            connection.Open();

                            // Execute the UPDATE query
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                popData();
                                MessageBox.Show("Quantity updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Item with the provided ID not found in inventory.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter valid numeric values for ID and new quantity.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
    }
}
