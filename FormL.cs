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
    public partial class FormL : Form
    {
        private User loggedInUser;

        public FormL(User user)
        {
            InitializeComponent();
            this.loggedInUser = user;
        }

        private void Litwa_Click(object sender, EventArgs e)
        {
            Litwa F13 = new Litwa(loggedInUser);
            F13.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void Luksemburg_Click(object sender, EventArgs e)
        {
            Luksemburg F14 = new Luksemburg(loggedInUser); 
            F14.Show();
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
