using System;
using System.Windows.Forms;
using Restaurant_Management_System.forms;

namespace Restaurant_Management_System
{
    public partial class DashboardForm : Form
    {
        private string Username { get; }
        private string Role { get; }

        public DashboardForm(string username, string role)
        {
            InitializeComponent();
            Username = username;
            Role = role;
            CustomizeUI();
        }

        private void CustomizeUI()
        {
            lblWelcome.Text = $"Welcome, {Username} ({Role})";

            // Customize button availability based on user role
            if (Role == "Kitchen Staff")
            {
                btnMenuManagement.Enabled = false;
                btnTableManagement.Enabled = false;
            }
            else if (Role == "Waitstaff")
            {
                btnMenuManagement.Enabled = false;
            }
        }

        private void btnMenuManagement_Click(object sender, EventArgs e)
        {
            // Open Menu Management Form
            MenuForm menuForm = new MenuForm();
            menuForm.ShowDialog();
        }

        private void btnOrderManagement_Click(object sender, EventArgs e)
        {
            // Open Orders Management Form
            OrdersForm ordersForm = new OrdersForm();
            ordersForm.ShowDialog();
        }

        private void btnTableManagement_Click(object sender, EventArgs e)
        {
            // Open Tables Management Form
            TablesForm tablesForm = new TablesForm();
            tablesForm.ShowDialog();
        }
    }
}
