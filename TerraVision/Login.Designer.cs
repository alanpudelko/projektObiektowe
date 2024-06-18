using System.ComponentModel;

namespace TerraVision
{
    partial class Login
    {
        private IContainer components = null;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Login";

            var usernameLabel = new System.Windows.Forms.Label();
            usernameLabel.Text = "Username:";
            usernameLabel.Location = new System.Drawing.Point(50, 50);
            this.usernameTextBox.Location = new System.Drawing.Point(150, 50);

            var passwordLabel = new System.Windows.Forms.Label();
            passwordLabel.Text = "Password:";
            passwordLabel.Location = new System.Drawing.Point(50, 100);
            this.passwordTextBox.Location = new System.Drawing.Point(150, 100);
            this.passwordTextBox.PasswordChar = '*';

            var loginButton = new System.Windows.Forms.Button();
            loginButton.Text = "Zaloguj się";
            loginButton.Location = new System.Drawing.Point(50, 150);
            loginButton.Size = new System.Drawing.Size(200, loginButton.Height);
            loginButton.Click += LoginButton_Click;

            var switchToRegisterButton = new System.Windows.Forms.Button();
            switchToRegisterButton.Text = "Przejdź do rejestracji";
            switchToRegisterButton.Location = new System.Drawing.Point(260, 150);
            switchToRegisterButton.Size = new System.Drawing.Size(200, switchToRegisterButton.Height);
            switchToRegisterButton.Click += SwitchToRegisterButton_Click;

            this.Controls.Add(usernameLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(loginButton);
            this.Controls.Add(switchToRegisterButton);
        }

        #endregion
    }
}