namespace EuroExplorer
{
    partial class Belgia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Belgia));
            InfoBelgia1 = new TextBox();
            InfoBelgia = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            OpisBelgia = new TextBox();
            Opis = new Label();
            Back = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // InfoBelgia1
            // 
            InfoBelgia1.BackColor = Color.White;
            InfoBelgia1.Enabled = false;
            InfoBelgia1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            InfoBelgia1.Location = new Point(1429, 326);
            InfoBelgia1.Multiline = true;
            InfoBelgia1.Name = "InfoBelgia1";
            InfoBelgia1.Size = new Size(463, 67);
            InfoBelgia1.TabIndex = 12;
            InfoBelgia1.TextChanged += InfoBelgia1_TextChanged;
            // 
            // InfoBelgia
            // 
            InfoBelgia.BackColor = Color.White;
            InfoBelgia.Enabled = false;
            InfoBelgia.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            InfoBelgia.Location = new Point(1429, 253);
            InfoBelgia.Multiline = true;
            InfoBelgia.Name = "InfoBelgia";
            InfoBelgia.Size = new Size(463, 67);
            InfoBelgia.TabIndex = 11;
            InfoBelgia.TextChanged += InfoBelgia_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.ForeColor = SystemColors.Menu;
            label2.Location = new Point(1094, 181);
            label2.Name = "label2";
            label2.Size = new Size(155, 32);
            label2.TabIndex = 10;
            label2.Text = "Terytorium :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = SystemColors.Menu;
            label1.Location = new Point(383, 114);
            label1.Name = "label1";
            label1.Size = new Size(79, 32);
            label1.TabIndex = 9;
            label1.Text = "Opis :";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(955, 253);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(437, 238);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // OpisBelgia
            // 
            OpisBelgia.BackColor = Color.White;
            OpisBelgia.Enabled = false;
            OpisBelgia.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            OpisBelgia.Location = new Point(12, 181);
            OpisBelgia.Multiline = true;
            OpisBelgia.Name = "OpisBelgia";
            OpisBelgia.Size = new Size(841, 488);
            OpisBelgia.TabIndex = 7;
            OpisBelgia.Text = resources.GetString("OpisBelgia.Text");
            // 
            // Opis
            // 
            Opis.AutoSize = true;
            Opis.BackColor = Color.Transparent;
            Opis.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Opis.ForeColor = SystemColors.Menu;
            Opis.Location = new Point(1593, 181);
            Opis.Name = "Opis";
            Opis.Size = new Size(131, 32);
            Opis.TabIndex = 13;
            Opis.Text = "Opis Live :";
            // 
            // Back
            // 
            Back.BackColor = Color.White;
            Back.Location = new Point(12, 12);
            Back.Name = "Back";
            Back.Size = new Size(75, 23);
            Back.TabIndex = 22;
            Back.Text = "Powrót";
            Back.UseVisualStyleBackColor = false;
            Back.Click += Back_Click;
            // 
            // Belgia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1904, 1041);
            Controls.Add(Back);
            Controls.Add(Opis);
            Controls.Add(InfoBelgia1);
            Controls.Add(InfoBelgia);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(OpisBelgia);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Belgia";
            Text = "Belgia";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        protected TextBox InfoBelgia1;
        protected TextBox InfoBelgia;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        protected TextBox OpisBelgia;
        private Label Opis;
        private Button Back;
    }
}