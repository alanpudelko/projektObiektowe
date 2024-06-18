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
            string hashedPassword = HashPassword(password);
            var users = LoadUsers();

            if (!UserExists(users, username))
            {
                Cursor.Current = Cursors.Default;
                MessageBox.Show("User does not exist.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var user = users.Find(u => u.Username == username);
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
