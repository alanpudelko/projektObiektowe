namespace EuroExplorer
{
    partial class Malta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Malta));
            Back = new Button();
            Opis = new Label();
            InfoMalta1 = new TextBox();
            InfoMalta = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            OpisMalta = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Back
            // 
            Back.BackColor = Color.FromArgb(255, 255, 192);
            Back.Location = new Point(12, 14);
            Back.Name = "Back";
            Back.Size = new Size(75, 23);
            Back.TabIndex = 127;
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
            Opis.TabIndex = 126;
            Opis.Text = "Opis Live :";
            // 
            // InfoMalta1
            // 
            InfoMalta1.BackColor = Color.FromArgb(255, 224, 192);
            InfoMalta1.Enabled = false;
            InfoMalta1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            InfoMalta1.Location = new Point(1429, 423);
            InfoMalta1.Multiline = true;
            InfoMalta1.Name = "InfoMalta1";
            InfoMalta1.Size = new Size(463, 67);
            InfoMalta1.TabIndex = 125;
            InfoMalta1.TextChanged += InfoMalta1_TextChanged;
            // 
            // InfoMalta
            // 
            InfoMalta.BackColor = Color.FromArgb(255, 224, 192);
            InfoMalta.Enabled = false;
            InfoMalta.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            InfoMalta.Location = new Point(1429, 350);
            InfoMalta.Multiline = true;
            InfoMalta.Name = "InfoMalta";
            InfoMalta.Size = new Size(463, 67);
            InfoMalta.TabIndex = 124;
            InfoMalta.TextChanged += InfoMalta_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.Location = new Point(1094, 278);
            label2.Name = "label2";
            label2.Size = new Size(155, 32);
            label2.TabIndex = 123;
            label2.Text = "Terytorium :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(383, 211);
            label1.Name = "label1";
            label1.Size = new Size(79, 32);
            label1.TabIndex = 122;
            label1.Text = "Opis :";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(955, 350);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(437, 238);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 121;
            pictureBox1.TabStop = false;
            // 
            // OpisMalta
            // 
            OpisMalta.BackColor = Color.FromArgb(255, 224, 192);
            OpisMalta.Enabled = false;
            OpisMalta.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            OpisMalta.Location = new Point(12, 278);
            OpisMalta.Multiline = true;
            OpisMalta.Name = "OpisMalta";
            OpisMalta.Size = new Size(841, 716);
            OpisMalta.TabIndex = 120;
            OpisMalta.Text = resources.GetString("OpisMalta.Text");
            // 
            // Malta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(1904, 1041);
            Controls.Add(Back);
            Controls.Add(Opis);
            Controls.Add(InfoMalta1);
            Controls.Add(InfoMalta);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(OpisMalta);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Malta";
            Text = "Malta";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Back;
        private Label Opis;
        protected TextBox InfoMalta1;
        protected TextBox InfoMalta;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        protected TextBox OpisMalta;
    }
}