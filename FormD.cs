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
    public partial class FormD : Form
    {
        public FormD()
        {
            InitializeComponent();
        }

        private void Dania_Click(object sender, EventArgs e)
        {
            Dania F5 = new Dania();
            F5.Show();
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
