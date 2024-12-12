using System;
using System.Windows.Forms;

namespace Restaurant_Management_System.forms
{
    public partial class TablesForm : Form
    {
        // Simulated table data
        private readonly Dictionary<string, string> tables = new()
        {
            { "1", "Available" },
            { "2", "Occupied" },
            { "3", "Reserved" },
            { "4", "Available" },
            { "5", "Occupied" }
        };

        public TablesForm()
        {
            InitializeComponent();
            LoadTableNumbers();
            RefreshTablesGrid();
        }

        private void LoadTableNumbers()
        {
            // Populate the table numbers dropdown
            cmbTableNumber.Items.AddRange(tables.Keys.ToArray());
        }

        private void RefreshTablesGrid()
        {
            // Clear and populate the DataGridView
            dgvTables.Rows.Clear();
            foreach (var table in tables)
            {
                dgvTables.Rows.Add(table.Key, table.Value);
            }
        }

        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            // Get selected table number and status
            string tableNumber = cmbTableNumber.SelectedItem?.ToString();
            string tableStatus = cmbTableStatus.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(tableNumber) || string.IsNullOrWhiteSpace(tableStatus))
            {
                MessageBox.Show("Please select both a table number and status.");
                return;
            }

            // Update the table status
            if (tables.ContainsKey(tableNumber))
            {
                tables[tableNumber] = tableStatus;
                MessageBox.Show($"Table {tableNumber} status updated to {tableStatus}.");
                RefreshTablesGrid();
            }
            else
            {
                MessageBox.Show("Invalid table number selected.");
            }
        }

        private void cmbTableNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Display the current status of the selected table
            string selectedTable = cmbTableNumber.SelectedItem?.ToString();
            if (!string.IsNullOrWhiteSpace(selectedTable) && tables.ContainsKey(selectedTable))
            {
                cmbTableStatus.SelectedItem = tables[selectedTable];
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // Refresh the table grid
            RefreshTablesGrid();
        }
    }
}
