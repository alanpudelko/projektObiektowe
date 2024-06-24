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
    public partial class FormN : Form
    {
        private EuroExplorer.Models.User loggedInUser;

        public FormN(EuroExplorer.Models.User user)
        {
            InitializeComponent();
            this.loggedInUser = user;
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

        private void Niemcy_Click(object sender, EventArgs e)
        {
            Niemcy F30 = new Niemcy(loggedInUser);
            F30.Show();
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
