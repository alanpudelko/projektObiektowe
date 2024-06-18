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
            string hashedPassword = HashPassword(password);
            var users = LoadUsers();

            if (UserExists(users, username))
            {
                MessageBox.Show("User already exists. Try another username.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var user = new User
            {
                Id = users.Count + 1,
                Username = username,
                Password = hashedPassword,
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

        private string HashPassword(string password)
        {
            SHA256 sha256Hash;
            using (sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
