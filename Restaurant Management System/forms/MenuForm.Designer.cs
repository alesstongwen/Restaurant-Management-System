namespace Restaurant_Management_System
{
    partial class MenuForm
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox dishNameTextBox;
        private ComboBox categoryComboBox;
        private NumericUpDown priceNumericUpDown;
        private CheckBox availabilityCheckBox;
        private Button addButton;
        private DataGridView menuDataGridView;

        private void InitializeComponent()
        {
            dishNameTextBox = new TextBox();
            categoryComboBox = new ComboBox();
            priceNumericUpDown = new NumericUpDown();
            availabilityCheckBox = new CheckBox();
            addButton = new Button();
            menuDataGridView = new DataGridView();
            dishName = new Label();
            category = new Label();
            Price = new Label();
            ((System.ComponentModel.ISupportInitialize)priceNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)menuDataGridView).BeginInit();
            SuspendLayout();
            // 
            // dishNameTextBox
            // 
            dishNameTextBox.Location = new Point(187, 35);
            dishNameTextBox.Name = "dishNameTextBox";
            dishNameTextBox.PlaceholderText = "Dish Name";
            dishNameTextBox.Size = new Size(200, 39);
            dishNameTextBox.TabIndex = 0;
            dishNameTextBox.TextChanged += dishNameTextBox_TextChanged;
            // 
            // categoryComboBox
            // 
            categoryComboBox.Location = new Point(187, 84);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(200, 40);
            categoryComboBox.TabIndex = 1;
            // 
            // priceNumericUpDown
            // 
            priceNumericUpDown.DecimalPlaces = 2;
            priceNumericUpDown.Location = new Point(187, 147);
            priceNumericUpDown.Name = "priceNumericUpDown";
            priceNumericUpDown.Size = new Size(200, 39);
            priceNumericUpDown.TabIndex = 2;
            // 
            // availabilityCheckBox
            // 
            availabilityCheckBox.Location = new Point(170, 214);
            availabilityCheckBox.Name = "availabilityCheckBox";
            availabilityCheckBox.Size = new Size(200, 30);
            availabilityCheckBox.TabIndex = 3;
            availabilityCheckBox.Text = "Available";
            // 
            // addButton
            // 
            addButton.Location = new Point(219, 289);
            addButton.Name = "addButton";
            addButton.Size = new Size(100, 43);
            addButton.TabIndex = 4;
            addButton.Text = "Add Item";
            addButton.Click += addButton_Click;
            // 
            // menuDataGridView
            // 
            menuDataGridView.AllowUserToAddRows = false;
            menuDataGridView.AllowUserToDeleteRows = false;
            menuDataGridView.ColumnHeadersHeight = 46;
            menuDataGridView.Location = new Point(496, 62);
            menuDataGridView.Name = "menuDataGridView";
            menuDataGridView.ReadOnly = true;
            menuDataGridView.RowHeadersWidth = 82;
            menuDataGridView.Size = new Size(500, 300);
            menuDataGridView.TabIndex = 5;
            // 
            // dishName
            // 
            dishName.AutoSize = true;
            dishName.Location = new Point(27, 35);
            dishName.Name = "dishName";
            dishName.Size = new Size(132, 32);
            dishName.TabIndex = 6;
            dishName.Text = "Dish Name";
            // 
            // category
            // 
            category.AutoSize = true;
            category.Location = new Point(49, 92);
            category.Name = "category";
            category.Size = new Size(110, 32);
            category.TabIndex = 7;
            category.Text = "Category";
            // 
            // Price
            // 
            Price.AutoSize = true;
            Price.Location = new Point(78, 157);
            Price.Name = "Price";
            Price.Size = new Size(65, 32);
            Price.TabIndex = 8;
            Price.Text = "Price";
            // 
            // MenuForm
            // 
            ClientSize = new Size(1145, 610);
            Controls.Add(Price);
            Controls.Add(category);
            Controls.Add(dishName);
            Controls.Add(dishNameTextBox);
            Controls.Add(categoryComboBox);
            Controls.Add(priceNumericUpDown);
            Controls.Add(availabilityCheckBox);
            Controls.Add(addButton);
            Controls.Add(menuDataGridView);
            Name = "MenuForm";
            Text = "Menu Management";
            Load += MenuForm_Load;
            ((System.ComponentModel.ISupportInitialize)priceNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)menuDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label dishName;
        private Label category;
        private Label Price;
    }
}
