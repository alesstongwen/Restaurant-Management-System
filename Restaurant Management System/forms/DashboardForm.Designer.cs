namespace Restaurant_Management_System.forms
{
    partial class DashboardForm
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
            TodayRevenue = new GroupBox();
            Dashboard = new Label();
            PendingOrders = new GroupBox();
            SuspendLayout();
            // 
            // TodayRevenue
            // 
            TodayRevenue.Location = new Point(126, 175);
            TodayRevenue.Name = "TodayRevenue";
            TodayRevenue.Size = new Size(400, 200);
            TodayRevenue.TabIndex = 0;
            TodayRevenue.TabStop = false;
            TodayRevenue.Text = "Today's Revenue";
            // 
            // Dashboard
            // 
            Dashboard.AutoSize = true;
            Dashboard.Location = new Point(137, 67);
            Dashboard.Name = "Dashboard";
            Dashboard.Size = new Size(129, 32);
            Dashboard.TabIndex = 1;
            Dashboard.Text = "Dashboard";
            // 
            // PendingOrders
            // 
            PendingOrders.Location = new Point(614, 175);
            PendingOrders.Name = "PendingOrders";
            PendingOrders.Size = new Size(400, 200);
            PendingOrders.TabIndex = 2;
            PendingOrders.TabStop = false;
            PendingOrders.Text = "Pending Orders";
            PendingOrders.UseWaitCursor = true;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1452, 897);
            Controls.Add(PendingOrders);
            Controls.Add(Dashboard);
            Controls.Add(TodayRevenue);
            Name = "DashboardForm";
            Text = "DashboardForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox TodayRevenue;
        private Label Dashboard;
        private GroupBox PendingOrders;
    }
}