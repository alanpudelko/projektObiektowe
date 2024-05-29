namespace EuroExplorer
{
    partial class Portugalia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Portugalia));
            Back = new Button();
            Opis = new Label();
            InfoPortugalia1 = new TextBox();
            InfoPortugalia = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            OpisPortugalia = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Back
            // 
            Back.BackColor = Color.FromArgb(255, 255, 192);
            Back.Location = new Point(12, 14);
            Back.Name = "Back";
            Back.Size = new Size(75, 23);
            Back.TabIndex = 143;
            Back.Text = "Powrót";
            Back.UseVisualStyleBackColor = false;
            Back.Click += Back_Click;
            // 
            // Opis
            // 
            Opis.AutoSize = true;
            Opis.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Opis.Location = new Point(1593, 278);
            Opis.Name = "Opis";
            Opis.Size = new Size(131, 32);
            Opis.TabIndex = 142;
            Opis.Text = "Opis Live :";
            // 
            // InfoPortugalia1
            // 
            InfoPortugalia1.BackColor = Color.FromArgb(255, 224, 192);
            InfoPortugalia1.Enabled = false;
            InfoPortugalia1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            InfoPortugalia1.Location = new Point(1429, 423);
            InfoPortugalia1.Multiline = true;
            InfoPortugalia1.Name = "InfoPortugalia1";
            InfoPortugalia1.Size = new Size(463, 67);
            InfoPortugalia1.TabIndex = 141;
            InfoPortugalia1.TextChanged += InfoPortugalia1_TextChanged;
            // 
            // InfoPortugalia
            // 
            InfoPortugalia.BackColor = Color.FromArgb(255, 224, 192);
            InfoPortugalia.Enabled = false;
            InfoPortugalia.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            InfoPortugalia.Location = new Point(1429, 350);
            InfoPortugalia.Multiline = true;
            InfoPortugalia.Name = "InfoPortugalia";
            InfoPortugalia.Size = new Size(463, 67);
            InfoPortugalia.TabIndex = 140;
            InfoPortugalia.TextChanged += InfoPortugalia_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.Location = new Point(1094, 278);
            label2.Name = "label2";
            label2.Size = new Size(155, 32);
            label2.TabIndex = 139;
            label2.Text = "Terytorium :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(383, 211);
            label1.Name = "label1";
            label1.Size = new Size(79, 32);
            label1.TabIndex = 138;
            label1.Text = "Opis :";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(955, 350);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(437, 238);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 137;
            pictureBox1.TabStop = false;
            // 
            // OpisPortugalia
            // 
            OpisPortugalia.BackColor = Color.FromArgb(255, 224, 192);
            OpisPortugalia.Enabled = false;
            OpisPortugalia.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            OpisPortugalia.Location = new Point(12, 278);
            OpisPortugalia.Multiline = true;
            OpisPortugalia.Name = "OpisPortugalia";
            OpisPortugalia.Size = new Size(841, 718);
            OpisPortugalia.TabIndex = 136;
            OpisPortugalia.Text = resources.GetString("OpisPortugalia.Text");
            // 
            // Portugalia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(1904, 1041);
            Controls.Add(Back);
            Controls.Add(Opis);
            Controls.Add(InfoPortugalia1);
            Controls.Add(InfoPortugalia);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(OpisPortugalia);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Portugalia";
            Text = "Portugalia";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Back;
        private Label Opis;
        protected TextBox InfoPortugalia1;
        protected TextBox InfoPortugalia;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        protected TextBox OpisPortugalia;
    }
}