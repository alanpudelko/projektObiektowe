namespace EuroExplorer
{
    partial class FormŁ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormŁ));
            label1 = new Label();
            Łotwa = new Button();
            Back = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = SystemColors.Menu;
            label1.Location = new Point(667, 9);
            label1.Name = "label1";
            label1.Size = new Size(556, 86);
            label1.TabIndex = 3;
            label1.Text = "Wybierz Państwo";
            // 
            // Łotwa
            // 
            Łotwa.AutoSize = true;
            Łotwa.BackColor = Color.FromArgb(255, 223, 192);
            Łotwa.BackgroundImage = (Image)resources.GetObject("Łotwa.BackgroundImage");
            Łotwa.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Łotwa.Image = (Image)resources.GetObject("Łotwa.Image");
            Łotwa.Location = new Point(821, 413);
            Łotwa.Name = "Łotwa";
            Łotwa.Size = new Size(253, 240);
            Łotwa.TabIndex = 4;
            Łotwa.Text = "Łotwa";
            Łotwa.UseVisualStyleBackColor = false;
            Łotwa.Click += Łotwa_Click;
            // 
            // Back
            // 
            Back.BackColor = Color.White;
            Back.Location = new Point(12, 12);
            Back.Name = "Back";
            Back.Size = new Size(75, 23);
            Back.TabIndex = 14;
            Back.Text = "Powrót";
            Back.UseVisualStyleBackColor = false;
            Back.Click += Back_Click;
            // 
            // FormŁ
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1904, 1041);
            Controls.Add(Back);
            Controls.Add(Łotwa);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormŁ";
            Text = "FormŁ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button Łotwa;
        private Button Back;
    }
}