namespace EuroExplorer
{
    partial class Bułgaria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bułgaria));
            Opis = new Label();
            InfoBułgaria1 = new TextBox();
            InfoBułgaria = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            OpisBelgia = new TextBox();
            Back = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Opis
            // 
            Opis.AutoSize = true;
            Opis.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Opis.Location = new Point(1593, 175);
            Opis.Name = "Opis";
            Opis.Size = new Size(131, 32);
            Opis.TabIndex = 20;
            Opis.Text = "Opis Live :";
            // 
            // InfoBułgaria1
            // 
            InfoBułgaria1.BackColor = Color.FromArgb(255, 224, 192);
            InfoBułgaria1.Enabled = false;
            InfoBułgaria1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            InfoBułgaria1.Location = new Point(1429, 320);
            InfoBułgaria1.Multiline = true;
            InfoBułgaria1.Name = "InfoBułgaria1";
            InfoBułgaria1.Size = new Size(463, 67);
            InfoBułgaria1.TabIndex = 19;
            InfoBułgaria1.TextChanged += InfoBułgaria1_TextChanged;
            // 
            // InfoBułgaria
            // 
            InfoBułgaria.BackColor = Color.FromArgb(255, 224, 192);
            InfoBułgaria.Enabled = false;
            InfoBułgaria.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            InfoBułgaria.Location = new Point(1429, 247);
            InfoBułgaria.Multiline = true;
            InfoBułgaria.Name = "InfoBułgaria";
            InfoBułgaria.Size = new Size(463, 67);
            InfoBułgaria.TabIndex = 18;
            InfoBułgaria.TextChanged += InfoBułgaria_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.Location = new Point(1094, 175);
            label2.Name = "label2";
            label2.Size = new Size(155, 32);
            label2.TabIndex = 17;
            label2.Text = "Terytorium :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(383, 108);
            label1.Name = "label1";
            label1.Size = new Size(79, 32);
            label1.TabIndex = 16;
            label1.Text = "Opis :";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(955, 247);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(437, 238);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // OpisBelgia
            // 
            OpisBelgia.BackColor = Color.FromArgb(255, 224, 192);
            OpisBelgia.Enabled = false;
            OpisBelgia.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            OpisBelgia.Location = new Point(12, 175);
            OpisBelgia.Multiline = true;
            OpisBelgia.Name = "OpisBelgia";
            OpisBelgia.Size = new Size(841, 427);
            OpisBelgia.TabIndex = 14;
            OpisBelgia.Text = resources.GetString("OpisBelgia.Text");
            // 
            // Back
            // 
            Back.BackColor = Color.FromArgb(255, 255, 192);
            Back.Location = new Point(12, 12);
            Back.Name = "Back";
            Back.Size = new Size(75, 23);
            Back.TabIndex = 21;
            Back.Text = "Powrót";
            Back.UseVisualStyleBackColor = false;
            Back.Click += Back_Click;
            // 
            // Bułgaria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(1904, 1041);
            Controls.Add(Back);
            Controls.Add(Opis);
            Controls.Add(InfoBułgaria1);
            Controls.Add(InfoBułgaria);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(OpisBelgia);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Bułgaria";
            Text = "Bułgaria";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Opis;
        protected TextBox InfoBułgaria1;
        protected TextBox InfoBułgaria;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        protected TextBox OpisBelgia;
        private Button Back;
    }
}