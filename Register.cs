using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using EuroExplorer.Models;

namespace EuroExplorer
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            passwordTextBox.PasswordChar = '*';
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Pola nazwa użytkownika i hasło nie mogą być puste.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var users = UserUtils.LoadUsers();

            if (UserUtils.UserExists(users, username))
            {
                MessageBox.Show("Użytkownik już istnieje. Spróbuj innej nazwy użytkownika.", "Błąd rejestracji", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string salt;
            string hashedPassword = UserUtils.HashPasswordWithSalt(password, out salt);

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

            UserUtils.SaveUsers(users);

            MessageBox.Show("Rejestracja użytkownika przebiegła pomyślnie.", "Rejestracja pomyślna", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }


        private void loginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var loginForm = new Login();
            loginForm.Show();
        }

        private void deleteAllUsersButton_Click(object sender, EventArgs e)
        {
            if (File.Exists(UserUtils.GetDataPath()))
            {
                File.Delete(UserUtils.GetDataPath());
                MessageBox.Show("Wszyscy użytkownicy zostali usunięci.", "Usuwanie użytkowników", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Nie ma żadnych użytkowników do usunięcia.", "Usuwanie użytkowników", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
