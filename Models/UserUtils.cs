using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using EuroExplorer.Models;

namespace EuroExplorer
{
    public static class UserUtils
    {
        private static readonly string DataDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");
        private static readonly string DataPath = Path.Combine(DataDirectory, "users.json");

        public static List<User> LoadUsers()
        {
            EnsureDataDirectoryExists();

            if (!File.Exists(DataPath))
            {
                SaveUsers(new List<User>());
                return new List<User>();
            }

            string jsonData = File.ReadAllText(DataPath);
            return JsonConvert.DeserializeObject<List<User>>(jsonData) ?? new List<User>();
        }

        public static void SaveUsers(List<User> users)
        {
            EnsureDataDirectoryExists();

            string serializedData = JsonConvert.SerializeObject(users);
            File.WriteAllText(DataPath, serializedData);
        }

        private static void EnsureDataDirectoryExists()
        {
            if (!Directory.Exists(DataDirectory))
            {
                Directory.CreateDirectory(DataDirectory);
            }
        }

        public static string GenerateSalt()
        {
            byte[] saltBytes = new byte[32];
            using (var rngCryptoServiceProvider = new RNGCryptoServiceProvider())
            {
                rngCryptoServiceProvider.GetBytes(saltBytes);
            }
            return Convert.ToBase64String(saltBytes);
        }

        public static string HashPasswordWithSalt(string password, out string salt)
        {
            salt = GenerateSalt();

            using (var sha256 = SHA256.Create())
            {
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password + salt);
                byte[] hashedPasswordBytes = sha256.ComputeHash(passwordBytes);
                string hashedPassword = Convert.ToBase64String(hashedPasswordBytes);
                return hashedPassword;
            }
        }

        public static bool VerifyPassword(string password, string hashedPassword, string salt)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password + salt);
                byte[] hashedPasswordBytes = sha256.ComputeHash(passwordBytes);
                string hashedInputPassword = Convert.ToBase64String(hashedPasswordBytes);

                return hashedInputPassword == hashedPassword;
            }
        }

        public static bool UserExists(List<User> users, string username)
        {
            return users.Exists(user => user.Username == username);
        }

        public static string GetDataPath()
        {
            return DataPath;
        }
    }
}
