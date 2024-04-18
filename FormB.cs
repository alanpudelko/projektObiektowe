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
    public partial class FormB : Form
    {
        public FormB()
        {
            InitializeComponent();
        }

        private void Belgia_Click(object sender, EventArgs e)
        {
            Belgia newfrom2 = new Belgia();
            newfrom2.Show();
            this.WindowState = FormWindowState.Minimized;
        }
        private void Bułgaria_Click(object sender, EventArgs e)
        {
            Bułgaria newfrom3 = new Bułgaria();
            newfrom3.Show();
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
