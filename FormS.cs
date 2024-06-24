using System;
using System.Windows.Forms;
using EuroExplorer.Models;

namespace EuroExplorer
{
    public partial class FormS : Form
    {
        private User user;

        public FormS(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void FormS_Load(object sender, EventArgs e)
        {

        }

        private void Słowacja_Click(object sender, EventArgs e)
        {
            Słowacja F20 = new Słowacja(user);
            F20.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void Słowenia_Click(object sender, EventArgs e)
        {
            Słowenia F21 = new Słowenia(user);
            F21.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void Szwecja_Click(object sender, EventArgs e)
        {
            Szwecja F22 = new Szwecja(user);
            F22.Show();
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
