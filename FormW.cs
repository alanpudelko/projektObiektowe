using System;
using System.Windows.Forms;
using EuroExplorer.Models;

namespace EuroExplorer
{
    public partial class FormW : Form
    {
        private User user;

        public FormW(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void Węgry_Click(object sender, EventArgs e)
        {
            Węgry F23 = new Węgry(user);
            F23.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void Włochy_Click(object sender, EventArgs e)
        {
            Włochy F24 = new Włochy(user);
            F24.Show();
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
