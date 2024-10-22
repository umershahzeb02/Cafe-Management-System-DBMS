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
    public partial class manageStaff : Form
    {
        private string connectionString = "Data Source= DESKTOP-BCLJSMJ\\SQLEXPRESS ;" +
                        "Database= campusbites;" +
                        "Integrated Security = True;";
        public manageStaff()
        {
            InitializeComponent();
            PopulateStaffDataGridView();
        }
        private int mgr;
        public manageStaff(int id)
        {
            InitializeComponent();
            PopulateStaffDataGridView();
            mgr = id;
        }

        private void addstaff_Click(object sender, EventArgs e)
        {
            addStaff ad = new addStaff(mgr);
            ad.Visible = true;
            //this.Visible = false;

        }

        private void PopulateStaffDataGridView()
        {
            // Replace "your_connection_string" with your actual connection string


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandType = CommandType.Text;

                        command.CommandText = "SELECT staffID, firstName, lastName, stContact, address, salary, role, username, password FROM staff WHERE role <> 'Manager'";

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            dataGridView1.DataSource = dataTable;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void removestaff_Click(object sender, EventArgs e)
        {
            removeStaff ad = new removeStaff();
            ad.Visible = true;
            this.Visible = false;

        }

        private void updateStaff_Click(object sender, EventArgs e)
        {
            updatestaff ad = new updatestaff();
            ad.Visible = true;
            this.Visible = false;

        }
    }
}
