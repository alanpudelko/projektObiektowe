namespace EuroExplorer
{
    partial class Chorwacja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chorwacja));
            Opis = new Label();
            InfoChorwacja1 = new TextBox();
            InfoChorwacja = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            OpisChorwacja = new TextBox();
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
            Opis.Location = new Point(1593, 220);
            Opis.Name = "Opis";
            Opis.Size = new Size(131, 32);
            Opis.TabIndex = 20;
            Opis.Text = "Opis Live :";
            // 
            // InfoChorwacja1
            // 
            InfoChorwacja1.BackColor = Color.White;
            InfoChorwacja1.Enabled = false;
            InfoChorwacja1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            InfoChorwacja1.Location = new Point(1429, 365);
            InfoChorwacja1.Multiline = true;
            InfoChorwacja1.Name = "InfoChorwacja1";
            InfoChorwacja1.Size = new Size(463, 67);
            InfoChorwacja1.TabIndex = 19;
            InfoChorwacja1.TextChanged += InfoChorwacja1_TextChanged;
            // 
            // InfoChorwacja
            // 
            InfoChorwacja.BackColor = Color.White;
            InfoChorwacja.Enabled = false;
            InfoChorwacja.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            InfoChorwacja.Location = new Point(1429, 292);
            InfoChorwacja.Multiline = true;
            InfoChorwacja.Name = "InfoChorwacja";
            InfoChorwacja.Size = new Size(463, 67);
            InfoChorwacja.TabIndex = 18;
            InfoChorwacja.TextChanged += InfoChorwacja_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.ForeColor = SystemColors.Menu;
            label2.Location = new Point(1094, 220);
            label2.Name = "label2";
            label2.Size = new Size(155, 32);
            label2.TabIndex = 17;
            label2.Text = "Terytorium :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = SystemColors.Menu;
            label1.Location = new Point(383, 153);
            label1.Name = "label1";
            label1.Size = new Size(79, 32);
            label1.TabIndex = 16;
            label1.Text = "Opis :";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(955, 292);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(437, 238);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // OpisChorwacja
            // 
            OpisChorwacja.BackColor = Color.White;
            OpisChorwacja.Enabled = false;
            OpisChorwacja.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            OpisChorwacja.Location = new Point(12, 220);
            OpisChorwacja.Multiline = true;
            OpisChorwacja.Name = "OpisChorwacja";
            OpisChorwacja.Size = new Size(841, 585);
            OpisChorwacja.TabIndex = 14;
            OpisChorwacja.Text = resources.GetString("OpisChorwacja.Text");
            // 
            // Back
            // 
            Back.BackColor = Color.White;
            Back.Location = new Point(12, 12);
            Back.Name = "Back";
            Back.Size = new Size(75, 23);
            Back.TabIndex = 21;
            Back.Text = "Powrót";
            Back.UseVisualStyleBackColor = false;
            Back.Click += Back_Click;
            // 
            // Chorwacja
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1904, 1041);
            Controls.Add(Back);
            Controls.Add(Opis);
            Controls.Add(InfoChorwacja1);
            Controls.Add(InfoChorwacja);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(OpisChorwacja);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Chorwacja";
            Text = "Chorwacja";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Opis;
        protected TextBox InfoChorwacja1;
        protected TextBox InfoChorwacja;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        protected TextBox OpisChorwacja;
        private Button Back;
    }
}