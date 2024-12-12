namespace Restaurant_Management_System.forms
{
    partial class TablesForm
    {
        private System.ComponentModel.IContainer components = null;
        private ComboBox cmbTableNumber;
        private ComboBox cmbTableStatus;
        private DataGridView dgvTables;
        private Button btnUpdateStatus;
        private Button btnRefresh;

        private void InitializeComponent()
        {
            cmbTableNumber = new ComboBox();
            cmbTableStatus = new ComboBox();
            dgvTables = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            btnUpdateStatus = new Button();
            btnRefresh = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTables).BeginInit();
            SuspendLayout();
            // 
            // cmbTableNumber
            // 
            cmbTableNumber.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTableNumber.Location = new Point(301, 12);
            cmbTableNumber.Name = "cmbTableNumber";
            cmbTableNumber.Size = new Size(200, 40);
            cmbTableNumber.TabIndex = 0;
            cmbTableNumber.SelectedIndexChanged += cmbTableNumber_SelectedIndexChanged;
            // 
            // cmbTableStatus
            // 
            cmbTableStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTableStatus.Items.AddRange(new object[] { "Available", "Occupied", "Reserved" });
            cmbTableStatus.Location = new Point(301, 87);
            cmbTableStatus.Name = "cmbTableStatus";
            cmbTableStatus.Size = new Size(200, 40);
            cmbTableStatus.TabIndex = 1;
            // 
            // dgvTables
            // 
            dgvTables.ColumnHeadersHeight = 46;
            dgvTables.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2 });
            dgvTables.Location = new Point(650, 12);
            dgvTables.Name = "dgvTables";
            dgvTables.ReadOnly = true;
            dgvTables.RowHeadersWidth = 82;
            dgvTables.Size = new Size(500, 300);
            dgvTables.TabIndex = 2;
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
            // btnUpdateStatus
            // 
            btnUpdateStatus.Location = new Point(283, 196);
            btnUpdateStatus.Name = "btnUpdateStatus";
            btnUpdateStatus.Size = new Size(186, 65);
            btnUpdateStatus.TabIndex = 3;
            btnUpdateStatus.Text = "Update Status";
            btnUpdateStatus.Click += btnUpdateStatus_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(857, 379);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(267, 72);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "Refresh";
            btnRefresh.Click += btnRefresh_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(109, 20);
            label1.Name = "label1";
            label1.Size = new Size(123, 32);
            label1.TabIndex = 5;
            label1.Text = "table num";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(153, 94);
            label2.Name = "label2";
            label2.Size = new Size(76, 32);
            label2.TabIndex = 6;
            label2.Text = "status";
            // 
            // TablesForm
            // 
            ClientSize = new Size(1570, 485);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbTableNumber);
            Controls.Add(cmbTableStatus);
            Controls.Add(dgvTables);
            Controls.Add(btnUpdateStatus);
            Controls.Add(btnRefresh);
            Name = "TablesForm";
            Text = "Table Management";
            ((System.ComponentModel.ISupportInitialize)dgvTables).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private Label label1;
        private Label label2;
    }
}
