namespace EuroExplorer
{
    partial class Szwecja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Szwecja));
            Back = new Button();
            Opis = new Label();
            InfoSzwecja1 = new TextBox();
            InfoSzwecja = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            OpisSzwecja = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Back
            // 
            Back.BackColor = Color.FromArgb(255, 255, 192);
            Back.Location = new Point(12, 13);
            Back.Name = "Back";
            Back.Size = new Size(75, 23);
            Back.TabIndex = 175;
            Back.Text = "Powrót";
            Back.UseVisualStyleBackColor = false;
            Back.Click += Back_Click;
            // 
            // Opis
            // 
            Opis.AutoSize = true;
            Opis.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Opis.Location = new Point(1593, 277);
            Opis.Name = "Opis";
            Opis.Size = new Size(131, 32);
            Opis.TabIndex = 174;
            Opis.Text = "Opis Live :";
            // 
            // InfoSzwecja1
            // 
            InfoSzwecja1.BackColor = Color.FromArgb(255, 224, 192);
            InfoSzwecja1.Enabled = false;
            InfoSzwecja1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            InfoSzwecja1.Location = new Point(1429, 422);
            InfoSzwecja1.Multiline = true;
            InfoSzwecja1.Name = "InfoSzwecja1";
            InfoSzwecja1.Size = new Size(463, 67);
            InfoSzwecja1.TabIndex = 173;
            InfoSzwecja1.TextChanged += InfoSzwecja1_TextChanged;
            // 
            // InfoSzwecja
            // 
            InfoSzwecja.BackColor = Color.FromArgb(255, 224, 192);
            InfoSzwecja.Enabled = false;
            InfoSzwecja.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            InfoSzwecja.Location = new Point(1429, 349);
            InfoSzwecja.Multiline = true;
            InfoSzwecja.Name = "InfoSzwecja";
            InfoSzwecja.Size = new Size(463, 67);
            InfoSzwecja.TabIndex = 172;
            InfoSzwecja.TextChanged += InfoSzwecja_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.Location = new Point(1094, 277);
            label2.Name = "label2";
            label2.Size = new Size(155, 32);
            label2.TabIndex = 171;
            label2.Text = "Terytorium :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(383, 210);
            label1.Name = "label1";
            label1.Size = new Size(79, 32);
            label1.TabIndex = 170;
            label1.Text = "Opis :";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(955, 349);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(437, 561);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 169;
            pictureBox1.TabStop = false;
            // 
            // OpisSzwecja
            // 
            OpisSzwecja.BackColor = Color.FromArgb(255, 224, 192);
            OpisSzwecja.Enabled = false;
            OpisSzwecja.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            OpisSzwecja.Location = new Point(12, 274);
            OpisSzwecja.Multiline = true;
            OpisSzwecja.Name = "OpisSzwecja";
            OpisSzwecja.Size = new Size(841, 682);
            OpisSzwecja.TabIndex = 168;
            OpisSzwecja.Text = resources.GetString("OpisSzwecja.Text");
            // 
            // Szwecja
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(1904, 1041);
            Controls.Add(Back);
            Controls.Add(Opis);
            Controls.Add(InfoSzwecja1);
            Controls.Add(InfoSzwecja);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(OpisSzwecja);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Szwecja";
            Text = "Szwecja";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Back;
        private Label Opis;
        protected TextBox InfoSzwecja1;
        protected TextBox InfoSzwecja;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        protected TextBox OpisSzwecja;
    }
}