using EuroExplorer.Models;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET;
using System;
using System.Windows.Forms;

namespace EuroExplorer
{
    public partial class Form1 : Form
    {
        private User user;


        public Form1(User user)
        {
            InitializeComponent();
            
            this.user = user;
        }
       
        


        private void Title_Click(object sender, EventArgs e)
        {
            // Obs³uga klikniêcia na tytu³, jeœli jest wymagana
        }

        private void CountryA_Click(object sender, EventArgs e)
        {
            FormA newFormA = new FormA(user);
            newFormA.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void CountryB_Click(object sender, EventArgs e)
        {
            FormB newFormB = new FormB(user);
            newFormB.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void CountryC_Click(object sender, EventArgs e)
        {
            FormC newFormC = new FormC(user);
            newFormC.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void CountryD_Click(object sender, EventArgs e)
        {
            FormD newFormD = new FormD(user);
            newFormD.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void CountryE_Click(object sender, EventArgs e)
        {
            FormE newFormE = new FormE(user);
            newFormE.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void CountryF_Click(object sender, EventArgs e)
        {
            FormF newFormF = new FormF(user);
            newFormF.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void CountryG_Click(object sender, EventArgs e)
        {
            FormG newFormG = new FormG(user);
            newFormG.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void CountryH_Click(object sender, EventArgs e)
        {
            FormH newFormH = new FormH(user);
            newFormH.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void CountryI_Click(object sender, EventArgs e)
        {
            FormI newFormI = new FormI(user);
            newFormI.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void CountryL_Click(object sender, EventArgs e)
        {
            FormL newFormL = new FormL(user);
            newFormL.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void Country£_Click(object sender, EventArgs e)
        {
            Form£ newForm£ = new Form£(user);
            newForm£.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void CountryM_Click(object sender, EventArgs e)
        {
            FormM newFormM = new FormM(user);
            newFormM.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void CountryN_Click(object sender, EventArgs e)
        {
            FormN newFormN = new FormN(user);
            newFormN.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void CountryP_Click(object sender, EventArgs e)
        {
            FormP newFormP = new FormP(user);
            newFormP.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void CountryR_Click(object sender, EventArgs e)
        {
            FormR newFormR = new FormR(user);
            newFormR.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void CountryS_Click(object sender, EventArgs e)
        {
            FormS newFormS = new FormS(user);
            newFormS.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void CountryW_Click(object sender, EventArgs e)
        {
            FormW newFormW = new FormW(user);
            newFormW.Show();
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
