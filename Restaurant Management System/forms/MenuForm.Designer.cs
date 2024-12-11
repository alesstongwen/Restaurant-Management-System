namespace Restaurant_Management_System.forms
{
    partial class MenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DishNameTextbox = new TextBox();
            DishName = new Label();
            comboBox1 = new ComboBox();
            Category = new Label();
            SuspendLayout();
            // 
            // DishNameTextbox
            // 
            DishNameTextbox.Location = new Point(260, 53);
            DishNameTextbox.Name = "DishNameTextbox";
            DishNameTextbox.Size = new Size(200, 39);
            DishNameTextbox.TabIndex = 0;
            // 
            // DishName
            // 
            DishName.AutoSize = true;
            DishName.Location = new Point(91, 58);
            DishName.Name = "DishName";
            DishName.Size = new Size(132, 32);
            DishName.TabIndex = 1;
            DishName.Text = "Dish Name";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(260, 144);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(242, 40);
            comboBox1.TabIndex = 2;
            // 
            // Category
            // 
            Category.AutoSize = true;
            Category.Location = new Point(115, 149);
            Category.Name = "Category";
            Category.Size = new Size(78, 32);
            Category.TabIndex = 3;
            Category.Text = "label1";
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Category);
            Controls.Add(comboBox1);
            Controls.Add(DishName);
            Controls.Add(DishNameTextbox);
            Name = "MenuForm";
            Text = "MenuForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox DishNameTextbox;
        private Label DishName;
        private ComboBox comboBox1;
        private Label Category;
    }
}