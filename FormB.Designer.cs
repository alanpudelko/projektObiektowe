namespace EuroExplorer
{
    partial class FormB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormB));
            label1 = new Label();
            Belgia = new Button();
            Bułgaria = new Button();
            Back = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(807, 9);
            label1.Name = "label1";
            label1.Size = new Size(556, 86);
            label1.TabIndex = 1;
            label1.Text = "Wybierz Państwo";
            // 
            // Belgia
            // 
            Belgia.BackColor = Color.FromArgb(255, 223, 192);
            Belgia.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Belgia.Image = (Image)resources.GetObject("Belgia.Image");
            Belgia.Location = new Point(342, 427);
            Belgia.Name = "Belgia";
            Belgia.Size = new Size(248, 240);
            Belgia.TabIndex = 2;
            Belgia.Text = "Belgia";
            Belgia.UseVisualStyleBackColor = false;
            Belgia.Click += Belgia_Click;
            // 
            // Bułgaria
            // 
            Bułgaria.BackColor = Color.FromArgb(255, 223, 192);
            Bułgaria.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Bułgaria.Image = (Image)resources.GetObject("Bułgaria.Image");
            Bułgaria.Location = new Point(1268, 427);
            Bułgaria.Name = "Bułgaria";
            Bułgaria.Size = new Size(248, 240);
            Bułgaria.TabIndex = 4;
            Bułgaria.Text = "Bułgaria";
            Bułgaria.UseVisualStyleBackColor = false;
            Bułgaria.Click += Bułgaria_Click;
            // 
            // Back
            // 
            Back.BackColor = Color.FromArgb(255, 255, 192);
            Back.Location = new Point(12, 12);
            Back.Name = "Back";
            Back.Size = new Size(75, 23);
            Back.TabIndex = 5;
            Back.Text = "Powrót";
            Back.UseVisualStyleBackColor = false;
            Back.Click += Back_Click;
            // 
            // FormB
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(1904, 1041);
            Controls.Add(Back);
            Controls.Add(Bułgaria);
            Controls.Add(Belgia);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormB";
            Text = "FormB";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button Belgia;
        private Button Bułgaria;
        private Button Back;
    }
}