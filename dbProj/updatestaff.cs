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
    public partial class updatestaff : Form
    {
        private string connectionString = "Data Source= DESKTOP-BCLJSMJ\\SQLEXPRESS ;" +
                "Database= campusbites;" +
                "Integrated Security = True;";
        public updatestaff()
        {
            InitializeComponent();
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(idtext.Text, out int staffID) || !int.TryParse(salarytext.Text, out int newSalary))
            {
                MessageBox.Show("Invalid ID or Salary. Please enter valid numeric values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Replace "your_connection_string" with your actual connection string
            //string connectionString = "your_connection_string";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandType = CommandType.Text;

                        // SQL UPDATE statement to modify the salary and role
                        command.CommandText = "UPDATE staff SET salary = @NewSalary, role = @Role WHERE staffID = @StaffID";

                        // Parameterized query to prevent SQL injection
                        command.Parameters.AddWithValue("@StaffID", staffID);
                        command.Parameters.AddWithValue("@NewSalary", newSalary);
                        command.Parameters.AddWithValue("@Role", rolecheckboxlist.SelectedItem.ToString());

                        connection.Open();

                        // Execute the UPDATE query
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Staff member updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Visible = false;
                        }
                        else
                        {
                            MessageBox.Show("Staff member with the provided ID not found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
