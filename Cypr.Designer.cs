namespace EuroExplorer
{
    partial class Cypr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cypr));
            Opis = new Label();
            InfoCypr1 = new TextBox();
            InfoCypr = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            OpisCypr = new TextBox();
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
            Opis.TabIndex = 27;
            Opis.Text = "Opis Live :";
            // 
            // InfoCypr1
            // 
            InfoCypr1.BackColor = Color.White;
            InfoCypr1.Enabled = false;
            InfoCypr1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            InfoCypr1.Location = new Point(1429, 406);
            InfoCypr1.Multiline = true;
            InfoCypr1.Name = "InfoCypr1";
            InfoCypr1.Size = new Size(463, 67);
            InfoCypr1.TabIndex = 26;
            InfoCypr1.TextChanged += InfoCypr1_TextChanged;
            // 
            // InfoCypr
            // 
            InfoCypr.BackColor = Color.White;
            InfoCypr.Enabled = false;
            InfoCypr.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            InfoCypr.Location = new Point(1429, 333);
            InfoCypr.Multiline = true;
            InfoCypr.Name = "InfoCypr";
            InfoCypr.Size = new Size(463, 67);
            InfoCypr.TabIndex = 25;
            InfoCypr.TextChanged += InfoCypr_TextChanged;
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
            label2.TabIndex = 24;
            label2.Text = "Terytorium :";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.White;
            label1.Location = new Point(383, 194);
            label1.Name = "label1";
            label1.Size = new Size(79, 32);
            label1.TabIndex = 23;
            label1.Text = "Opis :";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(955, 333);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(437, 238);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // OpisCypr
            // 
            OpisCypr.BackColor = Color.White;
            OpisCypr.Enabled = false;
            OpisCypr.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            OpisCypr.Location = new Point(12, 261);
            OpisCypr.Multiline = true;
            OpisCypr.Name = "OpisCypr";
            OpisCypr.Size = new Size(841, 617);
            OpisCypr.TabIndex = 21;
            OpisCypr.Text = resources.GetString("OpisCypr.Text");
            // 
            // Back
            // 
            Back.BackColor = Color.White;
            Back.Location = new Point(12, 12);
            Back.Name = "Back";
            Back.Size = new Size(75, 23);
            Back.TabIndex = 28;
            Back.Text = "Powrót";
            Back.UseVisualStyleBackColor = false;
            Back.Click += Back_Click;
            // 
            // Cypr
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1904, 1041);
            Controls.Add(Back);
            Controls.Add(Opis);
            Controls.Add(InfoCypr1);
            Controls.Add(InfoCypr);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(OpisCypr);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Cypr";
            Text = "Cypr";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Opis;
        protected TextBox InfoCypr1;
        protected TextBox InfoCypr;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        protected TextBox OpisCypr;
        private Button Back;
    }
}