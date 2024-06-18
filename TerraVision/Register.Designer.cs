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
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Register";

            var usernameLabel = new System.Windows.Forms.Label();
            usernameLabel.Text = "Username:";
            usernameLabel.Location = new System.Drawing.Point(50, 50);
            this.usernameTextBox.Location = new System.Drawing.Point(150, 50);

            var passwordLabel = new System.Windows.Forms.Label();
            passwordLabel.Text = "Password:";
            passwordLabel.Location = new System.Drawing.Point(50, 100);
            this.passwordTextBox.Location = new System.Drawing.Point(150, 100);
            this.passwordTextBox.PasswordChar = '*';

            var registerButton = new System.Windows.Forms.Button();
            registerButton.Text = "Zarejestruj się";
            registerButton.Location = new System.Drawing.Point(50, 150);
            registerButton.Size = new System.Drawing.Size(200, registerButton.Height);
            registerButton.Click += RegisterButton_Click;

            var switchToLoginButton = new System.Windows.Forms.Button();
            switchToLoginButton.Text = "Przejdź do logowania";
            switchToLoginButton.Location = new System.Drawing.Point(260, 150);
            switchToLoginButton.Size = new System.Drawing.Size(200, switchToLoginButton.Height);
            switchToLoginButton.Click += SwitchToLoginButton_Click;

            this.deleteAllUsersButton = new System.Windows.Forms.Button();
            this.deleteAllUsersButton.Text = "Usuń wszystkich użytkowników";
            this.deleteAllUsersButton.Location = new System.Drawing.Point(50, 200);
            this.deleteAllUsersButton.Size = new System.Drawing.Size(200, deleteAllUsersButton.Height);
            this.deleteAllUsersButton.Click += DeleteAllUsersButton_Click;
            this.Controls.Add(deleteAllUsersButton);

            this.Controls.Add(usernameLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(registerButton);
            this.Controls.Add(switchToLoginButton);
        }
    }
}