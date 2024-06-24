namespace EuroExplorer
{
    partial class Irlandia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Irlandia));
            Back = new Button();
            Opis = new Label();
            InfoIrlandia1 = new TextBox();
            InfoIrlandia = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            OpisIrlandia = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Back
            // 
            Back.BackColor = Color.White;
            Back.Location = new Point(12, 13);
            Back.Name = "Back";
            Back.Size = new Size(75, 23);
            Back.TabIndex = 95;
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
            Opis.TabIndex = 94;
            Opis.Text = "Opis Live :";
            // 
            // InfoIrlandia1
            // 
            InfoIrlandia1.BackColor = Color.White;
            InfoIrlandia1.Enabled = false;
            InfoIrlandia1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            InfoIrlandia1.Location = new Point(1429, 422);
            InfoIrlandia1.Multiline = true;
            InfoIrlandia1.Name = "InfoIrlandia1";
            InfoIrlandia1.Size = new Size(463, 67);
            InfoIrlandia1.TabIndex = 93;
            InfoIrlandia1.TextChanged += InfoIrlandia1_TextChanged;
            // 
            // InfoIrlandia
            // 
            InfoIrlandia.BackColor = Color.White;
            InfoIrlandia.Enabled = false;
            InfoIrlandia.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            InfoIrlandia.Location = new Point(1429, 349);
            InfoIrlandia.Multiline = true;
            InfoIrlandia.Name = "InfoIrlandia";
            InfoIrlandia.Size = new Size(463, 67);
            InfoIrlandia.TabIndex = 92;
            InfoIrlandia.TextChanged += InfoIrlandia_TextChanged;
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
            label2.TabIndex = 91;
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
            label1.TabIndex = 90;
            label1.Text = "Opis :";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(955, 349);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(437, 238);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 89;
            pictureBox1.TabStop = false;
            // 
            // OpisIrlandia
            // 
            OpisIrlandia.BackColor = Color.White;
            OpisIrlandia.Enabled = false;
            OpisIrlandia.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            OpisIrlandia.Location = new Point(12, 277);
            OpisIrlandia.Multiline = true;
            OpisIrlandia.Name = "OpisIrlandia";
            OpisIrlandia.Size = new Size(841, 616);
            OpisIrlandia.TabIndex = 88;
            OpisIrlandia.Text = resources.GetString("OpisIrlandia.Text");
            // 
            // Irlandia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1904, 1041);
            Controls.Add(Back);
            Controls.Add(Opis);
            Controls.Add(InfoIrlandia1);
            Controls.Add(InfoIrlandia);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(OpisIrlandia);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Irlandia";
            Text = "Irlandia";
            Load += Irlandia_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Back;
        private Label Opis;
        protected TextBox InfoIrlandia1;
        protected TextBox InfoIrlandia;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        protected TextBox OpisIrlandia;
    }
}