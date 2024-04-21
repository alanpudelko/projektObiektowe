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
    public partial class FormŁ : Form
    {
        public FormŁ()
        {
            InitializeComponent();
        }

        private void Łotwa_Click(object sender, EventArgs e)
        {
            Łotwa F15 = new Łotwa();
            F15.Show();
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
