﻿namespace EuroExplorer
{
    partial class FormL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormL));
            label1 = new Label();
            Litwa = new Button();
            Luksemburg = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(731, 9);
            label1.Name = "label1";
            label1.Size = new Size(556, 86);
            label1.TabIndex = 3;
            label1.Text = "Wybierz Państwo";
            // 
            // Litwa
            // 
            Litwa.BackColor = Color.FromArgb(255, 223, 192);
            Litwa.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Litwa.Image = (Image)resources.GetObject("Litwa.Image");
            Litwa.Location = new Point(488, 393);
            Litwa.Name = "Litwa";
            Litwa.Size = new Size(248, 240);
            Litwa.TabIndex = 4;
            Litwa.Text = "Litwa";
            Litwa.UseVisualStyleBackColor = false;
            Litwa.Click += Litwa_Click;
            // 
            // Luksemburg
            // 
            Luksemburg.BackColor = Color.FromArgb(255, 223, 192);
            Luksemburg.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Luksemburg.Image = (Image)resources.GetObject("Luksemburg.Image");
            Luksemburg.Location = new Point(1308, 393);
            Luksemburg.Name = "Luksemburg";
            Luksemburg.Size = new Size(248, 240);
            Luksemburg.TabIndex = 5;
            Luksemburg.Text = "Luksemburg";
            Luksemburg.UseVisualStyleBackColor = false;
            Luksemburg.Click += Luksemburg_Click;
            // 
            // FormL
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(1904, 1041);
            Controls.Add(Luksemburg);
            Controls.Add(Litwa);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormL";
            Text = "FormL";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button Litwa;
        private Button Luksemburg;
    }
}