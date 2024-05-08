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
    public partial class FormF : Form
    {
        public FormF()
        {
            InitializeComponent();
        }

        private void Dania_Click(object sender, EventArgs e)
        {
            Finlandia F7 = new Finlandia();
            F7.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void Francja_Click(object sender, EventArgs e)
        {
            Francja F8 = new Francja();
            F8.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void Back_Click(object sender, EventArgs e)
        {

            this.Close();


            bool form1Open = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f is Form1)
                {
                    form1Open = true;
                    f.WindowState = FormWindowState.Normal;
                    f.Activate();
                    break;
                }
            }

            if (!form1Open)
            {
                Form1 form1 = new Form1();
                form1.Show();
            }
        }
    }
}
