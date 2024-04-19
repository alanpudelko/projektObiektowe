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
    public partial class FormC : Form
    {
        public FormC()
        {
            InitializeComponent();
        }

        private void Chorwacja_Click(object sender, EventArgs e)
        {
            Chorwacja F2 = new Chorwacja();
            F2.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void Cypr_Click(object sender, EventArgs e)
        {
            Cypr F3 = new Cypr();
            F3.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void Czechy_Click(object sender, EventArgs e)
        {
            Czechy F4 = new Czechy();
            F4.Show();
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
