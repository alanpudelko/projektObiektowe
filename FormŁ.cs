using System;
using System.Windows.Forms;
using EuroExplorer.Models;

namespace EuroExplorer
{
    public partial class FormŁ : Form
    {
        private User user;

        public FormŁ(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void Łotwa_Click(object sender, EventArgs e)
        {
            Łotwa F15 = new Łotwa(user);
            F15.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();

            bool form1Open = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f is Form1)
                {
                    form1Open = true;
                    f.WindowState = FormWindowState.Normal;
                    f.Activate();
                    break;
                }
            }

            if (!form1Open)
            {
                Form1 form1 = new Form1(user);
                form1.Show();
            }
        }
    }
}
