using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Restaurant_Management_System
{
    public partial class MenuForm : Form
    {
        private List<MenuItem> menuItems = new List<MenuItem>();

        public MenuForm()
        {
            InitializeComponent();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            // Initialize ComboBox with categories
            categoryComboBox.Items.AddRange(new string[] { "Appetizer", "Main Course", "Dessert", "Beverage" });

            // Initialize DataGridView columns
            menuDataGridView.Columns.Add("DishName", "Dish Name");
            menuDataGridView.Columns.Add("Category", "Category");
            menuDataGridView.Columns.Add("Price", "Price");
            menuDataGridView.Columns.Add("Availability", "Available");
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // Validate input fields
            if (string.IsNullOrWhiteSpace(dishNameTextBox.Text) ||
                categoryComboBox.SelectedItem == null ||
                priceNumericUpDown.Value <= 0)
            {
                MessageBox.Show("Please fill in all fields correctly.", "Validation Error");
                return;
            }

            // Create a new menu item
            MenuItem menuItem = new MenuItem
            {
                DishName = dishNameTextBox.Text,
                Category = categoryComboBox.SelectedItem.ToString(),
                Price = (double)priceNumericUpDown.Value,
                IsAvailable = availabilityCheckBox.Checked
            };

            // Add the item to the list and DataGridView
            menuItems.Add(menuItem);
            menuDataGridView.Rows.Add(menuItem.DishName, menuItem.Category, menuItem.Price, menuItem.IsAvailable ? "Yes" : "No");

            // Clear input fields
            dishNameTextBox.Clear();
            categoryComboBox.SelectedIndex = -1;
            priceNumericUpDown.Value = 0;
            availabilityCheckBox.Checked = false;
        }

        private void dishNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }

    // Helper class for menu items
    public class MenuItem
    {
        public string DishName { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public bool IsAvailable { get; set; }
    }
}
