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
    public partial class FormG : Form
    {
        public FormG()
        {
            InitializeComponent();
        }

        private void Grecja_Click(object sender, EventArgs e)
        {
            Grecja F9 = new Grecja();
            F9.Show();
            this.WindowState = FormWindowState.Minimized;
        }
    }
}