using System;
using System.Windows.Forms;

namespace Restaurant_Management_System
{
    public partial class OrdersForm : Form
    {
        public OrdersForm()
        {
            InitializeComponent();
            LoadMenuItems();
            InitializeOrdersGrid();
            RefreshOrders();
        }

        private void LoadMenuItems()
        {
            // Simulate loading menu items (replace with actual data from the database)
            cmbMenuItems.Items.AddRange(new string[] { "Cheeseburger", "Pasta", "Pizza", "Salad", "Soda" });
        }

        private void InitializeOrdersGrid()
        {
            // Define columns for the DataGridView
            dgvOrders.Columns.Add("OrderID", "Order ID");
            dgvOrders.Columns.Add("TableNumber", "Table Number");
            dgvOrders.Columns.Add("MenuItem", "Menu Item");
            dgvOrders.Columns.Add("Quantity", "Quantity");
            dgvOrders.Columns.Add("Status", "Status");
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            // Retrieve inputs
            string tableNumber = txtTableNumber.Text;
            string menuItem = cmbMenuItems.SelectedItem?.ToString();
            int quantity = (int)numQuantity.Value;

            if (string.IsNullOrWhiteSpace(tableNumber) || string.IsNullOrWhiteSpace(menuItem) || quantity <= 0)
            {
                MessageBox.Show("Please fill all fields correctly.");
                return;
            }

            // Simulate saving to the database (replace with real DB logic)
            MessageBox.Show($"Order Added:\nTable: {tableNumber}\nItem: {menuItem}\nQuantity: {quantity}");

            // Refresh orders grid (simulate)
            RefreshOrders();
        }

        private void btnMarkCompleted_Click(object sender, EventArgs e)
        {
            // Simulate marking the selected order as completed
            if (dgvOrders.SelectedRows.Count > 0)
            {
                int rowIndex = dgvOrders.SelectedRows[0].Index;
                dgvOrders.Rows[rowIndex].Cells["Status"].Value = "Completed";
                MessageBox.Show("Order marked as completed!");
            }
            else
            {
                MessageBox.Show("Please select an order to mark as completed.");
            }
        }

        private void btnRefreshOrders_Click(object sender, EventArgs e)
        {
            // Refresh orders grid (simulate fetching from DB)
            RefreshOrders();
        }

        private void RefreshOrders()
        {
            // Simulate fetching and displaying orders (replace with real DB logic)
            dgvOrders.Rows.Clear();
            dgvOrders.Rows.Add("1", "5", "Cheeseburger", "2", "Pending");
            dgvOrders.Rows.Add("2", "3", "Pasta", "1", "Completed");
        }

        private void txtTableNumber_TextChanged(object sender, EventArgs e)
        {
            // Optional: Add any text change handling logic here
        }

        private void dgvOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
