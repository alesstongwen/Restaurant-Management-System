namespace Restaurant_Management_System
{
    partial class DashboardForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnMenuManagement;
        private System.Windows.Forms.Button btnOrderManagement;
        private System.Windows.Forms.Button btnTableManagement;
        private System.Windows.Forms.Label lblWelcome;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            this.btnMenuManagement = new System.Windows.Forms.Button();
            this.btnOrderManagement = new System.Windows.Forms.Button();
            this.btnTableManagement = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // 
            // btnMenuManagement
            // 
            this.btnMenuManagement.Location = new System.Drawing.Point(100, 150);
            this.btnMenuManagement.Name = "btnMenuManagement";
            this.btnMenuManagement.Size = new System.Drawing.Size(150, 50);
            this.btnMenuManagement.Text = "Menu Management";
            this.btnMenuManagement.UseVisualStyleBackColor = true;
            this.btnMenuManagement.Click += new System.EventHandler(this.btnMenuManagement_Click);

            // 
            // btnOrderManagement
            // 
            this.btnOrderManagement.Location = new System.Drawing.Point(300, 150);
            this.btnOrderManagement.Name = "btnOrderManagement";
            this.btnOrderManagement.Size = new System.Drawing.Size(150, 50);
            this.btnOrderManagement.Text = "Order Management";
            this.btnOrderManagement.UseVisualStyleBackColor = true;
            this.btnOrderManagement.Click += new System.EventHandler(this.btnOrderManagement_Click);

            // 
            // btnTableManagement
            // 
            this.btnTableManagement.Location = new System.Drawing.Point(500, 150);
            this.btnTableManagement.Name = "btnTableManagement";
            this.btnTableManagement.Size = new System.Drawing.Size(150, 50);
            this.btnTableManagement.Text = "Table Management";
            this.btnTableManagement.UseVisualStyleBackColor = true;
            this.btnTableManagement.Click += new System.EventHandler(this.btnTableManagement_Click);

            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(50, 50);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(200, 32);
            this.lblWelcome.Text = "Welcome, User";

            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMenuManagement);
            this.Controls.Add(this.btnOrderManagement);
            this.Controls.Add(this.btnTableManagement);
            this.Controls.Add(this.lblWelcome);
            this.Name = "DashboardForm";
            this.Text = "DashboardForm";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
