namespace EuroExplorer
{
    partial class Węgry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Węgry));
            Back = new Button();
            Opis = new Label();
            InfoWęgry1 = new TextBox();
            InfoWęgry = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            OpisWęgry = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Back
            // 
            Back.BackColor = Color.White;
            Back.Location = new Point(12, 14);
            Back.Name = "Back";
            Back.Size = new Size(75, 23);
            Back.TabIndex = 183;
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
            Opis.TabIndex = 182;
            Opis.Text = "Opis Live :";
            // 
            // InfoWęgry1
            // 
            InfoWęgry1.BackColor = Color.White;
            InfoWęgry1.Enabled = false;
            InfoWęgry1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            InfoWęgry1.Location = new Point(1429, 423);
            InfoWęgry1.Multiline = true;
            InfoWęgry1.Name = "InfoWęgry1";
            InfoWęgry1.Size = new Size(463, 67);
            InfoWęgry1.TabIndex = 181;
            InfoWęgry1.TextChanged += InfoWęgry1_TextChanged;
            // 
            // InfoWęgry
            // 
            InfoWęgry.BackColor = Color.White;
            InfoWęgry.Enabled = false;
            InfoWęgry.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            InfoWęgry.Location = new Point(1429, 350);
            InfoWęgry.Multiline = true;
            InfoWęgry.Name = "InfoWęgry";
            InfoWęgry.Size = new Size(463, 67);
            InfoWęgry.TabIndex = 180;
            InfoWęgry.TextChanged += InfoWęgry_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.ForeColor = SystemColors.Menu;
            label2.Location = new Point(1094, 278);
            label2.Name = "label2";
            label2.Size = new Size(155, 32);
            label2.TabIndex = 179;
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
            label1.TabIndex = 178;
            label1.Text = "Opis :";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(955, 350);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(437, 268);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 177;
            pictureBox1.TabStop = false;
            // 
            // OpisWęgry
            // 
            OpisWęgry.BackColor = Color.White;
            OpisWęgry.Enabled = false;
            OpisWęgry.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            OpisWęgry.Location = new Point(12, 275);
            OpisWęgry.Multiline = true;
            OpisWęgry.Name = "OpisWęgry";
            OpisWęgry.Size = new Size(841, 682);
            OpisWęgry.TabIndex = 176;
            OpisWęgry.Text = resources.GetString("OpisWęgry.Text");
            // 
            // Węgry
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1904, 1041);
            Controls.Add(Back);
            Controls.Add(Opis);
            Controls.Add(InfoWęgry1);
            Controls.Add(InfoWęgry);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(OpisWęgry);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Węgry";
            Text = "Węgry";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Back;
        private Label Opis;
        protected TextBox InfoWęgry1;
        protected TextBox InfoWęgry;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        protected TextBox OpisWęgry;
    }
}