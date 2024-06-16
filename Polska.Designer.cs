namespace EuroExplorer
{
    partial class Polska
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Polska));
            Back = new Button();
            Opis = new Label();
            InfoPolska1 = new TextBox();
            InfoPolska = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            OpisPolska = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Back
            // 
            Back.BackColor = Color.White;
            Back.Location = new Point(12, 13);
            Back.Name = "Back";
            Back.Size = new Size(75, 23);
            Back.TabIndex = 135;
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
            Opis.Location = new Point(1593, 277);
            Opis.Name = "Opis";
            Opis.Size = new Size(131, 32);
            Opis.TabIndex = 134;
            Opis.Text = "Opis Live :";
            // 
            // InfoPolska1
            // 
            InfoPolska1.BackColor = Color.White;
            InfoPolska1.Enabled = false;
            InfoPolska1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            InfoPolska1.Location = new Point(1429, 422);
            InfoPolska1.Multiline = true;
            InfoPolska1.Name = "InfoPolska1";
            InfoPolska1.Size = new Size(463, 67);
            InfoPolska1.TabIndex = 133;
            InfoPolska1.TextChanged += InfoPolska1_TextChanged;
            // 
            // InfoPolska
            // 
            InfoPolska.BackColor = Color.White;
            InfoPolska.Enabled = false;
            InfoPolska.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            InfoPolska.Location = new Point(1429, 349);
            InfoPolska.Multiline = true;
            InfoPolska.Name = "InfoPolska";
            InfoPolska.Size = new Size(463, 67);
            InfoPolska.TabIndex = 132;
            InfoPolska.TextChanged += InfoPolska_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.ForeColor = SystemColors.Menu;
            label2.Location = new Point(1094, 277);
            label2.Name = "label2";
            label2.Size = new Size(155, 32);
            label2.TabIndex = 131;
            label2.Text = "Terytorium :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = SystemColors.Menu;
            label1.Location = new Point(383, 210);
            label1.Name = "label1";
            label1.Size = new Size(79, 32);
            label1.TabIndex = 130;
            label1.Text = "Opis :";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(955, 349);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(437, 238);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 129;
            pictureBox1.TabStop = false;
            // 
            // OpisPolska
            // 
            OpisPolska.BackColor = Color.White;
            OpisPolska.Enabled = false;
            OpisPolska.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            OpisPolska.Location = new Point(12, 277);
            OpisPolska.Multiline = true;
            OpisPolska.Name = "OpisPolska";
            OpisPolska.Size = new Size(841, 615);
            OpisPolska.TabIndex = 128;
            OpisPolska.Text = resources.GetString("OpisPolska.Text");
            // 
            // Polska
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1904, 1041);
            Controls.Add(Back);
            Controls.Add(Opis);
            Controls.Add(InfoPolska1);
            Controls.Add(InfoPolska);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(OpisPolska);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Polska";
            Text = "Polska";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Back;
        private Label Opis;
        protected TextBox InfoPolska1;
        protected TextBox InfoPolska;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        protected TextBox OpisPolska;
    }
}