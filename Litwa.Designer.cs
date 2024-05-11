namespace EuroExplorer
{
    partial class Litwa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Litwa));
            Back = new Button();
            Opis = new Label();
            InfoLitwa1 = new TextBox();
            InfoLitwa = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            OpisLitwa = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Back
            // 
            Back.BackColor = Color.FromArgb(255, 255, 192);
            Back.Location = new Point(12, 14);
            Back.Name = "Back";
            Back.Size = new Size(75, 23);
            Back.TabIndex = 103;
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
            Opis.TabIndex = 102;
            Opis.Text = "Opis Live :";
            // 
            // InfoLitwa1
            // 
            InfoLitwa1.BackColor = Color.FromArgb(255, 224, 192);
            InfoLitwa1.Enabled = false;
            InfoLitwa1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            InfoLitwa1.Location = new Point(1429, 423);
            InfoLitwa1.Multiline = true;
            InfoLitwa1.Name = "InfoLitwa1";
            InfoLitwa1.Size = new Size(463, 67);
            InfoLitwa1.TabIndex = 101;
            InfoLitwa1.TextChanged += InfoLitwa1_TextChanged;
            // 
            // InfoLitwa
            // 
            InfoLitwa.BackColor = Color.FromArgb(255, 224, 192);
            InfoLitwa.Enabled = false;
            InfoLitwa.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            InfoLitwa.Location = new Point(1429, 350);
            InfoLitwa.Multiline = true;
            InfoLitwa.Name = "InfoLitwa";
            InfoLitwa.Size = new Size(463, 67);
            InfoLitwa.TabIndex = 100;
            InfoLitwa.TextChanged += InfoLitwa_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.Location = new Point(1094, 278);
            label2.Name = "label2";
            label2.Size = new Size(155, 32);
            label2.TabIndex = 99;
            label2.Text = "Terytorium :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(383, 211);
            label1.Name = "label1";
            label1.Size = new Size(79, 32);
            label1.TabIndex = 98;
            label1.Text = "Opis :";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(955, 350);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(437, 238);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 97;
            pictureBox1.TabStop = false;
            // 
            // OpisLitwa
            // 
            OpisLitwa.BackColor = Color.FromArgb(255, 224, 192);
            OpisLitwa.Enabled = false;
            OpisLitwa.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            OpisLitwa.Location = new Point(12, 278);
            OpisLitwa.Multiline = true;
            OpisLitwa.Name = "OpisLitwa";
            OpisLitwa.Size = new Size(841, 616);
            OpisLitwa.TabIndex = 96;
            OpisLitwa.Text = resources.GetString("OpisLitwa.Text");
            // 
            // Litwa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(1904, 1041);
            Controls.Add(Back);
            Controls.Add(Opis);
            Controls.Add(InfoLitwa1);
            Controls.Add(InfoLitwa);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(OpisLitwa);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Litwa";
            Text = "Litwa";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Back;
        private Label Opis;
        protected TextBox InfoLitwa1;
        protected TextBox InfoLitwa;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        protected TextBox OpisLitwa;
    }
}