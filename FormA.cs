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
        public FormA()
        {
            InitializeComponent();
        }

        private void Austria_Click(object sender, EventArgs e)
        {
            Austria F1 = new Austria();
            F1.Show();
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
