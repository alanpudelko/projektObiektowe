using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerraVision.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public List<string> SearchHistory { get; set; }
        public List<string> HomeLocation { get; set; }
        public string Country { get; set; }

        public User()
        {
            SearchHistory = new List<string>();
            HomeLocation = new List<string>(2);
        }
    }
}
