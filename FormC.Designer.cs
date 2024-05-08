namespace EuroExplorer
{
    partial class FormC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormC));
            label1 = new Label();
            Chorwacja = new Button();
            Cypr = new Button();
            Czechy = new Button();
            Back = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(758, 9);
            label1.Name = "label1";
            label1.Size = new Size(556, 86);
            label1.TabIndex = 1;
            label1.Text = "Wybierz Państwo";
            // 
            // Chorwacja
            // 
            Chorwacja.BackColor = Color.FromArgb(255, 223, 192);
            Chorwacja.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Chorwacja.Image = (Image)resources.GetObject("Chorwacja.Image");
            Chorwacja.Location = new Point(153, 353);
            Chorwacja.Name = "Chorwacja";
            Chorwacja.Size = new Size(248, 240);
            Chorwacja.TabIndex = 2;
            Chorwacja.Text = "Chorwacja";
            Chorwacja.UseVisualStyleBackColor = false;
            Chorwacja.Click += Chorwacja_Click;
            // 
            // Cypr
            // 
            Cypr.BackColor = Color.FromArgb(255, 223, 192);
            Cypr.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Cypr.Image = (Image)resources.GetObject("Cypr.Image");
            Cypr.Location = new Point(783, 353);
            Cypr.Name = "Cypr";
            Cypr.Size = new Size(248, 240);
            Cypr.TabIndex = 3;
            Cypr.Text = "Cypr";
            Cypr.UseVisualStyleBackColor = false;
            Cypr.Click += Cypr_Click;
            // 
            // Czechy
            // 
            Czechy.BackColor = Color.FromArgb(255, 223, 192);
            Czechy.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Czechy.Image = (Image)resources.GetObject("Czechy.Image");
            Czechy.Location = new Point(1364, 353);
            Czechy.Name = "Czechy";
            Czechy.Size = new Size(248, 240);
            Czechy.TabIndex = 4;
            Czechy.Text = "Czechy";
            Czechy.UseVisualStyleBackColor = false;
            Czechy.Click += Czechy_Click;
            // 
            // Back
            // 
            Back.BackColor = Color.FromArgb(255, 255, 192);
            Back.Location = new Point(12, 12);
            Back.Name = "Back";
            Back.Size = new Size(75, 23);
            Back.TabIndex = 7;
            Back.Text = "Powrót";
            Back.UseVisualStyleBackColor = false;
            Back.Click += Back_Click;
            // 
            // FormC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(1904, 1041);
            Controls.Add(Back);
            Controls.Add(Czechy);
            Controls.Add(Cypr);
            Controls.Add(Chorwacja);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormC";
            Text = "FormC";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button Chorwacja;
        private Button Cypr;
        private Button Czechy;
        private Button Back;
    }
}