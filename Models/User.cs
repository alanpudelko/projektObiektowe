using System.Collections.Generic;

namespace EuroExplorer.Models
{
    public interface IUser
    {
        int Id { get; set; }
        string Username { get; set; }
        string Country { get; set; }
    }

    public interface IUserSearchHistory
    {
        List<string> SearchHistory { get; set; }
        void AddToSearchHistory(string searchTerm);
        void ClearSearchHistory();
    }

    public interface IUserHomeLocation
    {
        List<string> HomeLocation { get; set; }
        void AddHomeLocation(string location);
        void RemoveHomeLocation(string location);
    }

    public class User : IUser, IUserSearchHistory, IUserHomeLocation
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public List<string> SearchHistory { get; set; }
        public List<string> HomeLocation { get; set; }
        public string Country { get; set; }

        public void AddToSearchHistory(string searchTerm)
        {
            SearchHistory ??= new List<string>();
            SearchHistory.Add(searchTerm);
        }

        public void ClearSearchHistory()
        {
            SearchHistory?.Clear();
        }

        public void AddHomeLocation(string location)
        {
            HomeLocation ??= new List<string>();
            HomeLocation.Add(location);
        }

        public void RemoveHomeLocation(string location)
        {
            HomeLocation?.Remove(location);
        }
    }
}
