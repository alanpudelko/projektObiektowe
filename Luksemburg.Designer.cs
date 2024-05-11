namespace EuroExplorer
{
    partial class Luksemburg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Luksemburg));
            Back = new Button();
            Opis = new Label();
            InfoLuksemburg1 = new TextBox();
            InfoLuksemburg = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            OpisLuksemburg = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Back
            // 
            Back.BackColor = Color.FromArgb(255, 255, 192);
            Back.Location = new Point(12, 15);
            Back.Name = "Back";
            Back.Size = new Size(75, 23);
            Back.TabIndex = 111;
            Back.Text = "Powrót";
            Back.UseVisualStyleBackColor = false;
            Back.Click += Back_Click;
            // 
            // Opis
            // 
            Opis.AutoSize = true;
            Opis.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Opis.Location = new Point(1593, 279);
            Opis.Name = "Opis";
            Opis.Size = new Size(131, 32);
            Opis.TabIndex = 110;
            Opis.Text = "Opis Live :";
            // 
            // InfoLuksemburg1
            // 
            InfoLuksemburg1.BackColor = Color.FromArgb(255, 224, 192);
            InfoLuksemburg1.Enabled = false;
            InfoLuksemburg1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            InfoLuksemburg1.Location = new Point(1429, 424);
            InfoLuksemburg1.Multiline = true;
            InfoLuksemburg1.Name = "InfoLuksemburg1";
            InfoLuksemburg1.Size = new Size(463, 67);
            InfoLuksemburg1.TabIndex = 109;
            InfoLuksemburg1.TextChanged += InfoLuksemburg1_TextChanged;
            // 
            // InfoLuksemburg
            // 
            InfoLuksemburg.BackColor = Color.FromArgb(255, 224, 192);
            InfoLuksemburg.Enabled = false;
            InfoLuksemburg.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            InfoLuksemburg.Location = new Point(1429, 351);
            InfoLuksemburg.Multiline = true;
            InfoLuksemburg.Name = "InfoLuksemburg";
            InfoLuksemburg.Size = new Size(463, 67);
            InfoLuksemburg.TabIndex = 108;
            InfoLuksemburg.TextChanged += InfoLuksemburg_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.Location = new Point(1094, 279);
            label2.Name = "label2";
            label2.Size = new Size(155, 32);
            label2.TabIndex = 107;
            label2.Text = "Terytorium :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(383, 212);
            label1.Name = "label1";
            label1.Size = new Size(79, 32);
            label1.TabIndex = 106;
            label1.Text = "Opis :";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(955, 351);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(437, 238);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 105;
            pictureBox1.TabStop = false;
            // 
            // OpisLuksemburg
            // 
            OpisLuksemburg.BackColor = Color.FromArgb(255, 224, 192);
            OpisLuksemburg.Enabled = false;
            OpisLuksemburg.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            OpisLuksemburg.Location = new Point(12, 279);
            OpisLuksemburg.Multiline = true;
            OpisLuksemburg.Name = "OpisLuksemburg";
            OpisLuksemburg.Size = new Size(841, 650);
            OpisLuksemburg.TabIndex = 104;
            OpisLuksemburg.Text = resources.GetString("OpisLuksemburg.Text");
            // 
            // Luksemburg
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(1904, 1041);
            Controls.Add(Back);
            Controls.Add(Opis);
            Controls.Add(InfoLuksemburg1);
            Controls.Add(InfoLuksemburg);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(OpisLuksemburg);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Luksemburg";
            Text = "Luksemburg";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Back;
        private Label Opis;
        protected TextBox InfoLuksemburg1;
        protected TextBox InfoLuksemburg;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        protected TextBox OpisLuksemburg;
    }
}