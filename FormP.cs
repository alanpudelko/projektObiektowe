﻿using System;
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
    public partial class FormP : Form
    {
        public FormP()
        {
            InitializeComponent();
        }

        private void Polska_Click(object sender, EventArgs e)
        {
            Polska F17 = new Polska();
            F17.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void Portugalia_Click(object sender, EventArgs e)
        {
            Portugalia F18 = new Portugalia();
            F18.Show();
            this.WindowState = FormWindowState.Minimized;
        }
    }
}