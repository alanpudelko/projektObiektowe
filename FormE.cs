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
    public partial class FormE : Form
    {
        public FormE()
        {
            InitializeComponent();
        }

        private void Dania_Click(object sender, EventArgs e)
        {
            Estonia F6 = new Estonia();
            F6.Show();
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
