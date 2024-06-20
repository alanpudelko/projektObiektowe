namespace EuroExplorer
{
    partial class Login
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
            switchToRegisterButton = new Button();
            loginButton = new Button();
            passwordTextBox = new TextBox();
            usernameTextBox = new TextBox();
            passwordLabel = new Label();
            usernameLabel = new Label();
            SuspendLayout();
            // 
            // switchToRegisterButton
            // 
            switchToRegisterButton.Location = new Point(209, 172);
            switchToRegisterButton.Name = "switchToRegisterButton";
            switchToRegisterButton.Size = new Size(92, 29);
            switchToRegisterButton.TabIndex = 11;
            switchToRegisterButton.Text = "Rejestracja";
            switchToRegisterButton.UseVisualStyleBackColor = true;
            switchToRegisterButton.Click += switchToRegisterButton_Click;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(89, 172);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(92, 29);
            loginButton.TabIndex = 10;
            loginButton.Text = "Zaloguj się";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(178, 121);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(123, 23);
            passwordTextBox.TabIndex = 9;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(178, 72);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(123, 23);
            usernameTextBox.TabIndex = 8;
            usernameTextBox.TextChanged += usernameTextBox_TextChanged;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(89, 124);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(43, 15);
            passwordLabel.TabIndex = 7;
            passwordLabel.Text = "Hasło :";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(89, 72);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(48, 15);
            usernameLabel.TabIndex = 6;
            usernameLabel.Text = "Nazwa :";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(switchToRegisterButton);
            Controls.Add(loginButton);
            Controls.Add(passwordTextBox);
            Controls.Add(usernameTextBox);
            Controls.Add(passwordLabel);
            Controls.Add(usernameLabel);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button switchToRegisterButton;
        private Button loginButton;
        private TextBox passwordTextBox;
        private TextBox usernameTextBox;
        private Label passwordLabel;
        private Label usernameLabel;
    }
}