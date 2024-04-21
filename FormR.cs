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
    public partial class FormR : Form
    {
        public FormR()
        {
            InitializeComponent();
        }

        private void Rumunia_Click(object sender, EventArgs e)
        {
            Rumunia F19 = new Rumunia();
            F19.Show();
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
