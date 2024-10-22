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
    public partial class inventoryManagerForm : Form
    {
        private string connectionString = "Data Source= DESKTOP-BCLJSMJ\\SQLEXPRESS ;" +
        "Database= campusbites;" +
        "Integrated Security = True;";
        public inventoryManagerForm()
        {
            InitializeComponent();
            popData();

        }
        private int id;
        public inventoryManagerForm(int id)
        {
            InitializeComponent();
            this.id = id;
            popData();
        }

        private void addItem_Click(object sender, EventArgs e)
        {
            addInventory addInventory = new addInventory(id);
            addInventory.Visible = true;
        }

        private void removeItem_Click(object sender, EventArgs e)
        {
            removeInventory rm = new removeInventory();
            rm.Visible = true;
            //this.Visible = false;
        }

        private void updateItem_Click(object sender, EventArgs e)
        {
            updateInventory up = new updateInventory();
            up.Visible = true;
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
