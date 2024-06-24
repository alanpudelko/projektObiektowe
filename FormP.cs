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
using Microsoft.VisualBasic.ApplicationServices;

namespace EuroExplorer
{
    public partial class FormP : Form
    {
        private EuroExplorer.Models.User loggedInUser;

        public FormP(EuroExplorer.Models.User user)
        {
            InitializeComponent();
            this.loggedInUser = user;
        }

        private void Polska_Click(object sender, EventArgs e)
        {
            Polska F17 = new Polska(loggedInUser);
            F17.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void Portugalia_Click(object sender, EventArgs e)
        {
            Portugalia F18 = new Portugalia(loggedInUser);
            F18.Show();
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
