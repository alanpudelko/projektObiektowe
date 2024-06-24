namespace EuroExplorer.Models
{
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
