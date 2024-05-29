namespace EuroExplorer
{
    partial class Niemcy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Niemcy));
            Back = new Button();
            Opis = new Label();
            InfoNiemcy1 = new TextBox();
            InfoNiemcy = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            OpisNiemcy = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Back
            // 
            Back.BackColor = Color.FromArgb(255, 255, 192);
            Back.Location = new Point(12, 15);
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
            Opis.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Opis.Location = new Point(1593, 279);
            Opis.Name = "Opis";
            Opis.Size = new Size(131, 32);
            Opis.TabIndex = 134;
            Opis.Text = "Opis Live :";
            // 
            // InfoNiemcy1
            // 
            InfoNiemcy1.BackColor = Color.FromArgb(255, 224, 192);
            InfoNiemcy1.Enabled = false;
            InfoNiemcy1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            InfoNiemcy1.Location = new Point(1429, 424);
            InfoNiemcy1.Multiline = true;
            InfoNiemcy1.Name = "InfoNiemcy1";
            InfoNiemcy1.Size = new Size(463, 67);
            InfoNiemcy1.TabIndex = 133;
            InfoNiemcy1.TextChanged += InfoNiemcy1_TextChanged;
            // 
            // InfoNiemcy
            // 
            InfoNiemcy.BackColor = Color.FromArgb(255, 224, 192);
            InfoNiemcy.Enabled = false;
            InfoNiemcy.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            InfoNiemcy.Location = new Point(1429, 351);
            InfoNiemcy.Multiline = true;
            InfoNiemcy.Name = "InfoNiemcy";
            InfoNiemcy.Size = new Size(463, 67);
            InfoNiemcy.TabIndex = 132;
            InfoNiemcy.TextChanged += InfoNiemcy_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.Location = new Point(1094, 279);
            label2.Name = "label2";
            label2.Size = new Size(155, 32);
            label2.TabIndex = 131;
            label2.Text = "Terytorium :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(382, 142);
            label1.Name = "label1";
            label1.Size = new Size(79, 32);
            label1.TabIndex = 130;
            label1.Text = "Opis :";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(955, 351);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(437, 238);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 129;
            pictureBox1.TabStop = false;
            // 
            // OpisNiemcy
            // 
            OpisNiemcy.BackColor = Color.FromArgb(255, 224, 192);
            OpisNiemcy.Enabled = false;
            OpisNiemcy.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            OpisNiemcy.Location = new Point(12, 177);
            OpisNiemcy.Multiline = true;
            OpisNiemcy.Name = "OpisNiemcy";
            OpisNiemcy.Size = new Size(841, 782);
            OpisNiemcy.TabIndex = 128;
            OpisNiemcy.Text = resources.GetString("OpisNiemcy.Text");
            // 
            // Niemcy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(1904, 1041);
            Controls.Add(Back);
            Controls.Add(Opis);
            Controls.Add(InfoNiemcy1);
            Controls.Add(InfoNiemcy);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(OpisNiemcy);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Niemcy";
            Text = "Niemcy";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Back;
        private Label Opis;
        protected TextBox InfoNiemcy1;
        protected TextBox InfoNiemcy;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        protected TextBox OpisNiemcy;
    }
}