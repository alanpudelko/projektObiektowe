namespace EuroExplorer
{
    partial class Hiszpania
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hiszpania));
            Back = new Button();
            Opis = new Label();
            InfoHiszpania1 = new TextBox();
            InfoHiszpania = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            OpisHiszpania = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Back
            // 
            Back.BackColor = Color.FromArgb(255, 255, 192);
            Back.Location = new Point(12, 12);
            Back.Name = "Back";
            Back.Size = new Size(75, 23);
            Back.TabIndex = 79;
            Back.Text = "Powrót";
            Back.UseVisualStyleBackColor = false;
            Back.Click += Back_Click;
            // 
            // Opis
            // 
            Opis.AutoSize = true;
            Opis.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Opis.Location = new Point(1593, 276);
            Opis.Name = "Opis";
            Opis.Size = new Size(131, 32);
            Opis.TabIndex = 78;
            Opis.Text = "Opis Live :";
            // 
            // InfoHiszpania1
            // 
            InfoHiszpania1.BackColor = Color.FromArgb(255, 224, 192);
            InfoHiszpania1.Enabled = false;
            InfoHiszpania1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            InfoHiszpania1.Location = new Point(1429, 421);
            InfoHiszpania1.Multiline = true;
            InfoHiszpania1.Name = "InfoHiszpania1";
            InfoHiszpania1.Size = new Size(463, 67);
            InfoHiszpania1.TabIndex = 77;
            InfoHiszpania1.TextChanged += InfoHiszpania1_TextChanged;
            // 
            // InfoHiszpania
            // 
            InfoHiszpania.BackColor = Color.FromArgb(255, 224, 192);
            InfoHiszpania.Enabled = false;
            InfoHiszpania.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            InfoHiszpania.Location = new Point(1429, 348);
            InfoHiszpania.Multiline = true;
            InfoHiszpania.Name = "InfoHiszpania";
            InfoHiszpania.Size = new Size(463, 67);
            InfoHiszpania.TabIndex = 76;
            InfoHiszpania.TextChanged += InfoHiszpania_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.Location = new Point(1094, 276);
            label2.Name = "label2";
            label2.Size = new Size(155, 32);
            label2.TabIndex = 75;
            label2.Text = "Terytorium :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(383, 209);
            label1.Name = "label1";
            label1.Size = new Size(79, 32);
            label1.TabIndex = 74;
            label1.Text = "Opis :";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(955, 348);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(437, 238);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 73;
            pictureBox1.TabStop = false;
            // 
            // OpisHiszpania
            // 
            OpisHiszpania.BackColor = Color.FromArgb(255, 224, 192);
            OpisHiszpania.Enabled = false;
            OpisHiszpania.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            OpisHiszpania.Location = new Point(12, 276);
            OpisHiszpania.Multiline = true;
            OpisHiszpania.Name = "OpisHiszpania";
            OpisHiszpania.Size = new Size(841, 649);
            OpisHiszpania.TabIndex = 72;
            OpisHiszpania.Text = resources.GetString("OpisHiszpania.Text");
            // 
            // Hiszpania
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(1904, 1041);
            Controls.Add(Back);
            Controls.Add(Opis);
            Controls.Add(InfoHiszpania1);
            Controls.Add(InfoHiszpania);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(OpisHiszpania);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Hiszpania";
            Text = "Hiszpania";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Back;
        private Label Opis;
        protected TextBox InfoHiszpania1;
        protected TextBox InfoHiszpania;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        protected TextBox OpisHiszpania;
    }
}