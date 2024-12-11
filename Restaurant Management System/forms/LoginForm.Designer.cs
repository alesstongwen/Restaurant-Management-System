namespace Restaurant_Management_System
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            usernameTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            passwordTextBox = new TextBox();
            comboBox1 = new ComboBox();
            Role = new Label();
            LoginButton = new Button();
            SuspendLayout();
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(242, 133);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(200, 39);
            usernameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(90, 133);
            label1.Name = "label1";
            label1.Size = new Size(121, 32);
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(100, 193);
            label2.Name = "label2";
            label2.Size = new Size(111, 32);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(259, 193);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(200, 39);
            passwordTextBox.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(259, 268);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(242, 40);
            comboBox1.TabIndex = 4;
            // 
            // Role
            // 
            Role.AutoSize = true;
            Role.Location = new Point(90, 268);
            Role.Name = "Role";
            Role.Size = new Size(145, 32);
            Role.TabIndex = 5;
            Role.Text = "Select a role";
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(184, 332);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(150, 46);
            LoginButton.TabIndex = 6;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LoginButton);
            Controls.Add(Role);
            Controls.Add(comboBox1);
            Controls.Add(passwordTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(usernameTextBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox usernameTextBox;
        private Label label1;
        private Label label2;
        private TextBox passwordTextBox;
        private ComboBox comboBox1;
        private Label Role;
        private Button LoginButton;
    }
}
