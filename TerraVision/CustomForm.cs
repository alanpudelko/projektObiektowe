using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using TerraVision.Models;
using System.Security.Cryptography;
using System.Text;

namespace TerraVision
{
    public class CustomForm : Form
    {
        protected readonly string DataPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "users.json");

        protected List<User> LoadUsers()
        {
            if (!File.Exists(DataPath)) return new List<User>();
            var jsonData = File.ReadAllText(DataPath);
            return JsonConvert.DeserializeObject<List<User>>(jsonData) ?? new List<User>();
        }

        protected void SaveUsers(List<User> users)
        {
            var serializedData = JsonConvert.SerializeObject(users);
            File.WriteAllText(DataPath, serializedData);
        }
        
        protected string HashPassword(string password)
        {
            SHA256 sha256Hash;
            using (sha256Hash = SHA256.Create())
            {
                var bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                var builder = new StringBuilder();
                foreach (var t in bytes)
                {
                    builder.Append(t.ToString("x2"));
                }
                return builder.ToString();
            }
        }
        
        protected bool UserExists(List<User> users, string username)
        {
            return users.Exists(user => user.Username == username);
        }
        
        public User GetLoggedInUser()
        {
            var loggedInUserPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "loggedInUser.json");
            if (!File.Exists(loggedInUserPath)) return null;
            var jsonData = File.ReadAllText(loggedInUserPath);
            return JsonConvert.DeserializeObject<User>(jsonData);
        }
    }
}