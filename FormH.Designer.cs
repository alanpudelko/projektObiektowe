﻿namespace EuroExplorer
{
    partial class FormH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormH));
            label1 = new Label();
            Hiszpania = new Button();
            Holandia = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(729, 9);
            label1.Name = "label1";
            label1.Size = new Size(556, 86);
            label1.TabIndex = 3;
            label1.Text = "Wybierz Państwo";
            // 
            // Hiszpania
            // 
            Hiszpania.BackColor = Color.FromArgb(255, 223, 192);
            Hiszpania.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Hiszpania.Image = (Image)resources.GetObject("Hiszpania.Image");
            Hiszpania.Location = new Point(469, 396);
            Hiszpania.Name = "Hiszpania";
            Hiszpania.Size = new Size(248, 240);
            Hiszpania.TabIndex = 4;
            Hiszpania.Text = "Hiszpania";
            Hiszpania.UseVisualStyleBackColor = false;
            Hiszpania.Click += Hiszpania_Click;
            // 
            // Holandia
            // 
            Holandia.BackColor = Color.FromArgb(255, 223, 192);
            Holandia.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Holandia.Image = (Image)resources.GetObject("Holandia.Image");
            Holandia.Location = new Point(1292, 396);
            Holandia.Name = "Holandia";
            Holandia.Size = new Size(248, 240);
            Holandia.TabIndex = 5;
            Holandia.Text = "Holandia";
            Holandia.UseVisualStyleBackColor = false;
            Holandia.Click += Holandia_Click;
            // 
            // FormH
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(1904, 1041);
            Controls.Add(Holandia);
            Controls.Add(Hiszpania);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormH";
            Text = "FormH";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button Hiszpania;
        private Button Holandia;
    }
}