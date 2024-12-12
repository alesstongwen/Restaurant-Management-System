using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Restaurant_Management_System.forms;

namespace Restaurant_Management_System
{
    public partial class LoginForm : Form
    {
        // Hardcoded user credentials
        private readonly Dictionary<string, (string Password, string Role)> users = new()
        {
            { "admin", ("password123", "Admin") },
            { "waitstaff1", ("waitstaff123", "Waitstaff") },
            { "kitchen1", ("kitchen123", "Kitchen Staff") }
        };

        public LoginForm()
        {
            InitializeComponent();
            roleComboBox.Items.AddRange(new[] { "Admin", "Waitstaff", "Kitchen Staff" });
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            // Get input from textboxes and combobox
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            string role = roleComboBox.SelectedItem?.ToString() ?? string.Empty;

            // Validate credentials
            if (ValidateLogin(username, password, role))
            {
                MessageBox.Show("Login Successful!", "Success");
                OpenDashboard(username, role);
            }
            else
            {
                MessageBox.Show("Invalid credentials. Please try again.", "Login Failed");
            }
        }

        private bool ValidateLogin(string username, string password, string role)
        {
            // Check if user exists and credentials match
            return users.ContainsKey(username) &&
                   users[username].Password == password &&
                   users[username].Role == role;
        }

        private void OpenDashboard(string username, string role)
        {
            // Open the single dashboard form and pass the user's role
            DashboardForm dashboard = new DashboardForm(username, role);
            dashboard.Show();
            this.Hide(); // Hide the login form
        }
    }
}
