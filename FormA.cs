﻿using EuroExplorer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EuroExplorer

{
    public partial class FormA : Form
    {
       
        private User loggedInUser;
        private User currentUser;

        public FormA(User user)
        {
            InitializeComponent();
            this.loggedInUser = user;
        }

        private void SomeMethodThatUsesUser()
        {

            Form1 form1 = new Form1(currentUser);
            form1.Show();
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
                Form1 form1 = new Form1(currentUser);
                form1.Show();
            }
        }

        private void Austria_Click(object sender, EventArgs e)
        {
            Austria newForm2 = new Austria(loggedInUser);
            newForm2.Show();
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
