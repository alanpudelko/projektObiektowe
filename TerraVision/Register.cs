using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TerraVision.Models;
using Newtonsoft.Json;

namespace TerraVision
{
    public partial class Register : Form
    {
        private readonly string _dataPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "users.json");
        private const int SaltSize = 32;
        public Register()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            var users = LoadUsers();
            foreach (var user in users)
            {
                Console.WriteLine($"Id: {user.Id}");
                Console.WriteLine($"Username: {user.Username}");
                Console.WriteLine($"Password: {user.Password}");
                Console.WriteLine($"SearchHistory: {string.Join(", ", user.SearchHistory)}");
                Console.WriteLine($"HomeLocation: {string.Join(", ", user.HomeLocation)}");
                Console.WriteLine($"Country: {user.Country}");
                Console.WriteLine("=====================================");
            }
        }
        private void DeleteAllUsersButton_Click(object sender, EventArgs e)
        {
            if (File.Exists(_dataPath))
            {
                File.Delete(_dataPath);
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
            var users = LoadUsers();

            if (string.IsNullOrWhiteSpace(usernameTextBox.Text) || string.IsNullOrWhiteSpace(passwordTextBox.Text))
            {
                MessageBox.Show("Pola nazwa użytkownika i hasło nie mogą być puste.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            if (UserExists(users, username))
            {
                MessageBox.Show("User already exists. Try another username.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            byte[] salt = GenerateSalt();
            string hashedPassword = HashAndSaltPassword(password, salt);

            var user = new User
            {
                Id = users.Count + 1,
                Username = username,
                Password = hashedPassword,
                Salt = Convert.ToBase64String(salt),
                SearchHistory = new List<string>(),
                HomeLocation = new List<string>(2),
                Country = "Poland"
            };

            users.Add(user);

            var serializedData = JsonConvert.SerializeObject(users);

            if (!Directory.Exists(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data")))
            {
                Directory.CreateDirectory(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data"));
            }

            File.WriteAllText(_dataPath, serializedData);

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

        private List<User> LoadUsers()
        {
            if (File.Exists(_dataPath))
            {
                var jsonData = File.ReadAllText(_dataPath);
                return JsonConvert.DeserializeObject<List<User>>(jsonData) ?? new List<User>();
            }
            return new List<User>();
        }

        private bool UserExists(List<User> users, string username)
        {
            return users.Exists(user => user.Username == username);
        }
        private byte[] GenerateSalt()
        {
            using (var rngCryptoServiceProvider = new RNGCryptoServiceProvider())
            {
                byte[] salt = new byte[SaltSize];
                rngCryptoServiceProvider.GetBytes(salt);
                return salt;
            }
        }
        private string HashAndSaltPassword(string password, byte[] salt)
        {
            using (var sha256Hash = SHA256.Create())
            {
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
                byte[] passwordWithSaltBytes = new byte[passwordBytes.Length + salt.Length];

                for (int i = 0; i < passwordBytes.Length; i++)
                {
                    passwordWithSaltBytes[i] = passwordBytes[i];
                }
                for (int i = 0; i < salt.Length; i++)
                {
                    passwordWithSaltBytes[passwordBytes.Length + i] = salt[i];
                }

                byte[] hashedBytes = sha256Hash.ComputeHash(passwordWithSaltBytes);
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }
    }
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; } 

        public List<string> SearchHistory { get; set; }
        public List<string> HomeLocation { get; set; }
        public string Country { get; set; }
    }
}
