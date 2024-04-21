namespace EuroExplorer
{
    partial class FormS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormS));
            label1 = new Label();
            Słowacja = new Button();
            Słowenia = new Button();
            Szwecja = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(797, 9);
            label1.Name = "label1";
            label1.Size = new Size(556, 86);
            label1.TabIndex = 3;
            label1.Text = "Wybierz Państwo";
            // 
            // Słowacja
            // 
            Słowacja.BackColor = Color.FromArgb(255, 223, 192);
            Słowacja.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Słowacja.Image = (Image)resources.GetObject("Słowacja.Image");
            Słowacja.Location = new Point(308, 375);
            Słowacja.Name = "Słowacja";
            Słowacja.Size = new Size(248, 240);
            Słowacja.TabIndex = 4;
            Słowacja.Text = "Słowacja";
            Słowacja.UseVisualStyleBackColor = false;
            Słowacja.Click += Słowacja_Click;
            // 
            // Słowenia
            // 
            Słowenia.BackColor = Color.FromArgb(255, 223, 192);
            Słowenia.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Słowenia.Image = (Image)resources.GetObject("Słowenia.Image");
            Słowenia.Location = new Point(919, 375);
            Słowenia.Name = "Słowenia";
            Słowenia.Size = new Size(248, 240);
            Słowenia.TabIndex = 5;
            Słowenia.Text = "Słowenia";
            Słowenia.UseVisualStyleBackColor = false;
            Słowenia.Click += Słowenia_Click;
            // 
            // Szwecja
            // 
            Szwecja.BackColor = Color.FromArgb(255, 223, 192);
            Szwecja.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Szwecja.Image = (Image)resources.GetObject("Szwecja.Image");
            Szwecja.Location = new Point(1532, 375);
            Szwecja.Name = "Szwecja";
            Szwecja.Size = new Size(248, 240);
            Szwecja.TabIndex = 6;
            Szwecja.Text = "Szwecja";
            Szwecja.UseVisualStyleBackColor = false;
            Szwecja.Click += Szwecja_Click;
            // 
            // FormS
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(1904, 1041);
            Controls.Add(Szwecja);
            Controls.Add(Słowenia);
            Controls.Add(Słowacja);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormS";
            Text = "FormS";
            Load += FormS_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button Słowacja;
        private Button Słowenia;
        private Button Szwecja;
    }
}