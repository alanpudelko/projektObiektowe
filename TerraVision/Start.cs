using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TerraVision
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            var loginForm = new Login();
            loginForm.StartPosition = FormStartPosition.CenterScreen;
            loginForm.Show();
            this.Hide();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            var registerForm = new Register();
            registerForm.StartPosition = FormStartPosition.CenterScreen;
            registerForm.Show();
            this.Hide();
        }
    }
}
