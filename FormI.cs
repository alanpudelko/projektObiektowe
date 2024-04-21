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
    public partial class FormI : Form
    {
        public FormI()
        {
            InitializeComponent();
        }

        private void Irlandia_Click(object sender, EventArgs e)
        {
            Irlandia F12 = new Irlandia();
            F12.Show();
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
