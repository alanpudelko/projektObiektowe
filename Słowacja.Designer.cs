namespace EuroExplorer
{
    partial class Słowacja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Słowacja));
            Back = new Button();
            Opis = new Label();
            InfoSłowacja1 = new TextBox();
            InfoSłowacja = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            OpisSłowacja = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Back
            // 
            Back.BackColor = Color.White;
            Back.Location = new Point(12, 15);
            Back.Name = "Back";
            Back.Size = new Size(75, 23);
            Back.TabIndex = 159;
            Back.Text = "Powrót";
            Back.UseVisualStyleBackColor = false;
            Back.Click += Back_Click;
            // 
            // Opis
            // 
            Opis.AutoSize = true;
            Opis.BackColor = Color.Transparent;
            Opis.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Opis.ForeColor = SystemColors.Menu;
            Opis.Location = new Point(1593, 279);
            Opis.Name = "Opis";
            Opis.Size = new Size(131, 32);
            Opis.TabIndex = 158;
            Opis.Text = "Opis Live :";
            // 
            // InfoSłowacja1
            // 
            InfoSłowacja1.BackColor = Color.White;
            InfoSłowacja1.Enabled = false;
            InfoSłowacja1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            InfoSłowacja1.Location = new Point(1429, 424);
            InfoSłowacja1.Multiline = true;
            InfoSłowacja1.Name = "InfoSłowacja1";
            InfoSłowacja1.Size = new Size(463, 67);
            InfoSłowacja1.TabIndex = 157;
            InfoSłowacja1.TextChanged += InfoSłowacja1_TextChanged;
            // 
            // InfoSłowacja
            // 
            InfoSłowacja.BackColor = Color.White;
            InfoSłowacja.Enabled = false;
            InfoSłowacja.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            InfoSłowacja.Location = new Point(1429, 351);
            InfoSłowacja.Multiline = true;
            InfoSłowacja.Name = "InfoSłowacja";
            InfoSłowacja.Size = new Size(463, 67);
            InfoSłowacja.TabIndex = 156;
            InfoSłowacja.TextChanged += InfoSłowacja_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.ForeColor = SystemColors.Menu;
            label2.Location = new Point(1094, 279);
            label2.Name = "label2";
            label2.Size = new Size(155, 32);
            label2.TabIndex = 155;
            label2.Text = "Terytorium :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = SystemColors.Menu;
            label1.Location = new Point(383, 212);
            label1.Name = "label1";
            label1.Size = new Size(79, 32);
            label1.TabIndex = 154;
            label1.Text = "Opis :";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(955, 351);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(437, 238);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 153;
            pictureBox1.TabStop = false;
            // 
            // OpisSłowacja
            // 
            OpisSłowacja.BackColor = Color.White;
            OpisSłowacja.Enabled = false;
            OpisSłowacja.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            OpisSłowacja.Location = new Point(12, 276);
            OpisSłowacja.Multiline = true;
            OpisSłowacja.Name = "OpisSłowacja";
            OpisSłowacja.Size = new Size(841, 651);
            OpisSłowacja.TabIndex = 152;
            OpisSłowacja.Text = resources.GetString("OpisSłowacja.Text");
            // 
            // Słowacja
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1904, 1041);
            Controls.Add(Back);
            Controls.Add(Opis);
            Controls.Add(InfoSłowacja1);
            Controls.Add(InfoSłowacja);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(OpisSłowacja);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Słowacja";
            Text = "Słowacja";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Back;
        private Label Opis;
        protected TextBox InfoSłowacja1;
        protected TextBox InfoSłowacja;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        protected TextBox OpisSłowacja;
    }
}