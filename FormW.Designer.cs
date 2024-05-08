namespace EuroExplorer
{
    partial class FormW
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormW));
            label1 = new Label();
            Węgry = new Button();
            Włochy = new Button();
            Back = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(819, 9);
            label1.Name = "label1";
            label1.Size = new Size(556, 86);
            label1.TabIndex = 3;
            label1.Text = "Wybierz Państwo";
            // 
            // Węgry
            // 
            Węgry.BackColor = Color.FromArgb(255, 223, 192);
            Węgry.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Węgry.Image = (Image)resources.GetObject("Węgry.Image");
            Węgry.Location = new Point(548, 391);
            Węgry.Name = "Węgry";
            Węgry.Size = new Size(248, 240);
            Węgry.TabIndex = 4;
            Węgry.Text = "Węgry";
            Węgry.UseVisualStyleBackColor = false;
            Węgry.Click += Węgry_Click;
            // 
            // Włochy
            // 
            Włochy.BackColor = Color.FromArgb(255, 223, 192);
            Włochy.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Włochy.Image = (Image)resources.GetObject("Włochy.Image");
            Włochy.Location = new Point(1389, 391);
            Włochy.Name = "Włochy";
            Włochy.Size = new Size(248, 240);
            Włochy.TabIndex = 5;
            Włochy.Text = "Włochy";
            Włochy.UseVisualStyleBackColor = false;
            Włochy.Click += Włochy_Click;
            // 
            // Back
            // 
            Back.BackColor = Color.FromArgb(255, 255, 192);
            Back.Location = new Point(12, 12);
            Back.Name = "Back";
            Back.Size = new Size(75, 23);
            Back.TabIndex = 20;
            Back.Text = "Powrót";
            Back.UseVisualStyleBackColor = false;
            Back.Click += Back_Click;
            // 
            // FormW
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(1904, 1041);
            Controls.Add(Back);
            Controls.Add(Włochy);
            Controls.Add(Węgry);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormW";
            Text = "FormW";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button Węgry;
        private Button Włochy;
        private Button Back;
    }
}