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
    public partial class removeStaff : Form
    {
        private string connectionString = "Data Source= DESKTOP-BCLJSMJ\\SQLEXPRESS ;" +
                "Database= campusbites;" +
                "Integrated Security = True;";
        public removeStaff()
        {
            InitializeComponent();
        }

        private void remove_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandType = CommandType.Text;

                        // SQL UPDATE statement to remove the role and reset the password
                        command.CommandText = "UPDATE staff SET role = NULL, passsword = 'cvrr34356h' WHERE staffID = @StaffID";

                        // Parameterized query to prevent SQL injection
                        command.Parameters.AddWithValue("@StaffID", idtextbox.Text);

                        connection.Open();

                        // Execute the UPDATE query
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Role removed and password reset successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
