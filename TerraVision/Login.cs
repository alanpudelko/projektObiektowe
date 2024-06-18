using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using TerraVision.Models;

namespace TerraVision
{
    public partial class Login : Form
    {
        private readonly string _dataPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "users.json");
        private const int SaltSize = 32;

        public Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            var users = LoadUsers();

            if (!UserExists(users, username))
            {
                Cursor.Current = Cursors.Default;
                MessageBox.Show("User does not exist.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var user = users.Find(u => u.Username == username);
            string hashedPassword = HashAndSaltPassword(password, Convert.FromBase64String(user.Salt));

            if (user.Password != hashedPassword)
            {
                Cursor.Current = Cursors.Default;
                MessageBox.Show("Incorrect password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var loggedInUserPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "loggedInUser.json");
            var serializedData = JsonConvert.SerializeObject(user);
            File.WriteAllText(loggedInUserPath, serializedData);

            var mapForm = new Map(user);
            mapForm.Show();
            this.Hide();
            Cursor.Current = Cursors.Default;
        }

        private void SwitchToRegisterButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var registerForm = new Register();
            registerForm.Show();
        }

        public User GetLoggedInUser()
        {
            var loggedInUserPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "loggedInUser.json");
            if (File.Exists(loggedInUserPath))
            {
                var jsonData = File.ReadAllText(loggedInUserPath);
                return JsonConvert.DeserializeObject<User>(jsonData);
            }
            return null;
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
}
