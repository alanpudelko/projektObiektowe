﻿using System;
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
    public partial class FormC : Form
    {
        private User loggedInUser;

        public FormC(User user)
        {
            InitializeComponent();
            this.loggedInUser = user;
        }

        private void Chorwacja_Click(object sender, EventArgs e)
        {
            Chorwacja F2 = new Chorwacja(loggedInUser); 
            F2.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void Cypr_Click(object sender, EventArgs e)
        {
            Cypr F3 = new Cypr(loggedInUser); 
            F3.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void Czechy_Click(object sender, EventArgs e)
        {
            Czechy F4 = new Czechy(loggedInUser); 
            F4.Show();
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
