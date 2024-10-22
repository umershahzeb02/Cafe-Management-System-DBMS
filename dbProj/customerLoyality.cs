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
    public partial class customerLoyality : Form
    {
        private string connectionString = "Data Source= DESKTOP-BCLJSMJ\\SQLEXPRESS ;" +
                    "Database= campusbites;" +
                    "Integrated Security = True;";
        public customerLoyality()
        {
            InitializeComponent();
            PopulateDataGridView1();
        }

        private void customerLoyality_Load(object sender, EventArgs e)
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

                        command.CommandText = @"
                    SELECT 
                        CstID,
                        firstName,
                        lastName,
                        CstContact,
                        loyalityPoints
                    FROM costumer
                    ORDER BY loyalityPoints DESC
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
                                dataGridView1.Columns.Add("CstID", "Customer ID");
                                dataGridView1.Columns.Add("firstName", "First Name");
                                dataGridView1.Columns.Add("lastName", "Last Name");
                                dataGridView1.Columns.Add("CstContact", "Contact");
                                dataGridView1.Columns.Add("loyalityPoints", "Loyalty Points");

                                // Iterate through the SqlDataReader and add rows to DataGridView1
                                while (reader.Read())
                                {
                                    string CstID = reader["CstID"].ToString();
                                    string firstName = reader["firstName"].ToString();
                                    string lastName = reader["lastName"].ToString();
                                    string CstContact = reader["CstContact"].ToString();
                                    string loyalityPoints = reader["loyalityPoints"].ToString();

                                    dataGridView1.Rows.Add(CstID, firstName, lastName, CstContact, loyalityPoints);
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
