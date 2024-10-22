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
    public partial class checkoutform : Form
    {
        private string connectionString = "Data Source= DESKTOP-BCLJSMJ\\SQLEXPRESS ;" +
                    "Database= campusbites;" +
                    "Integrated Security = True;";
        public checkoutform()
        {
            InitializeComponent();
            LoadItemsDisplay();
        }

        private decimal totalAmount;
        private int id;
        private int customerID;
        public checkoutform(decimal amount, int cashierID)
        {
            InitializeComponent();
            LoadItemsDisplay();
            totalAmount = amount;
            amounttxt.Text = totalAmount.ToString();
            id = cashierID;

        }

        private void checkoutComplete_Click(object sender, EventArgs e)
        {
            try
            {

                if (!int.TryParse(cstIDtxt.Text, out customerID))
                {
                    // Customer ID is not provided, insert a new customer
                    customerID = InsertNewCustomer();
                }

                decimal totalAmount = decimal.Parse(amounttxt.Text);

                // Calculate loyalty points for each item in itemDisplay
                int loyaltyPoints = CalculateLoyaltyPoints();

                // Update customer's loyalty points
                UpdateCustomerLoyaltyPoints(customerID, loyaltyPoints);

                // Additional logic for payment handling (cash or credit) can be added here
                int orderID = InsertIntoOrders(customerID);

                // Calculate the total amount
                //decimal totalAmount1 = decimal.Parse(totalamount_txtbox.Text);

                // Get the selected payment method
                string paymentMethod = GetSelectedPaymentMethod();

                // Insert into the transactions table
                InsertIntoTransactions(orderID, paymentMethod, totalAmount);
                MoveItemsToOrderItem(orderID);

                RemoveAllItemsFromItemDisplay();


                MessageBox.Show("Checkout completed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int InsertNewCustomer()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO costumer (firstName, lastName, CstContact, loyalityPoints) " +
                                   "VALUES (@firstName, @lastName, @CstContact, 0);" +
                                   "SELECT SCOPE_IDENTITY();";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@firstName", firstNametxt.Text);
                        command.Parameters.AddWithValue("@lastName", lastNametxt.Text);
                        command.Parameters.AddWithValue("@CstContact", contacttxt.Text);


                        return Convert.ToInt32(command.ExecuteScalar());
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }

        private int CalculateLoyaltyPoints()
        {
            int totalLoyaltyPoints = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT SUM(i.point * id.quantity) " +
                                   "FROM itemDisplay id " +
                                   "INNER JOIN inventory i ON id.inventID = i.inventID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        object result = command.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            totalLoyaltyPoints = Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return totalLoyaltyPoints;
        }

        private void UpdateCustomerLoyaltyPoints(int customerID, int loyaltyPoints)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "UPDATE costumer SET loyalityPoints = loyalityPoints + @loyaltyPoints WHERE CstID = @customerID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@loyaltyPoints", loyaltyPoints);
                        command.Parameters.AddWithValue("@customerID", customerID);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadItemsDisplay()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT " +
                                   "id.inventID as ID, " +
                                   "(SELECT i.inventName FROM inventory i WHERE i.inventID = id.inventID) AS Name, " +
                                   "(SELECT i.UnitPrice FROM inventory i WHERE i.inventID = id.inventID) AS Price, " +
                                   "id.quantity AS Quantity " +
                                   "FROM " +
                                   "itemDisplay id;";


                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        
                            // Clear existing columns and rows in DataGridView2
                            dataGridView1.Columns.Clear();
                            dataGridView1.Rows.Clear();

                            // Check if the SqlDataReader has rows
                            if (reader.HasRows)
                            {
                                // Add columns to DataGridView2
                                dataGridView1.Columns.Add("inventID", "ID");
                                dataGridView1.Columns.Add("Name", "Name");
                                dataGridView1.Columns.Add("Price", "Price");
                                dataGridView1.Columns.Add("Quantity", "Quantity");

                                // Iterate through the SqlDataReader and add rows to DataGridView2
                                while (reader.Read())
                                {
                                    string inventID = reader["inventID"].ToString();
                                    string name = reader["Name"].ToString();
                                    string price = reader["Price"].ToString();
                                    string quantity = reader["Quantity"].ToString();

                                    dataGridView1.Rows.Add(inventID, name, price, quantity);
                                }
                            }
                        reader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle the exception (e.g., display an error message)
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private int InsertIntoOrders(int customerID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string orderQuery = "INSERT INTO orders (orderPrice, orderStatus, CstID) VALUES (" + totalAmount + ", 'Paid', @customerID);" +
                                        "SELECT SCOPE_IDENTITY();";

                    using (SqlCommand orderCommand = new SqlCommand(orderQuery, connection))
                    {
                        orderCommand.Parameters.AddWithValue("@customerID", customerID);

                        // ExecuteScalar returns the identity of the new order
                        return Convert.ToInt32(orderCommand.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }

        private string GetSelectedPaymentMethod()
        {
            if (cash.Checked)
            {
                return "Cash";
            }
            else if (credit.Checked)
            {
                return "Credit";
            }
            else
            {
                // Default to "Cash" if neither is selected
                return "Cash";
            }
        }

        private void InsertIntoTransactions(int orderID, string paymentMethod, decimal totalAmount)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string transactionQuery = "INSERT INTO transactions (transDate, paymentMethod, amount, CstID, CashierID, orderID) " +
                                              "VALUES (GETDATE(), @paymentMethod, @totalAmount, @customerID, @cashierID, @orderID)";

                    using (SqlCommand transactionCommand = new SqlCommand(transactionQuery, connection))
                    {
                        transactionCommand.Parameters.AddWithValue("@paymentMethod", paymentMethod);
                        transactionCommand.Parameters.AddWithValue("@totalAmount", totalAmount);
                        if (customerID == -1)
                        {
                            int result = int.Parse(cstIDtxt.Text);
                            transactionCommand.Parameters.AddWithValue("@customerID", result);
                        }
                        else
                        {
                            transactionCommand.Parameters.AddWithValue("@customerID", customerID);
                        }
                        transactionCommand.Parameters.AddWithValue("@cashierID", id); // Replace with the actual cashier ID
                        transactionCommand.Parameters.AddWithValue("@orderID", orderID);

                        transactionCommand.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MoveItemsToOrderItem(int orderID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Begin a transaction
                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            MoveItemsToOrderItem(orderID, connection, transaction);

                            // If all operations are successful, commit the transaction
                            transaction.Commit();
                        }
                        catch (Exception ex)
                        {
                            // An error occurred, rollback the transaction
                            transaction.Rollback();
                            MessageBox.Show("Transaction failed. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MoveItemsToOrderItem(int orderID, SqlConnection connection, SqlTransaction transaction)
        {
            string selectQuery = "SELECT i.inventID, i.quantity, id.unitprice FROM itemDisplay i join inventory id on i.inventID = id.inventID ";
            try
            {
                using (SqlCommand selectCommand = new SqlCommand(selectQuery, connection, transaction))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int inventID = reader.GetInt32(0);
                            int quantity = reader.GetInt32(1);
                            int total = reader.GetInt32(2);

                            // Close the reader before executing a new command
                            reader.Close();

                            InsertOrderItem(orderID, quantity, inventID, total, connection, transaction);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void InsertOrderItem(int orderID, int quant, int inventID, int total, SqlConnection connection, SqlTransaction transaction)
        {
            string insertQuery = "INSERT INTO orderItem (CstID, orderID, itemID, itemPrice, quantity) VALUES (@customerID, @orderID, @inventID, @total, @quantity)";

            using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection, transaction))
            {
                try
                {
                    if (customerID == -1)
                    {
                        int result = int.Parse(cstIDtxt.Text);
                        insertCommand.Parameters.AddWithValue("@customerID", result);
                    }
                    else
                    {
                        insertCommand.Parameters.AddWithValue("@customerID", customerID);
                    }

                    insertCommand.Parameters.AddWithValue("@orderID", orderID);
                    insertCommand.Parameters.AddWithValue("@inventID", inventID);
                    insertCommand.Parameters.AddWithValue("@quantity", quant);
                    insertCommand.Parameters.AddWithValue("@total", total);

                    insertCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    // Handle the exception (e.g., log it or display an error message)
                    MessageBox.Show($"Error inserting into orderItem: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void UpdateInventory(int inventID, int quantity, SqlConnection connection, SqlTransaction transaction)
        {
            string updateInventoryQuery = "UPDATE inventory SET quantity = quantity - @quantity WHERE inventID = @inventID";

            using (SqlCommand updateInventoryCommand = new SqlCommand(updateInventoryQuery, connection, transaction))
            {
                updateInventoryCommand.Parameters.AddWithValue("@quantity", quantity);
                updateInventoryCommand.Parameters.AddWithValue("@inventID", inventID);

                updateInventoryCommand.ExecuteNonQuery();
            }
        }

        private void RemoveAllItemsFromItemDisplay()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Delete all records from the itemDisplay table
                    string deleteQuery = "DELETE FROM itemDisplay";

                    using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection))
                    {
                        deleteCommand.ExecuteNonQuery();
                    }

                    //MessageBox.Show("All items removed from itemDisplay.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
