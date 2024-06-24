namespace EuroExplorer
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            usernameLabel = new Label();
            passwordLabel = new Label();
            usernameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            registerButton = new Button();
            switchToLoginButton = new Button();
            deleteAllUsersButton = new Button();
            SuspendLayout();
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.BackColor = Color.Transparent;
            usernameLabel.ForeColor = SystemColors.Menu;
            usernameLabel.Location = new Point(59, 46);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(48, 15);
            usernameLabel.TabIndex = 0;
            usernameLabel.Text = "Nazwa :";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.BackColor = Color.Transparent;
            passwordLabel.ForeColor = SystemColors.Menu;
            passwordLabel.Location = new Point(59, 98);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(43, 15);
            passwordLabel.TabIndex = 1;
            passwordLabel.Text = "Hasło :";
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(148, 46);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(123, 23);
            usernameTextBox.TabIndex = 2;
            usernameTextBox.TextChanged += usernameTextBox_TextChanged;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(148, 95);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(123, 23);
            passwordTextBox.TabIndex = 3;
            passwordTextBox.TextChanged += passwordTextBox_TextChanged;
            // 
            // registerButton
            // 
            registerButton.Location = new Point(59, 148);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(92, 29);
            registerButton.TabIndex = 5;
            registerButton.Text = "Rejestracja";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += registerButton_Click;
            // 
            // switchToLoginButton
            // 
            switchToLoginButton.Location = new Point(179, 148);
            switchToLoginButton.Name = "switchToLoginButton";
            switchToLoginButton.Size = new Size(92, 29);
            switchToLoginButton.TabIndex = 4;
            switchToLoginButton.Text = "Logowanie";
            switchToLoginButton.UseVisualStyleBackColor = true;
            switchToLoginButton.Click += loginButton_Click;
            // 
            // deleteAllUsersButton
            // 
            deleteAllUsersButton.Location = new Point(59, 220);
            deleteAllUsersButton.Name = "deleteAllUsersButton";
            deleteAllUsersButton.Size = new Size(212, 27);
            deleteAllUsersButton.TabIndex = 6;
            deleteAllUsersButton.Text = "Usuń wszystkich użytkowników";
            deleteAllUsersButton.UseVisualStyleBackColor = true;
            deleteAllUsersButton.Click += deleteAllUsersButton_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(deleteAllUsersButton);
            Controls.Add(registerButton);
            Controls.Add(switchToLoginButton);
            Controls.Add(passwordTextBox);
            Controls.Add(usernameTextBox);
            Controls.Add(passwordLabel);
            Controls.Add(usernameLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Register";
            Text = "Register";
            Load += Register_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label usernameLabel;
        private Label passwordLabel;
        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private Button registerButton;
        private Button switchToLoginButton;
        private Button deleteAllUsersButton;
    }
}