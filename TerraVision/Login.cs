using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using TerraVision.Models;

namespace TerraVision
{
    public partial class Login : CustomForm
    {
        public Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        
        private void switchToRegisterButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var registerForm = new Register();
            registerForm.Show();
        }

        private void loginButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                string username = usernameTextBox.Text;
                string password = passwordTextBox.Text;

                var users = LoadUsers();

                if (!UserExists(users, username))
                {
                    MessageBox.Show("Użytkownik nie istnieje.", "Błąd logowania", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var user = users.Find(u => u.Username == username);
                string storedHashedPassword = user.Password;
                string storedSalt = user.Salt;

                if (VerifyPassword(password, storedHashedPassword, storedSalt))
                {
                    var loggedInUserPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "loggedInUser.json");
                    var serializedData = JsonConvert.SerializeObject(user);
                    File.WriteAllText(loggedInUserPath, serializedData);

                    var mapForm = new Map(user);
                    mapForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Niepoprawne hasło.", "Błąd logowania", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd: {ex.Message}", "Błąd logowania", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    
}
