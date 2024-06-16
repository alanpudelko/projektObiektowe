namespace EuroExplorer
{
    partial class FormR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormR));
            label1 = new Label();
            Rumunia = new Button();
            Back = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = SystemColors.Menu;
            label1.Location = new Point(670, 9);
            label1.Name = "label1";
            label1.Size = new Size(556, 86);
            label1.TabIndex = 3;
            label1.Text = "Wybierz Państwo";
            // 
            // Rumunia
            // 
            Rumunia.BackColor = Color.FromArgb(255, 223, 192);
            Rumunia.BackgroundImage = (Image)resources.GetObject("Rumunia.BackgroundImage");
            Rumunia.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Rumunia.Image = (Image)resources.GetObject("Rumunia.Image");
            Rumunia.Location = new Point(834, 413);
            Rumunia.Name = "Rumunia";
            Rumunia.Size = new Size(248, 240);
            Rumunia.TabIndex = 4;
            Rumunia.Text = "Rumunia";
            Rumunia.UseVisualStyleBackColor = false;
            Rumunia.Click += Rumunia_Click;
            // 
            // Back
            // 
            Back.BackColor = Color.White;
            Back.Location = new Point(12, 12);
            Back.Name = "Back";
            Back.Size = new Size(75, 23);
            Back.TabIndex = 18;
            Back.Text = "Powrót";
            Back.UseVisualStyleBackColor = false;
            Back.Click += Back_Click;
            // 
            // FormR
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1904, 1041);
            Controls.Add(Back);
            Controls.Add(Rumunia);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormR";
            Text = "FormR";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button Rumunia;
        private Button Back;
    }
}