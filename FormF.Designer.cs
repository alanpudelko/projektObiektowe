namespace EuroExplorer
{
    partial class FormF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormF));
            label1 = new Label();
            Finlandia = new Button();
            Francja = new Button();
            Back = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = SystemColors.Menu;
            label1.Location = new Point(673, 9);
            label1.Name = "label1";
            label1.Size = new Size(556, 86);
            label1.TabIndex = 3;
            label1.Text = "Wybierz Państwo";
            // 
            // Finlandia
            // 
            Finlandia.BackColor = Color.FromArgb(255, 223, 192);
            Finlandia.BackgroundImage = (Image)resources.GetObject("Finlandia.BackgroundImage");
            Finlandia.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Finlandia.Image = (Image)resources.GetObject("Finlandia.Image");
            Finlandia.Location = new Point(603, 416);
            Finlandia.Name = "Finlandia";
            Finlandia.Size = new Size(248, 240);
            Finlandia.TabIndex = 4;
            Finlandia.Text = "Finlandia";
            Finlandia.UseVisualStyleBackColor = false;
            Finlandia.Click += Dania_Click;
            // 
            // Francja
            // 
            Francja.BackColor = Color.FromArgb(255, 223, 192);
            Francja.BackgroundImage = (Image)resources.GetObject("Francja.BackgroundImage");
            Francja.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Francja.Image = (Image)resources.GetObject("Francja.Image");
            Francja.Location = new Point(1041, 416);
            Francja.Name = "Francja";
            Francja.Size = new Size(248, 240);
            Francja.TabIndex = 5;
            Francja.Text = "Francja";
            Francja.UseVisualStyleBackColor = false;
            Francja.Click += Francja_Click;
            // 
            // Back
            // 
            Back.BackColor = Color.White;
            Back.Location = new Point(12, 12);
            Back.Name = "Back";
            Back.Size = new Size(75, 23);
            Back.TabIndex = 10;
            Back.Text = "Powrót";
            Back.UseVisualStyleBackColor = false;
            Back.Click += Back_Click;
            // 
            // FormF
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1904, 1041);
            Controls.Add(Back);
            Controls.Add(Francja);
            Controls.Add(Finlandia);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormF";
            Text = "FormF";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button Finlandia;
        private Button Francja;
        private Button Back;
    }
}