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
    public partial class addStaff : Form
    {
        private string connectionString = "Data Source= DESKTOP-BCLJSMJ\\SQLEXPRESS ;" +
                "Database= campusbites;" +
                "Integrated Security = True;";
        public addStaff()
        {
            InitializeComponent();
        }
        private int mgr;
        public addStaff(int id)
        {
            InitializeComponent();
            mgr = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandType = CommandType.Text;
                        int intsal = int.Parse(salary.Text);
                        // SQL INSERT statement to add a new staff member
                        command.CommandText = "INSERT INTO staff (firstName, lastName, stContact, address, role, username, password,salary,mgrID) " +
                                              "VALUES (@FirstName, @LastName, @StContact, @Address, @Role, @Username, @Password,@Salary, @manager)";
                        connection.Open();
                        // Parameterized query to prevent SQL injection
                        command.Parameters.AddWithValue("@FirstName", firstName.Text);
                        command.Parameters.AddWithValue("@LastName", lastName.Text);
                        command.Parameters.AddWithValue("@StContact", contact.Text);
                        command.Parameters.AddWithValue("@Address", address.Text);
                        command.Parameters.AddWithValue("@Role", rolechecklistbox.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@Username", username.Text);
                        command.Parameters.AddWithValue("@password", password.Text);
                        command.Parameters.AddWithValue("@Salary", intsal);
                        command.Parameters.AddWithValue("@manager", mgr);





                        // Execute the INSERT query
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Staff member added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Visible = false;
                        }
                        else
                        {
                            MessageBox.Show("Failed to add staff member.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
