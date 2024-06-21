namespace EuroExplorer
{
    partial class Start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            loginButton = new Button();
            registerButton = new Button();
            SuspendLayout();
            // 
            // loginButton
            // 
            loginButton.Location = new Point(324, 134);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(115, 42);
            loginButton.TabIndex = 0;
            loginButton.Text = "Logowanie";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // registerButton
            // 
            registerButton.Location = new Point(324, 245);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(115, 42);
            registerButton.TabIndex = 1;
            registerButton.Text = "Rejestracja";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += registerButton_Click;
            // 
            // Start
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(registerButton);
            Controls.Add(loginButton);
            Name = "Start";
            Text = "Start";
            ResumeLayout(false);
        }

        #endregion

        private Button loginButton;
        private Button registerButton;
    }
}