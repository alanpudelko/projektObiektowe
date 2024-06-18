using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using Newtonsoft.Json.Linq;
using TerraVision.Models;

namespace TerraVision
{
    public partial class Map : CustomForm
    {
        private readonly GMapControl _gmap;
        private readonly HttpClient _httpClient;
        private readonly ComboBox _searchBox;
        private readonly Label _loggedInUserLabel;
        
        public Map(User loggedInUser)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new System.Drawing.Size((int)(Screen.PrimaryScreen.Bounds.Width * 0.6), (int)(Screen.PrimaryScreen.Bounds.Height * 0.6));
            this.CenterToScreen();
            var users = LoadUsers();
            var initUser = users.Find(u => u.Username == loggedInUser.Username);
            
            _httpClient = new HttpClient();

            _gmap = new GMapControl();
            _gmap.Dock = DockStyle.Fill;
            Controls.Add(_gmap);

            var container = new Panel();
            container.Dock = DockStyle.Right;
            container.Padding = new Padding(10);
            container.Width = this.Width / 5;
            container.BackColor = Color.White;
            Controls.Add(container);

            var sidebar = new Panel();
            sidebar.Dock = DockStyle.Fill;
            sidebar.BackColor = Color.White;
            container.Controls.Add(sidebar);
            
            var logoutButton = new Button();
            logoutButton.Text = "Logout";
            logoutButton.Dock = DockStyle.Bottom;
            logoutButton.Click += LogoutButton_Click;
            sidebar.Controls.Add(logoutButton);
            
            _searchBox = new ComboBox();
            _searchBox.Dock = DockStyle.Top;
            _searchBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            _searchBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            _searchBox.KeyDown += SearchBox_KeyDown;
            sidebar.Controls.Add(_searchBox);

            var searchLabel = new Label();
            searchLabel.Text = "Search country by name:";
            searchLabel.Dock = DockStyle.Top;
            sidebar.Controls.Add(searchLabel);
            
            _loggedInUserLabel = new Label();
            _loggedInUserLabel.Text = $"Zalogowany jako: {loggedInUser.Username}";
            _loggedInUserLabel.Dock = DockStyle.Top;
            sidebar.Controls.Add(_loggedInUserLabel);
            
            _gmap.MapProvider = GMapProviders.GoogleMap;
            _gmap.DragButton = MouseButtons.Left;
            _gmap.Position = new PointLatLng(51.5074, -0.1278); // London
            _gmap.MinZoom = 3;
            _gmap.MaxZoom = 5;
            _gmap.Zoom = 3;
            _gmap.AutoScroll = true;

            _gmap.OnMapClick += async (latLng, mouseEventArgs) =>
            {
                if (mouseEventArgs.Button != MouseButtons.Left) return;
                Cursor.Current = Cursors.WaitCursor;
                var country = await GetCountryInfoByItude(latLng.Lat, latLng.Lng);
                if (country == null)
                {
                    Cursor.Current = Cursors.Default;
                    return;
                }
                var countryInfoForm = new CountryInfo();
                countryInfoForm.ShowCountryInfo(country);
                countryInfoForm.ShowDialog();
                Cursor.Current = Cursors.Default;
            };

            if (initUser.SearchHistory == null) return;
            initUser.SearchHistory.Reverse();
            foreach (var searchItem in initUser.SearchHistory)
            {
                _searchBox.Items.Add(searchItem);
            }
        }
        
        private void LogoutButton_Click(object sender, EventArgs e)
        {
            var login = new Login();
            login.Show();
            this.Close();
        }
        private async Task<Country> GetCountryInfoByItude(double lat, double lng)
        {
            var countryInfoResponse = await _httpClient.GetStringAsync($"https://api.bigdatacloud.net/data/reverse-geocode-client?latitude={lat}&longitude={lng}&localityLanguage=en");
            var countryInfoData = JObject.Parse(countryInfoResponse);
            var countryCode = countryInfoData["countryCode"]?.ToString();
            var countryTimezoneName = countryInfoData["localityInfo"]?["informative"]?[1]?["name"]?.ToString();
            
            if (countryCode != null && countryCode.Length == 0)
            {
                MessageBox.Show("Country not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            
            var allCountries = await _httpClient.GetStringAsync("https://restcountries.com/v3.1/all");
            var countriesData = JArray.Parse(allCountries);
            var country = countriesData.SelectToken($"$[?(@.cca2 == '{countryCode}')]");
            var countryCommonName = country["name"]?["common"]?.ToString();
            var countryOfficialName = country["name"]?["official"]?.ToString();
            var countryCapital = country["capital"]?[0]?.ToString();
            var countryCurrencies = country["currencies"]?.ToString();
            var countryContinents = country["continents"]?[0]?.ToString();
            var countrySubRegion = country["subregion"]?.ToString();
            var countryLanguages = country["languages"]?.ToString();
            var countryPopulation = country["population"]?.ToString();
            var countryTimezones = country["timezones"]?.ToString();
            var countryArea = country["area"].ToString();
            var countryFlag = country["flags"]["png"].ToString();
            var countryLat = Convert.ToDouble(country["latlng"][0]);
            var countryLng = Convert.ToDouble(country["latlng"][1]);

            var countryWeatherResponse = await _httpClient.GetStringAsync(
                $"https://api.open-meteo.com/v1/forecast?latitude={countryLat}&longitude={countryLng}&current=temperature_2m,wind_speed_10m");
            var countryWeatherData = JObject.Parse(countryWeatherResponse);
            var temperatureUnit = countryWeatherData["current_units"]["temperature_2m"].ToString();
            var speedUnit = countryWeatherData["current_units"]["wind_speed_10m"].ToString();
            var currentTemperature = Convert.ToDouble(countryWeatherData["current"]["temperature_2m"]);
            var currentWindSpeed = Convert.ToDouble(countryWeatherData["current"]["wind_speed_10m"]);

            var newCountry = new Country()
            {
                Code = countryCode,
                CommonName = countryCommonName,
                OfficialName = countryOfficialName,
                Flag = countryFlag,
                Capital = countryCapital,
                Population = int.Parse(countryPopulation),
                Area = countryArea,
                Continent = new Continent { Name = countryContinents },
                Subregion = countrySubRegion,
                Languages = countryLanguages.Split(','),
                Currencies = countryCurrencies.Split(','),
                Timezones = countryTimezones.Split(','),
                Lat = countryLat,
                Lng = countryLng,
                TemperatureUnit = temperatureUnit,
                SpeedUnit = speedUnit,
                CurrentTemperature = currentTemperature,
                CurrentWindSpeed = currentWindSpeed
            };

            return newCountry;
        }
        
        private async void SearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            var country = await SearchCountry(_searchBox.Text);
            e.SuppressKeyPress = true;
            Cursor.Current = Cursors.WaitCursor;

            if (country == null)
            {
                MessageBox.Show("Country not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Cursor.Current = Cursors.Default;
                return;
            }

            var countryInfoForm = new CountryInfo();
            countryInfoForm.ShowCountryInfo(country);
            countryInfoForm.ShowDialog();
            Cursor.Current = Cursors.Default;
        }

        private async Task<Country> SearchCountry(string countryName)
        {
            var allCountries = await _httpClient.GetStringAsync("https://restcountries.com/v3.1/all");
            var countriesData = JArray.Parse(allCountries);
            var country = countriesData.SelectToken($"$[?(@.name.common == '{countryName}')]");
            
            if (country == null) return null;

            var countryCommonName = country["name"]?["common"]?.ToString();
            var countryOfficialName = country["name"]?["official"]?.ToString();
            var countryCode = country["cca2"]?.ToString();
            var countryCapital = country["capital"]?[0]?.ToString();
            var countryCurrencies = country["currencies"]?.ToString();
            var countryContinents = country["continents"]?[0]?.ToString();
            var countrySubRegion = country["subregion"]?.ToString();
            var countryLanguages = country["languages"]?.ToString();
            var countryPopulation = country["population"]?.ToString();
            var countryTimezones = country["timezones"]?.ToString();
            var countryArea = country["area"]?.ToString();
            var countryFlag = country["flags"]?["png"]?.ToString();
            var countryLat = Convert.ToDouble(country["latlng"][0]);
            var countryLng = Convert.ToDouble(country["latlng"][1]);

            var countryWeatherResponse = await _httpClient.GetStringAsync(
                $"https://api.open-meteo.com/v1/forecast?latitude={countryLat}&longitude={countryLng}&current=temperature_2m,wind_speed_10m");
            var countryWeatherData = JObject.Parse(countryWeatherResponse);
            var temperatureUnit = countryWeatherData["current_units"]["temperature_2m"].ToString();
            var speedUnit = countryWeatherData["current_units"]["wind_speed_10m"].ToString();
            var currentTemperature = Convert.ToDouble(countryWeatherData["current"]["temperature_2m"]);
            var currentWindSpeed = Convert.ToDouble(countryWeatherData["current"]["wind_speed_10m"]);

            var newCountry = new Country()
            {
                Code = countryCode,
                CommonName = countryCommonName,
                OfficialName = countryOfficialName,
                Flag = countryFlag,
                Capital = countryCapital,
                Population = int.Parse(countryPopulation),
                Area = countryArea,
                Continent = new Continent { Name = countryContinents },
                Subregion = countrySubRegion,
                Languages = countryLanguages.Split(','),
                Currencies = countryCurrencies.Split(','),
                Timezones = countryTimezones.Split(','),
                Lat = countryLat,
                Lng = countryLng,
                TemperatureUnit = temperatureUnit,
                SpeedUnit = speedUnit,
                CurrentTemperature = currentTemperature,
                CurrentWindSpeed = currentWindSpeed
            };
            
            var users = LoadUsers();
            var loggedInUser = users.Find(u => u.Username == _loggedInUserLabel.Text.Split(':')[1].Trim());
            
            if (loggedInUser.SearchHistory == null)
            {
                loggedInUser.SearchHistory = new List<string>();
            }
            loggedInUser.SearchHistory.Add(countryName);

            while (loggedInUser.SearchHistory.Count > 10)
            {
                loggedInUser.SearchHistory.RemoveAt(0);
            }

            SaveUsers(users);
            
            var users2 = LoadUsers();
            var loggedInUser2 = users2.Find(u => u.Username == _loggedInUserLabel.Text.Split(':')[1].Trim());
            
            _searchBox.Items.Clear();
                
            if (loggedInUser2.SearchHistory != null)
            {
                loggedInUser2.SearchHistory.Reverse();
                foreach (var searchItem in loggedInUser2.SearchHistory)
                {
                    _searchBox.Items.Add(searchItem);
                }
            }
            
            SaveUsers(users);
            
            return newCountry;
        }
    }
}
