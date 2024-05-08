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
    public partial class FormS : Form
    {
        public FormS()
        {
            InitializeComponent();
        }

        private void FormS_Load(object sender, EventArgs e)
        {

        }

        private void Słowacja_Click(object sender, EventArgs e)
        {
            Słowacja F20 = new Słowacja();
            F20.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void Słowenia_Click(object sender, EventArgs e)
        {
            Słowenia F21 = new Słowenia();
            F21.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void Szwecja_Click(object sender, EventArgs e)
        {
            Szwecja F22 = new Szwecja();
            F22.Show();
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
