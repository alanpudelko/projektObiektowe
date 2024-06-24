namespace EuroExplorer
{
    partial class Rumunia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rumunia));
            Back = new Button();
            Opis = new Label();
            InfoRumunia1 = new TextBox();
            InfoRumunia = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            OpisRumunia = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Back
            // 
            Back.BackColor = Color.White;
            Back.Location = new Point(12, 15);
            Back.Name = "Back";
            Back.Size = new Size(75, 23);
            Back.TabIndex = 151;
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
            Opis.TabIndex = 150;
            Opis.Text = "Opis Live :";
            // 
            // InfoRumunia1
            // 
            InfoRumunia1.BackColor = Color.White;
            InfoRumunia1.Enabled = false;
            InfoRumunia1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            InfoRumunia1.Location = new Point(1429, 424);
            InfoRumunia1.Multiline = true;
            InfoRumunia1.Name = "InfoRumunia1";
            InfoRumunia1.Size = new Size(463, 67);
            InfoRumunia1.TabIndex = 149;
            InfoRumunia1.TextChanged += InfoRumunia1_TextChanged;
            // 
            // InfoRumunia
            // 
            InfoRumunia.BackColor = Color.White;
            InfoRumunia.Enabled = false;
            InfoRumunia.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            InfoRumunia.Location = new Point(1429, 351);
            InfoRumunia.Multiline = true;
            InfoRumunia.Name = "InfoRumunia";
            InfoRumunia.Size = new Size(463, 67);
            InfoRumunia.TabIndex = 148;
            InfoRumunia.TextChanged += InfoRumunia_TextChanged;
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
            label2.TabIndex = 147;
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
            label1.TabIndex = 146;
            label1.Text = "Opis :";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(955, 351);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(437, 238);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 145;
            pictureBox1.TabStop = false;
            // 
            // OpisRumunia
            // 
            OpisRumunia.BackColor = Color.White;
            OpisRumunia.Enabled = false;
            OpisRumunia.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            OpisRumunia.Location = new Point(12, 276);
            OpisRumunia.Multiline = true;
            OpisRumunia.Name = "OpisRumunia";
            OpisRumunia.Size = new Size(841, 684);
            OpisRumunia.TabIndex = 144;
            OpisRumunia.Text = resources.GetString("OpisRumunia.Text");
            // 
            // Rumunia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1904, 1041);
            Controls.Add(Back);
            Controls.Add(Opis);
            Controls.Add(InfoRumunia1);
            Controls.Add(InfoRumunia);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(OpisRumunia);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Rumunia";
            Text = "Rumunia";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Back;
        private Label Opis;
        protected TextBox InfoRumunia1;
        protected TextBox InfoRumunia;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        protected TextBox OpisRumunia;
    }
}