using EuroExplorer.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace EuroExplorer
{
    public partial class CustomForm : Form
    {
        protected readonly string DataPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "users.json");

        protected List<User> LoadUsers()
        {
            if (!File.Exists(DataPath))
                return new List<User>();

            string jsonData = File.ReadAllText(DataPath);
            return JsonConvert.DeserializeObject<List<User>>(jsonData) ?? new List<User>();
        }

        protected void SaveUsers(List<User> users)
        {
            string serializedData = JsonConvert.SerializeObject(users);
            File.WriteAllText(DataPath, serializedData);
        }

        protected string GenerateSalt()
        {
            byte[] saltBytes = new byte[32];
            using (var rngCryptoServiceProvider = new RNGCryptoServiceProvider())
            {
                rngCryptoServiceProvider.GetBytes(saltBytes);
            }
            return Convert.ToBase64String(saltBytes);
        }

        protected string HashAndSaltPassword(string password, out string salt)
        {
            salt = GenerateSalt();
            return HashPasswordWithSalt(password, salt);
        }

        protected string HashPasswordWithSalt(string password, string salt)
        {
            using (var sha256Hash = SHA256.Create())
            {
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
                byte[] saltBytes = Convert.FromBase64String(salt);
                byte[] passwordWithSaltBytes = new byte[passwordBytes.Length + saltBytes.Length];

                Buffer.BlockCopy(passwordBytes, 0, passwordWithSaltBytes, 0, passwordBytes.Length);
                Buffer.BlockCopy(saltBytes, 0, passwordWithSaltBytes, passwordBytes.Length, saltBytes.Length);

                byte[] hashedBytes = sha256Hash.ComputeHash(passwordWithSaltBytes);
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }

        protected bool UserExists(List<User> users, string username)
        {
            return users.Exists(user => user.Username == username);
        }

        protected bool VerifyPassword(string password, string hashedPassword, string salt)
        {
            string hashedInputPassword = HashPasswordWithSalt(password, salt);
            return hashedPassword == hashedInputPassword;
        }

        public User GetLoggedInUser()
        {
            var loggedInUserPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "loggedInUser.json");
            if (!File.Exists(loggedInUserPath))
                return null;

            string jsonData = File.ReadAllText(loggedInUserPath);
            return JsonConvert.DeserializeObject<User>(jsonData);
        }
    }
}