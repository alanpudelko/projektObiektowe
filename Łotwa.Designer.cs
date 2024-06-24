namespace EuroExplorer
{
    partial class Łotwa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Łotwa));
            Back = new Button();
            Opis = new Label();
            InfoŁotwa1 = new TextBox();
            InfoŁotwa = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            v = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Back
            // 
            Back.BackColor = Color.White;
            Back.Location = new Point(12, 14);
            Back.Name = "Back";
            Back.Size = new Size(75, 23);
            Back.TabIndex = 119;
            Back.Text = "Powrót";
            Back.UseVisualStyleBackColor = false;
            Back.Click += Back_Click;
            // 
            // Opis
            // 
            Opis.AutoSize = true;
            Opis.BackColor = Color.Transparent;
            Opis.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Opis.ForeColor = SystemColors.Menu;
            Opis.Location = new Point(1593, 278);
            Opis.Name = "Opis";
            Opis.Size = new Size(131, 32);
            Opis.TabIndex = 118;
            Opis.Text = "Opis Live :";
            // 
            // InfoŁotwa1
            // 
            InfoŁotwa1.BackColor = Color.White;
            InfoŁotwa1.Enabled = false;
            InfoŁotwa1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            InfoŁotwa1.Location = new Point(1429, 423);
            InfoŁotwa1.Multiline = true;
            InfoŁotwa1.Name = "InfoŁotwa1";
            InfoŁotwa1.Size = new Size(463, 67);
            InfoŁotwa1.TabIndex = 117;
            InfoŁotwa1.TextChanged += InfoŁotwa1_TextChanged;
            // 
            // InfoŁotwa
            // 
            InfoŁotwa.BackColor = Color.White;
            InfoŁotwa.Enabled = false;
            InfoŁotwa.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            InfoŁotwa.Location = new Point(1429, 350);
            InfoŁotwa.Multiline = true;
            InfoŁotwa.Name = "InfoŁotwa";
            InfoŁotwa.Size = new Size(463, 67);
            InfoŁotwa.TabIndex = 116;
            InfoŁotwa.TextChanged += InfoŁotwa_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.ForeColor = Color.White;
            label2.Location = new Point(1094, 278);
            label2.Name = "label2";
            label2.Size = new Size(155, 32);
            label2.TabIndex = 115;
            label2.Text = "Terytorium :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = SystemColors.Menu;
            label1.Location = new Point(383, 211);
            label1.Name = "label1";
            label1.Size = new Size(79, 32);
            label1.TabIndex = 114;
            label1.Text = "Opis :";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(955, 350);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(437, 238);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 113;
            pictureBox1.TabStop = false;
            // 
            // v
            // 
            v.BackColor = Color.White;
            v.Enabled = false;
            v.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            v.Location = new Point(12, 278);
            v.Multiline = true;
            v.Name = "v";
            v.Size = new Size(841, 556);
            v.TabIndex = 112;
            v.Text = resources.GetString("v.Text");
            // 
            // Łotwa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1904, 1041);
            Controls.Add(Back);
            Controls.Add(Opis);
            Controls.Add(InfoŁotwa1);
            Controls.Add(InfoŁotwa);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(v);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Łotwa";
            Text = "Łotwa";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Back;
        private Label Opis;
        protected TextBox InfoŁotwa1;
        protected TextBox InfoŁotwa;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        protected TextBox v;
    }
}