namespace EuroExplorer
{
    partial class Francja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Francja));
            Opis = new Label();
            InfoFrancja1 = new TextBox();
            InfoFrancja = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            OpisFrancja = new TextBox();
            Back = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Opis
            // 
            Opis.AutoSize = true;
            Opis.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Opis.Location = new Point(1593, 276);
            Opis.Name = "Opis";
            Opis.Size = new Size(131, 32);
            Opis.TabIndex = 62;
            Opis.Text = "Opis Live :";
            // 
            // InfoFrancja1
            // 
            InfoFrancja1.BackColor = Color.FromArgb(255, 224, 192);
            InfoFrancja1.Enabled = false;
            InfoFrancja1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            InfoFrancja1.Location = new Point(1429, 421);
            InfoFrancja1.Multiline = true;
            InfoFrancja1.Name = "InfoFrancja1";
            InfoFrancja1.Size = new Size(463, 67);
            InfoFrancja1.TabIndex = 61;
            InfoFrancja1.TextChanged += InfoFrancja1_TextChanged;
            // 
            // InfoFrancja
            // 
            InfoFrancja.BackColor = Color.FromArgb(255, 224, 192);
            InfoFrancja.Enabled = false;
            InfoFrancja.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            InfoFrancja.Location = new Point(1429, 348);
            InfoFrancja.Multiline = true;
            InfoFrancja.Name = "InfoFrancja";
            InfoFrancja.Size = new Size(463, 67);
            InfoFrancja.TabIndex = 60;
            InfoFrancja.TextChanged += InfoFrancja_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.Location = new Point(1094, 276);
            label2.Name = "label2";
            label2.Size = new Size(155, 32);
            label2.TabIndex = 59;
            label2.Text = "Terytorium :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(383, 209);
            label1.Name = "label1";
            label1.Size = new Size(79, 32);
            label1.TabIndex = 58;
            label1.Text = "Opis :";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(955, 348);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(437, 238);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 57;
            pictureBox1.TabStop = false;
            // 
            // OpisFrancja
            // 
            OpisFrancja.BackColor = Color.FromArgb(255, 224, 192);
            OpisFrancja.Enabled = false;
            OpisFrancja.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            OpisFrancja.Location = new Point(12, 276);
            OpisFrancja.Multiline = true;
            OpisFrancja.Name = "OpisFrancja";
            OpisFrancja.Size = new Size(841, 585);
            OpisFrancja.TabIndex = 56;
            OpisFrancja.Text = resources.GetString("OpisFrancja.Text");
            // 
            // Back
            // 
            Back.BackColor = Color.FromArgb(255, 255, 192);
            Back.Location = new Point(12, 12);
            Back.Name = "Back";
            Back.Size = new Size(75, 23);
            Back.TabIndex = 63;
            Back.Text = "Powrót";
            Back.UseVisualStyleBackColor = false;
            Back.Click += Back_Click;
            // 
            // Francja
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(1904, 1041);
            Controls.Add(Back);
            Controls.Add(Opis);
            Controls.Add(InfoFrancja1);
            Controls.Add(InfoFrancja);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(OpisFrancja);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Francja";
            Text = "Francja";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Opis;
        protected TextBox InfoFrancja1;
        protected TextBox InfoFrancja;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        protected TextBox OpisFrancja;
        private Button Back;
    }
}