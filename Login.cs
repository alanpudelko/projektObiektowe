using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using EuroExplorer.Models;

namespace EuroExplorer
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            passwordTextBox.PasswordChar = '*';
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                string username = usernameTextBox.Text;
                string password = passwordTextBox.Text;

                var users = UserUtils.LoadUsers();

                if (!UserUtils.UserExists(users, username))
                {
                    MessageBox.Show("Użytkownik nie istnieje.", "Błąd logowania", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var user = users.Find(u => u.Username == username);
                string storedHashedPassword = user.Password;
                string storedSalt = user.Salt;

                // Verify password with stored hashed password and salt
                if (UserUtils.VerifyPassword(password, storedHashedPassword, storedSalt))
                {
                    // Show successful login message
                    MessageBox.Show("Zalogowano pomyślnie.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Save logged in user data to file
                    var loggedInUserPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "loggedInUser.json");
                    var serializedData = JsonConvert.SerializeObject(user);
                    File.WriteAllText(loggedInUserPath, serializedData);

                    // Open main form and hide login form
                    var mapForm = new Form1(user);
                    mapForm.Show();
                    this.Hide();
                }
                else
                {
                    // Show unsuccessful login message
                    MessageBox.Show("Niepoprawne hasło.", "Błąd logowania", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd: {ex.Message}", "Błąd logowania", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void switchToRegisterButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var registerForm = new Register();
            registerForm.Show();
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {
            // Możesz dodać dodatkową logikę, jeśli potrzebujesz
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            // Możesz dodać dodatkową logikę, jeśli potrzebujesz
        }
    }
}
