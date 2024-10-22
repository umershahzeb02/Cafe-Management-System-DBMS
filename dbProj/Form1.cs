using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace dbProj
{
    public partial class Form1 : Form
    {
        private string connectionString = "Data Source= DESKTOP-BCLJSMJ\\SQLEXPRESS ;" +
                        "Database= campusbites;" +
                        "Integrated Security = True;";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text.Trim();
            string password = txtpassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate credentials
            bool isValidLogin = ValidateLogin(username, password);

            if (isValidLogin)
            {
                // Redirect based on role
                string role = GetStaffRole(username);
                RedirectToFormBasedOnRole(role);
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool ValidateLogin(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM staff WHERE username = @Username AND password = @Password";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        private string GetStaffRole(string username)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT role FROM staff WHERE username = @Username";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);

                    return (string)command.ExecuteScalar();
                }
            }
        }

        private void RedirectToFormBasedOnRole(string role)
        {
            string username = txtusername.Text.Trim();
            string password = txtpassword.Text.Trim();
            // Redirect logic based on the role
            switch (role)
            {
                case "Manager":
                    ManagerForm mg = new ManagerForm(GetStaffID(username, password));
                    mg.Visible = true;
                    this.Visible = false;

                    break;
                case "Cashier":
                    // Redirect to CashierForm
                    cashierForm csh = new cashierForm(GetStaffID(username, password));
                    csh.Visible = true;
                    this.Visible = false;
                    break;
                case "InventoryManager":
                    inventoryManagerForm inMgr = new inventoryManagerForm();
                    inMgr.Visible = true;
                    this.Visible = false;

                    break;
                default:
                    MessageBox.Show("Invalid role.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private int GetStaffID(string username, string password)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT staffID FROM staff WHERE username = @username AND password = @password";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);

                        object result = command.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            return Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return -1; // Return -1 if staffID is not found or an error occurs
        }

    }
}