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
    public partial class addInventory : Form
    {
        private string connectionString = "Data Source= DESKTOP-BCLJSMJ\\SQLEXPRESS ;" +
            "Database= campusbites;" +
            "Integrated Security = True;";
        public addInventory()
        {
            InitializeComponent();
            popData();
        }
        private int id;
        public addInventory(int id)
        {
            InitializeComponent();
            popData();
            this.id = id;
        }

        private void addItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Input Validation
                if (!IsValidInput())
                {
                    MessageBox.Show("Please enter valid values for quantity, unit price, and points.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string inventName = nametxt.Text;
                string inventDescription = desctxt.Text;
                int quantity = Convert.ToInt32(quanttxt.Text);
                string category = categorytxt.Text;
                int unitPrice = Convert.ToInt32(unitPricetxt.Text);
                int point = Convert.ToInt32(pointstxt.Text);

                // Assuming inventMgr is the ID of the current logged-in manager
                int inventMgr = id; // You need to implement this function

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Data Integrity Checks
                    if (!IsValidData(inventName, inventDescription, quantity, category, unitPrice, point))
                    {
                        MessageBox.Show("Invalid data. Please check the entered values.", "Data Integrity Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string query = "INSERT INTO inventory (inventName, inventDescription, quantity, category, UnitPrice, point, inventMgr) " +
                                   "VALUES (@inventName, @inventDescription, @quantity, @category, @unitPrice, @point, @inventMgr)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@inventName", inventName);
                        command.Parameters.AddWithValue("@inventDescription", inventDescription);
                        command.Parameters.AddWithValue("@quantity", quantity);
                        command.Parameters.AddWithValue("@category", category);
                        command.Parameters.AddWithValue("@unitPrice", unitPrice);
                        command.Parameters.AddWithValue("@point", point);
                        command.Parameters.AddWithValue("@inventMgr", inventMgr);

                        // Execute the insert command
                        command.ExecuteNonQuery();
                    }
                    popData();

                    MessageBox.Show("Item added to inventory successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsValidInput()
        {
            int quantity, unitPrice, point;

            // Check if numeric values are entered for quantity, unit price, and points
            if (!int.TryParse(quanttxt.Text, out quantity) || !int.TryParse(unitPricetxt.Text, out unitPrice) || !int.TryParse(pointstxt.Text, out point))
            {
                return false;
            }


            if (quantity < 0 || unitPrice < 0 || point < 0)
            {
                return false;
            }

            return true;
        }

        private bool IsValidData(string inventName, string inventDescription, int quantity, string category, int unitPrice, int point)
        {
            // Check if inventName and category are not empty
            if (string.IsNullOrWhiteSpace(inventName) || string.IsNullOrWhiteSpace(category))
            {
                return false;
            }


            return true;
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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
