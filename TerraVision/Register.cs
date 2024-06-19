using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;
using TerraVision.Models;
using Newtonsoft.Json;
using System.Security.Cryptography;
using System.Text;

namespace TerraVision
{
    public partial class Register : CustomForm
    {
        public Register()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void DeleteAllUsersButton_Click(object sender, EventArgs e)
        {
            if (File.Exists(DataPath))
            {
                File.Delete(DataPath);
                MessageBox.Show("Wszyscy użytkownicy zostali usunięci.", "Usuwanie użytkowników", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Nie ma żadnych użytkowników do usunięcia.", "Usuwanie użytkowników", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Pola nazwa użytkownika i hasło nie mogą być puste.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var users = LoadUsers();

            if (UserExists(users, username))
            {
                MessageBox.Show("User already exists. Try another username.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string salt;
            string hashedPassword = HashAndSaltPassword(password, out salt);

            var user = new User
            {
                Id = users.Count + 1,
                Username = username,
                Password = hashedPassword,
                Salt = salt,
                SearchHistory = new List<string>(),
                HomeLocation = new List<string>(2),
                Country = "Poland"
            };

            users.Add(user);

            var serializedData = JsonConvert.SerializeObject(users);

            if (!Directory.Exists(Path.GetDirectoryName(DataPath)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(DataPath));
            }

            File.WriteAllText(DataPath, serializedData);

            MessageBox.Show("User registered successfully.", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }

        private void SwitchToLoginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var loginForm = new Login();
            loginForm.Show();
        }
    }
}
