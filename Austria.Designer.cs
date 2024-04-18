namespace EuroExplorer
{
    partial class Austria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Austria));
            OpisAustrii = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // OpisAustrii
            // 
            OpisAustrii.BackColor = Color.FromArgb(255, 224, 192);
            OpisAustrii.Enabled = false;
            OpisAustrii.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            OpisAustrii.Location = new Point(12, 156);
            OpisAustrii.Multiline = true;
            OpisAustrii.Name = "OpisAustrii";
            OpisAustrii.Size = new Size(841, 450);
            OpisAustrii.TabIndex = 0;
            OpisAustrii.Text = resources.GetString("OpisAustrii.Text");
            OpisAustrii.TextChanged += OpisAustrii_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(955, 228);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(437, 238);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(383, 89);
            label1.Name = "label1";
            label1.Size = new Size(79, 32);
            label1.TabIndex = 2;
            label1.Text = "Opis :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.Location = new Point(1094, 156);
            label2.Name = "label2";
            label2.Size = new Size(155, 32);
            label2.TabIndex = 3;
            label2.Text = "Terytorium :";
            // 
            // Austria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(1904, 1041);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(OpisAustrii);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Austria";
            Text = "Austria";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        protected TextBox OpisAustrii;
    }
}