using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace EuroExplorer
{
    public partial class Austria : Form
    {
        private Label CurrentTimeLabel = new Label();
        public Austria()
        {
            InitializeComponent();
            Task task = DisplayWeatherAsync();
            Controls.Add(CurrentTimeLabel);
            CurrentTimeLabel.AutoSize = true;
            GetCurrentTimeInVienna();

        }
 

        public class WeatherData
        {
            public MainData? Main { get; set; }
        }

        public class MainData
        {
            public double Temp { get; set; }
        }

        private async Task DisplayWeatherAsync()
        {
            string city = "Vienna";
            string countryCode = "AT";
            string openWeatherMapApiKey = "22feb2021db55d19eb0608f7237cb536";

            try
            {
                var weatherData = await GetWeatherData(city, countryCode, openWeatherMapApiKey);

                if (weatherData != null)
                {
                    InfoAustria.Text = $"Aktualna temperatura w {city}, {countryCode}: {weatherData.Main?.Temp}°C";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd pobierania danych pogodowych: {ex.Message}");
            }
        }



        static async Task<WeatherData?> GetWeatherData(string city, string countryCode, string apiKey)
        {
            using (var httpClient = new HttpClient())
            {
                try
                {
                    var response = await httpClient.GetAsync($"http://api.openweathermap.org/data/2.5/weather?q={city},{countryCode}&appid={apiKey}&units=metric");
                    response.EnsureSuccessStatusCode();
                    var data = await response.Content.ReadFromJsonAsync<WeatherData?>();
                    return data;
                }
                catch (Exception ex)
                {
                    throw new Exception($"Błąd pobierania danych pogodowych: {ex.Message}");
                }
            }
        }
        private void OpisAustrii_TextChanged(object sender, EventArgs e)
        {

        }
        private void InfoAustria_TextChanged(object sender, EventArgs e)
        {
           
        }
        private async void GetCurrentTimeInVienna()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var response = await client.GetAsync("http://worldtimeapi.org/api/timezone/Europe/Vienna");
                    response.EnsureSuccessStatusCode();
                    var content = await response.Content.ReadAsStringAsync();
                    if (!string.IsNullOrEmpty(content))
                    {
                        dynamic result = JsonConvert.DeserializeObject(content);

                        if (result != null)
                        {
                            string time = result.datetime;
                            DateTime? viennaTime = DateTime.Parse(time);

                            if (CurrentTimeLabel != null && viennaTime != null)
                            {
                                CurrentTimeLabel.Text = $"Aktualna godzina w Wiedniu: {viennaTime?.ToString("HH:mm:ss")}";
                            }
                        }
                        else
                        {
                            MessageBox.Show("Brak danych dotyczących czasu w Wiedniu.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Brak danych pobranych z serwera.");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd: {ex.Message}");
            }
        }

    }
}
