namespace EuroExplorer
{
    partial class Finlandia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Finlandia));
            Opis = new Label();
            InfoFinlandia1 = new TextBox();
            InfoFinlandia = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            OpisFinlandia = new TextBox();
            Back = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Opis
            // 
            Opis.AutoSize = true;
            Opis.BackColor = Color.Transparent;
            Opis.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Opis.ForeColor = SystemColors.Menu;
            Opis.Location = new Point(1593, 261);
            Opis.Name = "Opis";
            Opis.Size = new Size(131, 32);
            Opis.TabIndex = 55;
            Opis.Text = "Opis Live :";
            // 
            // InfoFinlandia1
            // 
            InfoFinlandia1.BackColor = Color.White;
            InfoFinlandia1.Enabled = false;
            InfoFinlandia1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            InfoFinlandia1.Location = new Point(1429, 406);
            InfoFinlandia1.Multiline = true;
            InfoFinlandia1.Name = "InfoFinlandia1";
            InfoFinlandia1.Size = new Size(463, 67);
            InfoFinlandia1.TabIndex = 54;
            InfoFinlandia1.TextChanged += InfoFinlandia1_TextChanged;
            // 
            // InfoFinlandia
            // 
            InfoFinlandia.BackColor = Color.White;
            InfoFinlandia.Enabled = false;
            InfoFinlandia.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            InfoFinlandia.Location = new Point(1429, 333);
            InfoFinlandia.Multiline = true;
            InfoFinlandia.Name = "InfoFinlandia";
            InfoFinlandia.Size = new Size(463, 67);
            InfoFinlandia.TabIndex = 53;
            InfoFinlandia.TextChanged += InfoFinlandia_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.ForeColor = SystemColors.Menu;
            label2.Location = new Point(1094, 261);
            label2.Name = "label2";
            label2.Size = new Size(155, 32);
            label2.TabIndex = 52;
            label2.Text = "Terytorium :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = SystemColors.Menu;
            label1.Location = new Point(383, 194);
            label1.Name = "label1";
            label1.Size = new Size(79, 32);
            label1.TabIndex = 51;
            label1.Text = "Opis :";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(955, 333);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(437, 238);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 50;
            pictureBox1.TabStop = false;
            // 
            // OpisFinlandia
            // 
            OpisFinlandia.BackColor = Color.White;
            OpisFinlandia.Enabled = false;
            OpisFinlandia.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            OpisFinlandia.Location = new Point(12, 261);
            OpisFinlandia.Multiline = true;
            OpisFinlandia.Name = "OpisFinlandia";
            OpisFinlandia.Size = new Size(841, 555);
            OpisFinlandia.TabIndex = 49;
            OpisFinlandia.Text = resources.GetString("OpisFinlandia.Text");
            // 
            // Back
            // 
            Back.BackColor = Color.White;
            Back.Location = new Point(12, 12);
            Back.Name = "Back";
            Back.Size = new Size(75, 23);
            Back.TabIndex = 56;
            Back.Text = "Powrót";
            Back.UseVisualStyleBackColor = false;
            Back.Click += Back_Click;
            // 
            // Finlandia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1904, 1041);
            Controls.Add(Back);
            Controls.Add(Opis);
            Controls.Add(InfoFinlandia1);
            Controls.Add(InfoFinlandia);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(OpisFinlandia);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Finlandia";
            Text = "Finlandia";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Opis;
        protected TextBox InfoFinlandia1;
        protected TextBox InfoFinlandia;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        protected TextBox OpisFinlandia;
        private Button Back;
    }
}