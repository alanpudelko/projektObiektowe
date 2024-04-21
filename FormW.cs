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
    public partial class FormW : Form
    {
        public FormW()
        {
            InitializeComponent();
        }

        private void Węgry_Click(object sender, EventArgs e)
        {
            Węgry F23 = new Węgry();
            F23.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void Włochy_Click(object sender, EventArgs e)
        {
            Włochy F24 = new Włochy();
            F24.Show();
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
