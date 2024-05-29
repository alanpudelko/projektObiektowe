namespace EuroExplorer
{
    partial class Włochy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Włochy));
            Back = new Button();
            Opis = new Label();
            InfoWłochy1 = new TextBox();
            InfoWłochy = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            OpisWłochy = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Back
            // 
            Back.BackColor = Color.FromArgb(255, 255, 192);
            Back.Location = new Point(12, 17);
            Back.Name = "Back";
            Back.Size = new Size(75, 23);
            Back.TabIndex = 191;
            Back.Text = "Powrót";
            Back.UseVisualStyleBackColor = false;
            Back.Click += Back_Click;
            // 
            // Opis
            // 
            Opis.AutoSize = true;
            Opis.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Opis.Location = new Point(1593, 281);
            Opis.Name = "Opis";
            Opis.Size = new Size(131, 32);
            Opis.TabIndex = 190;
            Opis.Text = "Opis Live :";
            // 
            // InfoWłochy1
            // 
            InfoWłochy1.BackColor = Color.FromArgb(255, 224, 192);
            InfoWłochy1.Enabled = false;
            InfoWłochy1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            InfoWłochy1.Location = new Point(1429, 426);
            InfoWłochy1.Multiline = true;
            InfoWłochy1.Name = "InfoWłochy1";
            InfoWłochy1.Size = new Size(463, 67);
            InfoWłochy1.TabIndex = 189;
            InfoWłochy1.TextChanged += InfoWłochy1_TextChanged;
            // 
            // InfoWłochy
            // 
            InfoWłochy.BackColor = Color.FromArgb(255, 224, 192);
            InfoWłochy.Enabled = false;
            InfoWłochy.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            InfoWłochy.Location = new Point(1429, 353);
            InfoWłochy.Multiline = true;
            InfoWłochy.Name = "InfoWłochy";
            InfoWłochy.Size = new Size(463, 67);
            InfoWłochy.TabIndex = 188;
            InfoWłochy.TextChanged += InfoWłochy_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.Location = new Point(1094, 281);
            label2.Name = "label2";
            label2.Size = new Size(155, 32);
            label2.TabIndex = 187;
            label2.Text = "Terytorium :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(383, 214);
            label1.Name = "label1";
            label1.Size = new Size(79, 32);
            label1.TabIndex = 186;
            label1.Text = "Opis :";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(955, 353);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(437, 555);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 185;
            pictureBox1.TabStop = false;
            // 
            // OpisWłochy
            // 
            OpisWłochy.BackColor = Color.FromArgb(255, 224, 192);
            OpisWłochy.Enabled = false;
            OpisWłochy.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            OpisWłochy.Location = new Point(12, 278);
            OpisWłochy.Multiline = true;
            OpisWłochy.Name = "OpisWłochy";
            OpisWłochy.Size = new Size(841, 682);
            OpisWłochy.TabIndex = 184;
            OpisWłochy.Text = resources.GetString("OpisWłochy.Text");
            // 
            // Włochy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(1904, 1041);
            Controls.Add(Back);
            Controls.Add(Opis);
            Controls.Add(InfoWłochy1);
            Controls.Add(InfoWłochy);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(OpisWłochy);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Włochy";
            Text = "Włochy";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Back;
        private Label Opis;
        protected TextBox InfoWłochy1;
        protected TextBox InfoWłochy;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        protected TextBox OpisWłochy;
    }
}