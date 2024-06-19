using System.ComponentModel;

namespace TerraVision
{
    partial class Register
    {
        private IContainer components = null;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button deleteAllUsersButton;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.registerButton = new System.Windows.Forms.Button();
            this.switchToLoginButton = new System.Windows.Forms.Button();
            this.deleteAllUsersButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(150, 50);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(100, 20);
            this.usernameTextBox.TabIndex = 2;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(150, 100);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(100, 20);
            this.passwordTextBox.TabIndex = 4;
            // 
            // usernameLabel
            // 
            this.usernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.usernameLabel.ForeColor = System.Drawing.SystemColors.Menu;
            this.usernameLabel.Location = new System.Drawing.Point(50, 50);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(100, 23);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "Nazwa :";
            this.usernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passwordLabel
            // 
            this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabel.ForeColor = System.Drawing.SystemColors.Menu;
            this.passwordLabel.Location = new System.Drawing.Point(50, 100);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(100, 23);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Hasło :";
            this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(50, 150);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(100, 23);
            this.registerButton.TabIndex = 5;
            this.registerButton.Text = "Zarejestruj się";
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click_1);
            // 
            // switchToLoginButton
            // 
            this.switchToLoginButton.Location = new System.Drawing.Point(156, 150);
            this.switchToLoginButton.Name = "switchToLoginButton";
            this.switchToLoginButton.Size = new System.Drawing.Size(94, 23);
            this.switchToLoginButton.TabIndex = 6;
            this.switchToLoginButton.Text = "Logowanie";
            this.switchToLoginButton.Click += new System.EventHandler(this.switchToLoginButton_Click_1);
            // 
            // deleteAllUsersButton
            // 
            this.deleteAllUsersButton.Location = new System.Drawing.Point(50, 218);
            this.deleteAllUsersButton.Name = "deleteAllUsersButton";
            this.deleteAllUsersButton.Size = new System.Drawing.Size(200, 32);
            this.deleteAllUsersButton.TabIndex = 0;
            this.deleteAllUsersButton.Text = "Usuń wszystkich użytkowników";
            this.deleteAllUsersButton.Click += new System.EventHandler(this.deleteAllUsersButton_Click_1);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deleteAllUsersButton);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.switchToLoginButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button switchToLoginButton;
    }
}