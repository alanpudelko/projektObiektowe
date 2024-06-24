namespace EuroExplorer
{
    partial class Czechy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Czechy));
            Opis = new Label();
            InfoCzechy1 = new TextBox();
            InfoCzechy = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            OpisCzechy = new TextBox();
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
            Opis.Location = new Point(1593, 245);
            Opis.Name = "Opis";
            Opis.Size = new Size(131, 32);
            Opis.TabIndex = 34;
            Opis.Text = "Opis Live :";
            // 
            // InfoCzechy1
            // 
            InfoCzechy1.BackColor = Color.White;
            InfoCzechy1.Enabled = false;
            InfoCzechy1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            InfoCzechy1.Location = new Point(1429, 390);
            InfoCzechy1.Multiline = true;
            InfoCzechy1.Name = "InfoCzechy1";
            InfoCzechy1.Size = new Size(463, 67);
            InfoCzechy1.TabIndex = 33;
            InfoCzechy1.TextChanged += InfoCzechy1_TextChanged;
            // 
            // InfoCzechy
            // 
            InfoCzechy.BackColor = Color.White;
            InfoCzechy.Enabled = false;
            InfoCzechy.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            InfoCzechy.Location = new Point(1429, 317);
            InfoCzechy.Multiline = true;
            InfoCzechy.Name = "InfoCzechy";
            InfoCzechy.Size = new Size(463, 67);
            InfoCzechy.TabIndex = 32;
            InfoCzechy.TextChanged += InfoCzechy_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.ForeColor = SystemColors.Menu;
            label2.Location = new Point(1094, 245);
            label2.Name = "label2";
            label2.Size = new Size(155, 32);
            label2.TabIndex = 31;
            label2.Text = "Terytorium :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = SystemColors.Menu;
            label1.Location = new Point(383, 178);
            label1.Name = "label1";
            label1.Size = new Size(79, 32);
            label1.TabIndex = 30;
            label1.Text = "Opis :";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(955, 317);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(437, 238);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // OpisCzechy
            // 
            OpisCzechy.BackColor = Color.White;
            OpisCzechy.Enabled = false;
            OpisCzechy.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            OpisCzechy.Location = new Point(12, 245);
            OpisCzechy.Multiline = true;
            OpisCzechy.Name = "OpisCzechy";
            OpisCzechy.Size = new Size(841, 517);
            OpisCzechy.TabIndex = 28;
            OpisCzechy.Text = resources.GetString("OpisCzechy.Text");
            // 
            // Back
            // 
            Back.BackColor = Color.White;
            Back.Location = new Point(12, 12);
            Back.Name = "Back";
            Back.Size = new Size(75, 23);
            Back.TabIndex = 35;
            Back.Text = "Powrót";
            Back.UseVisualStyleBackColor = false;
            Back.Click += Back_Click;
            // 
            // Czechy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1904, 1041);
            Controls.Add(Back);
            Controls.Add(Opis);
            Controls.Add(InfoCzechy1);
            Controls.Add(InfoCzechy);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(OpisCzechy);
            ForeColor = SystemColors.ActiveCaptionText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Czechy";
            Text = "Czechy";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Opis;
        protected TextBox InfoCzechy1;
        protected TextBox InfoCzechy;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        protected TextBox OpisCzechy;
        private Button Back;
    }
}