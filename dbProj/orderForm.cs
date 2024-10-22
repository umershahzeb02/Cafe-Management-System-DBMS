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
    public partial class orderForm : Form
    {
        private string connectionString = "Data Source= DESKTOP-BCLJSMJ\\SQLEXPRESS ;" +
                "Database= campusbites;" +
                "Integrated Security = True;";

        private decimal totalAmount = 0;
        public orderForm()
        {
            InitializeComponent();
            LoadMenuItems();
            LoadItemsDisplay();
        }

        private int id;
        public orderForm(int cashierID)
        {
            InitializeComponent();
            LoadMenuItems();
            LoadItemsDisplay();
            id = cashierID;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public void LoadMenuItems()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT " +
                               "m.menuItemID, " +
                               "(SELECT i.inventName FROM inventory i WHERE i.inventID = m.inventID) AS inventName, " +
                               "(SELECT i.quantity FROM inventory i WHERE i.inventID = m.inventID) AS quantity, " +
                               "(SELECT i.category FROM inventory i WHERE i.inventID = m.inventID) AS Category, " +
                               "(SELECT i.unitPrice FROM inventory i WHERE i.inventID = m.inventID) AS Price " +
                               "FROM " +
                               "menu m;";

                SqlCommand command = new SqlCommand(query, connection);
                // Assuming you have already executed the SQL query and have the SqlDataReader
                try
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Clear existing columns and rows in the DataGridView
                        dataGridView1.Columns.Clear();
                        dataGridView1.Rows.Clear();

                        // Check if the SqlDataReader has rows
                        if (reader.HasRows)
                        {
                            // Add columns to the DataGridView
                            dataGridView1.Columns.Add("menuItemID", "Menu Item ID");
                            dataGridView1.Columns.Add("inventName", "Inventory Name");
                            dataGridView1.Columns.Add("quantity", "Quantity");
                            dataGridView1.Columns.Add("Category", "Category");
                            dataGridView1.Columns.Add("Price", "Price");

                            // Iterate through the SqlDataReader and add rows to the DataGridView
                            while (reader.Read())
                            {
                                string menuItemID = reader["menuItemID"].ToString();
                                string inventName = reader["inventName"].ToString();
                                string quantity = reader["quantity"].ToString();
                                string category = reader["Category"].ToString();
                                string price = reader["Price"].ToString();

                                dataGridView1.Rows.Add(menuItemID, inventName, quantity, category, price);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle the exception (e.g., display an error message)
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        public void LoadItemsDisplay()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT id.inventID, " +
                                   "(SELECT inventName FROM inventory WHERE inventID = id.inventID) AS Name, " +
                                   "(SELECT UnitPrice FROM inventory WHERE inventID = id.inventID) AS Price, " +
                                   "id.quantity AS Quantity " +
                                   "FROM itemDisplay id";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Clear existing columns and rows in DataGridView2
                            dataGridView2.Columns.Clear();
                            dataGridView2.Rows.Clear();

                            // Check if the SqlDataReader has rows
                            if (reader.HasRows)
                            {
                                // Add columns to DataGridView2
                                dataGridView2.Columns.Add("inventID", "ID");
                                dataGridView2.Columns.Add("Name", "Name");
                                dataGridView2.Columns.Add("Price", "Price");
                                dataGridView2.Columns.Add("Quantity", "Quantity");

                                // Iterate through the SqlDataReader and add rows to DataGridView2
                                while (reader.Read())
                                {
                                    string inventID = reader["inventID"].ToString();
                                    string name = reader["Name"].ToString();
                                    string price = reader["Price"].ToString();
                                    string quantity = reader["Quantity"].ToString();

                                    dataGridView2.Rows.Add(inventID, name, price, quantity);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle the exception (e.g., display an error message)
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void orderAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieve values from textboxes
                int orderID1;
                if (!int.TryParse(orderID.Text, out orderID1))
                {
                    MessageBox.Show("Please enter a valid Order ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int quantity;
                if (!int.TryParse(quantitytxt.Text, out quantity))
                {
                    MessageBox.Show("Please enter a valid Quantity.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Retrieve inventID from the menu database based on the orderID
                int inventID = GetInventIDFromMenu(orderID1);

                if (inventID == -1)
                {
                    MessageBox.Show("Item not found in the menu.", "Invalid Item", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Check if the requested quantity is available in inventory
                if (CheckInventoryAvailability(inventID, quantity))
                {
                    // Insert into the itemDisplay table
                    InsertIntoItemDisplay(inventID, quantity);

                    // Update the total amount
                    decimal itemPrice = GetItemPriceFromInventory(inventID);
                    totalAmount += itemPrice * quantity;

                    // Display the total amount
                    orderTotal.Text = totalAmount.ToString("C"); // Format as currency

                    LoadItemsDisplay();


                    //MessageBox.Show("Item added to the order successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Insufficient quantity in inventory.", "Insufficient Quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public int GetInventIDFromMenu(int orderID)
        {
            int inventID = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT inventID FROM menu WHERE menuItemID = @orderID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@orderID", orderID);

                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            inventID = Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return inventID;
        }

        public bool CheckInventoryAvailability(int inventID, int requestedQuantity)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT quantity FROM inventory WHERE inventID = @inventID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@inventID", inventID);

                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            int availableQuantity = Convert.ToInt32(result);

                            // Check if the available quantity is sufficient
                            return availableQuantity >= requestedQuantity;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // In case of an error or if inventID is not found, assume insufficient quantity
            return false;
        }

        public void InsertIntoItemDisplay(int inventID, int quantity)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO itemDisplay (inventID, quantity) VALUES (@inventID, @quantity)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@inventID", inventID);
                        command.Parameters.AddWithValue("@quantity", quantity);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public decimal GetItemPriceFromInventory(int inventID)
        {
            decimal itemPrice = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT UnitPrice FROM inventory WHERE inventID = @inventID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@inventID", inventID);

                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            itemPrice = Convert.ToDecimal(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return itemPrice;
        }

        private void checkoutButton_Click(object sender, EventArgs e)
        {
            checkoutform ck = new checkoutform(totalAmount, id);
            ck.Visible = true;
            this.Visible = false;
        }

        private void orderForm_Load(object sender, EventArgs e)
        {

        }
    }
}
