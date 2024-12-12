namespace Restaurant_Management_System
{
    partial class OrdersForm
    {
        private System.ComponentModel.IContainer components = null;

        private TextBox txtTableNumber;
        private ComboBox cmbMenuItems;
        private NumericUpDown numQuantity;
        private Button btnAddOrder;
        private Button btnMarkCompleted;
        private Button btnRefreshOrders;
        private DataGridView dgvOrders;

        private void InitializeComponent()
        {
            txtTableNumber = new TextBox();
            cmbMenuItems = new ComboBox();
            numQuantity = new NumericUpDown();
            btnAddOrder = new Button();
            btnMarkCompleted = new Button();
            btnRefreshOrders = new Button();
            dgvOrders = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            Category = new Label();
            Quantity = new Label();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            SuspendLayout();
            // 
            // txtTableNumber
            // 
            txtTableNumber.Location = new Point(286, 37);
            txtTableNumber.Name = "txtTableNumber";
            txtTableNumber.PlaceholderText = "Table Number";
            txtTableNumber.Size = new Size(200, 39);
            txtTableNumber.TabIndex = 0;
            // 
            // cmbMenuItems
            // 
            cmbMenuItems.Location = new Point(286, 112);
            cmbMenuItems.Name = "cmbMenuItems";
            cmbMenuItems.Size = new Size(200, 40);
            cmbMenuItems.TabIndex = 1;
            // 
            // numQuantity
            // 
            numQuantity.AccessibleRole = AccessibleRole.None;
            numQuantity.Location = new Point(286, 185);
            numQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(200, 39);
            numQuantity.TabIndex = 2;
            numQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAddOrder
            // 
            btnAddOrder.Location = new Point(77, 273);
            btnAddOrder.Name = "btnAddOrder";
            btnAddOrder.Size = new Size(100, 56);
            btnAddOrder.TabIndex = 3;
            btnAddOrder.Text = "Add New Order";
            btnAddOrder.Click += btnAddOrder_Click;
            // 
            // btnMarkCompleted
            // 
            btnMarkCompleted.Location = new Point(97, 357);
            btnMarkCompleted.Name = "btnMarkCompleted";
            btnMarkCompleted.Size = new Size(204, 56);
            btnMarkCompleted.TabIndex = 4;
            btnMarkCompleted.Text = "Completed";
            btnMarkCompleted.Click += btnMarkCompleted_Click;
            // 
            // btnRefreshOrders
            // 
            btnRefreshOrders.Location = new Point(936, 597);
            btnRefreshOrders.Name = "btnRefreshOrders";
            btnRefreshOrders.Size = new Size(163, 65);
            btnRefreshOrders.TabIndex = 5;
            btnRefreshOrders.Text = "Refresh";
            btnRefreshOrders.Click += btnRefreshOrders_Click;
            // 
            // dgvOrders
            // 
            dgvOrders.ColumnHeadersHeight = 46;
            dgvOrders.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5 });
            dgvOrders.Location = new Point(547, 42);
            dgvOrders.Name = "dgvOrders";
            dgvOrders.ReadOnly = true;
            dgvOrders.RowHeadersWidth = 82;
            dgvOrders.Size = new Size(886, 429);
            dgvOrders.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.MinimumWidth = 10;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.MinimumWidth = 10;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.MinimumWidth = 10;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.MinimumWidth = 10;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Width = 200;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.MinimumWidth = 10;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            dataGridViewTextBoxColumn5.Width = 200;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 37);
            label1.Name = "label1";
            label1.Size = new Size(164, 32);
            label1.TabIndex = 7;
            label1.Text = "Table Number";
            // 
            // Category
            // 
            Category.AutoSize = true;
            Category.Location = new Point(80, 114);
            Category.Name = "Category";
            Category.Size = new Size(110, 32);
            Category.TabIndex = 8;
            Category.Text = "Category";
            // 
            // Quantity
            // 
            Quantity.AutoSize = true;
            Quantity.Location = new Point(97, 190);
            Quantity.Name = "Quantity";
            Quantity.Size = new Size(106, 32);
            Quantity.TabIndex = 9;
            Quantity.Text = "Quantity";
            Quantity.TextAlign = ContentAlignment.TopRight;
            // 
            // OrdersForm
            // 
            ClientSize = new Size(1467, 744);
            Controls.Add(Quantity);
            Controls.Add(Category);
            Controls.Add(label1);
            Controls.Add(txtTableNumber);
            Controls.Add(cmbMenuItems);
            Controls.Add(numQuantity);
            Controls.Add(btnAddOrder);
            Controls.Add(btnMarkCompleted);
            Controls.Add(btnRefreshOrders);
            Controls.Add(dgvOrders);
            Name = "OrdersForm";
            Text = "Order Management";
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private Label label1;
        private Label Category;
        private Label Quantity;
    }
}
