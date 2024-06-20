using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EuroExplorer.Models;

namespace EuroExplorer
{
    public partial class FormH : Form
    {
        private User loggedInUser;

        public FormH(User user)
        {
            InitializeComponent();
            this.loggedInUser = user;
        }

        private void Hiszpania_Click(object sender, EventArgs e)
        {
            Hiszpania F10 = new Hiszpania(loggedInUser); 
            F10.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void Holandia_Click(object sender, EventArgs e)
        {
            Holandia F11 = new Holandia(loggedInUser); 
            F11.Show();
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
                Form1 form1 = new Form1(loggedInUser);
                form1.Show();
            }
        }
    }
}
