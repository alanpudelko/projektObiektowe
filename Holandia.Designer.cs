namespace EuroExplorer
{
    partial class Holandia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Holandia));
            Back = new Button();
            Opis = new Label();
            InfoHolandia1 = new TextBox();
            InfoHolandia = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            OpisHolandia = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Back
            // 
            Back.BackColor = Color.FromArgb(255, 255, 192);
            Back.Location = new Point(12, 13);
            Back.Name = "Back";
            Back.Size = new Size(75, 23);
            Back.TabIndex = 87;
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
            Opis.TabIndex = 86;
            Opis.Text = "Opis Live :";
            // 
            // InfoHolandia1
            // 
            InfoHolandia1.BackColor = Color.FromArgb(255, 224, 192);
            InfoHolandia1.Enabled = false;
            InfoHolandia1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            InfoHolandia1.Location = new Point(1429, 422);
            InfoHolandia1.Multiline = true;
            InfoHolandia1.Name = "InfoHolandia1";
            InfoHolandia1.Size = new Size(463, 67);
            InfoHolandia1.TabIndex = 85;
            InfoHolandia1.TextChanged += InfoHolandia1_TextChanged;
            // 
            // InfoHolandia
            // 
            InfoHolandia.BackColor = Color.FromArgb(255, 224, 192);
            InfoHolandia.Enabled = false;
            InfoHolandia.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            InfoHolandia.Location = new Point(1429, 349);
            InfoHolandia.Multiline = true;
            InfoHolandia.Name = "InfoHolandia";
            InfoHolandia.Size = new Size(463, 67);
            InfoHolandia.TabIndex = 84;
            InfoHolandia.TextChanged += InfoHolandia_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.Location = new Point(1094, 277);
            label2.Name = "label2";
            label2.Size = new Size(155, 32);
            label2.TabIndex = 83;
            label2.Text = "Terytorium :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(383, 210);
            label1.Name = "label1";
            label1.Size = new Size(79, 32);
            label1.TabIndex = 82;
            label1.Text = "Opis :";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(955, 349);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(437, 238);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 81;
            pictureBox1.TabStop = false;
            // 
            // OpisHolandia
            // 
            OpisHolandia.BackColor = Color.FromArgb(255, 224, 192);
            OpisHolandia.Enabled = false;
            OpisHolandia.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            OpisHolandia.Location = new Point(12, 277);
            OpisHolandia.Multiline = true;
            OpisHolandia.Name = "OpisHolandia";
            OpisHolandia.Size = new Size(841, 616);
            OpisHolandia.TabIndex = 80;
            OpisHolandia.Text = resources.GetString("OpisHolandia.Text");
            // 
            // Holandia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(1904, 1041);
            Controls.Add(Back);
            Controls.Add(Opis);
            Controls.Add(InfoHolandia1);
            Controls.Add(InfoHolandia);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(OpisHolandia);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Holandia";
            Text = "Holandia";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Back;
        private Label Opis;
        protected TextBox InfoHolandia1;
        protected TextBox InfoHolandia;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        protected TextBox OpisHolandia;
    }
}