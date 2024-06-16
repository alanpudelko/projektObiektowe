namespace EuroExplorer
{
    partial class Grecja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Grecja));
            Back = new Button();
            Opis = new Label();
            InfoGrecja1 = new TextBox();
            InfoGrecja = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            OpisGrecja = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Back
            // 
            Back.BackColor = Color.White;
            Back.Location = new Point(12, 13);
            Back.Name = "Back";
            Back.Size = new Size(75, 23);
            Back.TabIndex = 71;
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
            Opis.Location = new Point(1593, 277);
            Opis.Name = "Opis";
            Opis.Size = new Size(131, 32);
            Opis.TabIndex = 70;
            Opis.Text = "Opis Live :";
            // 
            // InfoGrecja1
            // 
            InfoGrecja1.BackColor = Color.White;
            InfoGrecja1.Enabled = false;
            InfoGrecja1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            InfoGrecja1.Location = new Point(1429, 422);
            InfoGrecja1.Multiline = true;
            InfoGrecja1.Name = "InfoGrecja1";
            InfoGrecja1.Size = new Size(463, 67);
            InfoGrecja1.TabIndex = 69;
            InfoGrecja1.TextChanged += InfoGrecja1_TextChanged;
            // 
            // InfoGrecja
            // 
            InfoGrecja.BackColor = Color.White;
            InfoGrecja.Enabled = false;
            InfoGrecja.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            InfoGrecja.Location = new Point(1429, 349);
            InfoGrecja.Multiline = true;
            InfoGrecja.Name = "InfoGrecja";
            InfoGrecja.Size = new Size(463, 67);
            InfoGrecja.TabIndex = 68;
            InfoGrecja.TextChanged += InfoGrecja_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.ForeColor = SystemColors.Menu;
            label2.Location = new Point(1094, 277);
            label2.Name = "label2";
            label2.Size = new Size(155, 32);
            label2.TabIndex = 67;
            label2.Text = "Terytorium :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = SystemColors.Menu;
            label1.Location = new Point(383, 210);
            label1.Name = "label1";
            label1.Size = new Size(79, 32);
            label1.TabIndex = 66;
            label1.Text = "Opis :";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(920, 349);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(472, 272);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 65;
            pictureBox1.TabStop = false;
            // 
            // OpisGrecja
            // 
            OpisGrecja.BackColor = Color.White;
            OpisGrecja.Enabled = false;
            OpisGrecja.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            OpisGrecja.Location = new Point(12, 277);
            OpisGrecja.Multiline = true;
            OpisGrecja.Name = "OpisGrecja";
            OpisGrecja.Size = new Size(841, 585);
            OpisGrecja.TabIndex = 64;
            OpisGrecja.Text = resources.GetString("OpisGrecja.Text");
            // 
            // Grecja
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1904, 1041);
            Controls.Add(Back);
            Controls.Add(Opis);
            Controls.Add(InfoGrecja1);
            Controls.Add(InfoGrecja);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(OpisGrecja);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Grecja";
            Text = "Grecja";
            Load += Grecja_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Back;
        private Label Opis;
        protected TextBox InfoGrecja1;
        protected TextBox InfoGrecja;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        protected TextBox OpisGrecja;
    }
}