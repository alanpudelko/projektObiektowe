namespace EuroExplorer
{
    partial class Dania
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dania));
            Opis = new Label();
            InfoDania1 = new TextBox();
            InfoDania = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            OpisDania = new TextBox();
            Back = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Opis
            // 
            Opis.AutoSize = true;
            Opis.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Opis.Location = new Point(1593, 295);
            Opis.Name = "Opis";
            Opis.Size = new Size(131, 32);
            Opis.TabIndex = 41;
            Opis.Text = "Opis Live :";
            // 
            // InfoDania1
            // 
            InfoDania1.BackColor = Color.FromArgb(255, 224, 192);
            InfoDania1.Enabled = false;
            InfoDania1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            InfoDania1.Location = new Point(1429, 440);
            InfoDania1.Multiline = true;
            InfoDania1.Name = "InfoDania1";
            InfoDania1.Size = new Size(463, 67);
            InfoDania1.TabIndex = 40;
            InfoDania1.TextChanged += InfoDania1_TextChanged;
            // 
            // InfoDania
            // 
            InfoDania.BackColor = Color.FromArgb(255, 224, 192);
            InfoDania.Enabled = false;
            InfoDania.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            InfoDania.Location = new Point(1429, 367);
            InfoDania.Multiline = true;
            InfoDania.Name = "InfoDania";
            InfoDania.Size = new Size(463, 67);
            InfoDania.TabIndex = 39;
            InfoDania.TextChanged += InfoDania_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.Location = new Point(1094, 295);
            label2.Name = "label2";
            label2.Size = new Size(155, 32);
            label2.TabIndex = 38;
            label2.Text = "Terytorium :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(383, 228);
            label1.Name = "label1";
            label1.Size = new Size(79, 32);
            label1.TabIndex = 37;
            label1.Text = "Opis :";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(955, 367);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(437, 238);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 36;
            pictureBox1.TabStop = false;
            // 
            // OpisDania
            // 
            OpisDania.BackColor = Color.FromArgb(255, 224, 192);
            OpisDania.Enabled = false;
            OpisDania.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            OpisDania.Location = new Point(12, 295);
            OpisDania.Multiline = true;
            OpisDania.Name = "OpisDania";
            OpisDania.Size = new Size(841, 553);
            OpisDania.TabIndex = 35;
            OpisDania.Text = resources.GetString("OpisDania.Text");
            // 
            // Back
            // 
            Back.BackColor = Color.FromArgb(255, 255, 192);
            Back.Location = new Point(12, 12);
            Back.Name = "Back";
            Back.Size = new Size(75, 23);
            Back.TabIndex = 42;
            Back.Text = "Powrót";
            Back.UseVisualStyleBackColor = false;
            Back.Click += Back_Click;
            // 
            // Dania
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(1904, 1041);
            Controls.Add(Back);
            Controls.Add(Opis);
            Controls.Add(InfoDania1);
            Controls.Add(InfoDania);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(OpisDania);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Dania";
            Text = "Dania";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Opis;
        protected TextBox InfoDania1;
        protected TextBox InfoDania;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        protected TextBox OpisDania;
        private Button Back;
    }
}