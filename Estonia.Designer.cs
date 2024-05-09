namespace EuroExplorer
{
    partial class Estonia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Estonia));
            Opis = new Label();
            InfoEstonia1 = new TextBox();
            InfoEstonia = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            OpisEstonia = new TextBox();
            Back = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Opis
            // 
            Opis.AutoSize = true;
            Opis.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Opis.Location = new Point(1593, 277);
            Opis.Name = "Opis";
            Opis.Size = new Size(131, 32);
            Opis.TabIndex = 48;
            Opis.Text = "Opis Live :";
            // 
            // InfoEstonia1
            // 
            InfoEstonia1.BackColor = Color.FromArgb(255, 224, 192);
            InfoEstonia1.Enabled = false;
            InfoEstonia1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            InfoEstonia1.Location = new Point(1429, 422);
            InfoEstonia1.Multiline = true;
            InfoEstonia1.Name = "InfoEstonia1";
            InfoEstonia1.Size = new Size(463, 67);
            InfoEstonia1.TabIndex = 47;
            InfoEstonia1.TextChanged += InfoEstonia1_TextChanged;
            // 
            // InfoEstonia
            // 
            InfoEstonia.BackColor = Color.FromArgb(255, 224, 192);
            InfoEstonia.Enabled = false;
            InfoEstonia.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            InfoEstonia.Location = new Point(1429, 349);
            InfoEstonia.Multiline = true;
            InfoEstonia.Name = "InfoEstonia";
            InfoEstonia.Size = new Size(463, 67);
            InfoEstonia.TabIndex = 46;
            InfoEstonia.TextChanged += InfoEstonia_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.Location = new Point(1094, 277);
            label2.Name = "label2";
            label2.Size = new Size(155, 32);
            label2.TabIndex = 45;
            label2.Text = "Terytorium :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(383, 210);
            label1.Name = "label1";
            label1.Size = new Size(79, 32);
            label1.TabIndex = 44;
            label1.Text = "Opis :";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(955, 349);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(437, 238);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 43;
            pictureBox1.TabStop = false;
            // 
            // OpisEstonia
            // 
            OpisEstonia.BackColor = Color.FromArgb(255, 224, 192);
            OpisEstonia.Enabled = false;
            OpisEstonia.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            OpisEstonia.Location = new Point(12, 277);
            OpisEstonia.Multiline = true;
            OpisEstonia.Name = "OpisEstonia";
            OpisEstonia.Size = new Size(841, 586);
            OpisEstonia.TabIndex = 42;
            OpisEstonia.Text = resources.GetString("OpisEstonia.Text");
            // 
            // Back
            // 
            Back.BackColor = Color.FromArgb(255, 255, 192);
            Back.Location = new Point(12, 12);
            Back.Name = "Back";
            Back.Size = new Size(75, 23);
            Back.TabIndex = 49;
            Back.Text = "Powrót";
            Back.UseVisualStyleBackColor = false;
            Back.Click += Back_Click;
            // 
            // Estonia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(1904, 1041);
            Controls.Add(Back);
            Controls.Add(Opis);
            Controls.Add(InfoEstonia1);
            Controls.Add(InfoEstonia);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(OpisEstonia);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Estonia";
            Text = "Estonia";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Opis;
        protected TextBox InfoEstonia1;
        protected TextBox InfoEstonia;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        protected TextBox OpisEstonia;
        private Button Back;
    }
}