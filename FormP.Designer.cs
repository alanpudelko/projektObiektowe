namespace EuroExplorer
{
    partial class FormP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormP));
            label1 = new Label();
            Polska = new Button();
            Portugalia = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(763, 9);
            label1.Name = "label1";
            label1.Size = new Size(556, 86);
            label1.TabIndex = 3;
            label1.Text = "Wybierz Państwo";
            // 
            // Polska
            // 
            Polska.BackColor = Color.FromArgb(255, 223, 192);
            Polska.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Polska.Image = (Image)resources.GetObject("Polska.Image");
            Polska.Location = new Point(513, 393);
            Polska.Name = "Polska";
            Polska.Size = new Size(248, 240);
            Polska.TabIndex = 4;
            Polska.Text = "Polska";
            Polska.UseVisualStyleBackColor = false;
            Polska.Click += Polska_Click;
            // 
            // Portugalia
            // 
            Portugalia.BackColor = Color.FromArgb(255, 223, 192);
            Portugalia.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Portugalia.Image = (Image)resources.GetObject("Portugalia.Image");
            Portugalia.Location = new Point(1314, 393);
            Portugalia.Name = "Portugalia";
            Portugalia.Size = new Size(248, 240);
            Portugalia.TabIndex = 5;
            Portugalia.Text = "Portugalia";
            Portugalia.UseVisualStyleBackColor = false;
            Portugalia.Click += Portugalia_Click;
            // 
            // FormP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(1904, 1041);
            Controls.Add(Portugalia);
            Controls.Add(Polska);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormP";
            Text = "FormP";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button Polska;
        private Button Portugalia;
    }
}