using EuroExplorer.Models;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EuroExplorer
{
    public partial class Form1 : Form
    {
        private User user;
        private User loggedInUser;

        public Form1(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private async Task<string> GetCountryFromCoordinatesAsync(double lat, double lng)
        {
            try
            {
                var apiKey = "bdc_f4fe73c68dfb4b3f93f9baa408e72cfe"; // Replace with your BigDataCloud API key
                using (var client = new HttpClient())
                {
                    var response = await client.GetAsync($"https://api.bigdatacloud.net/data/reverse-geocode-client?latitude={lat}&longitude={lng}&localityLanguage=en&key={apiKey}");

                    if (response.IsSuccessStatusCode)
                    {
                        var jsonString = await response.Content.ReadAsStringAsync();
                        dynamic data = JsonConvert.DeserializeObject(jsonString);
                        Console.WriteLine($"Response JSON: {jsonString}"); // Log the raw JSON response

                        if (data?.countryName != null)
                        {
                            return data.countryName;
                        }
                        else
                        {
                            MessageBox.Show("Country information is not available in the response.", "Error");
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Failed to retrieve data from API. Status Code: {response.StatusCode}", "Error");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Exception occurred while calling API: {ex.Message}", "Error");
            }
            return string.Empty;
        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            GMaps.Instance.Mode = AccessMode.ServerOnly;

            gMapControl1.Position = new PointLatLng(48.210033, 16.363449);
            gMapControl1.MinZoom = 1;
            gMapControl1.MaxZoom = 7;
            gMapControl1.Zoom = 10;

            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;

            // Add click event handler for the map
            gMapControl1.OnMapClick += new GMap.NET.WindowsForms.MapClick(gMapControl1_OnMapClick);
        }

        private async void gMapControl1_OnMapClick(PointLatLng point, MouseEventArgs e)
        {
            // Log the coordinates of the click
            Console.WriteLine($"Clicked at Latitude: {point.Lat}, Longitude: {point.Lng}");

            // Send request to get the country from coordinates
            string country = await GetCountryFromCoordinatesAsync(point.Lat, point.Lng);

            if (!string.IsNullOrEmpty(country))
            {
                // Log the country received from the API
                Console.WriteLine($"Country from API: {country}");

                // Open the appropriate form based on the country
                OpenCountryForm(GetCountryForm(country));
            }
            else
            {
                MessageBox.Show("Failed to retrieve country information from the API.", "Error");
            }
        }

        private Form GetCountryForm(string country)
        {
            // Return the appropriate form based on the country
            switch (country)
            {
                case "Poland":
                    return new Polska(user);
                case "Austria":
                    return new Austria(user);
                case "Belgium":
                    return new Belgia(user);
                case "Bulgaria":
                    return new Bu³garia(user);
                case "Croatia":
                    return new Chorwacja(user);
                case "Cyprus":
                    return new Cypr(user);
                case "Czechia":
                    return new Czechy(user);
                case "Denmark":
                    return new Dania(user);
                case "Estonia":
                    return new Estonia(user);
                case "Finland":
                    return new Finlandia(user);
                case "France":
                    return new Francja(user);
                case "Germany":
                    return new Niemcy(user);
                case "Greece":
                    return new Grecja(user);
                case "Spain":
                    return new Hiszpania(user);
                case "Netherlands":
                    return new Holandia(user);
                case "Ireland":
                    return new Irlandia(user);
                case "Lithuania":
                    return new Litwa(user);
                case "Luxembourg":
                    return new Luksemburg(user);
                case "Latvia":
                    return new £otwa(user);
                case "Malta":
                    return new Malta(user);
                case "Portugal":
                    return new Portugalia(user);
                case "Romania":
                    return new Rumunia(user);
                case "Slovakia":
                    return new S³owacja(user);
                case "Slovenia":
                    return new S³owenia(user);
                case "Sweden":
                    return new Szwecja(user);
                case "Hungary":
                    return new Wêgry(user);
                case "Italy":
                    return new W³ochy(user);
                default:
                    MessageBox.Show("Country not recognized or not implemented.");
                    return null;
            }
        }

        private void OpenCountryForm(Form countryForm)
        {
            if (countryForm != null)
            {
                countryForm.Show();
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void CountryA_Click(object sender, EventArgs e)
        {
            FormA f30 = new FormA(loggedInUser);
            f30.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void CountryB_Click(object sender, EventArgs e)
        {
            FormB f31 = new FormB(loggedInUser);
            f31.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void CountryC_Click(object sender, EventArgs e)
        {
            FormC f32 = new FormC(loggedInUser);
            f32.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void CountryD_Click(object sender, EventArgs e)
        {
            FormD f33 = new FormD(loggedInUser);
            f33.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void CountryE_Click(object sender, EventArgs e)
        {
            FormE f34 = new FormE(loggedInUser);
            f34.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void CountryF_Click(object sender, EventArgs e)
        {
            FormF f35 = new FormF(loggedInUser);
            f35.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void CountryG_Click(object sender, EventArgs e)
        {
            FormG f36 = new FormG(loggedInUser);
            f36.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void CountryH_Click(object sender, EventArgs e)
        {
            FormH f37 = new FormH(loggedInUser);
            f37.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void CountryI_Click(object sender, EventArgs e)
        {
            FormI f38 = new FormI(loggedInUser);
            f38.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void CountryL_Click(object sender, EventArgs e)
        {
            FormL f39 = new FormL(loggedInUser);
            f39.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void Country£_Click(object sender, EventArgs e)
        {
            Form£ f40 = new Form£(loggedInUser);
            f40.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void CountryM_Click(object sender, EventArgs e)
        {
            FormM f41 = new FormM(loggedInUser);
            f41.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void CountryN_Click(object sender, EventArgs e)
        {
            FormW f42 = new FormW(loggedInUser);
            f42.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void CountryP_Click(object sender, EventArgs e)
        {
            FormP f43 = new FormP(loggedInUser);
            f43.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void CountryR_Click(object sender, EventArgs e)
        {
            FormR f44 = new FormR(loggedInUser);
            f44.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void CountryS_Click(object sender, EventArgs e)
        {
            FormS f45 = new FormS(loggedInUser);
            f45.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void CountryW_Click(object sender, EventArgs e)
        {
            FormW f46 = new FormW(loggedInUser);
            f46.Show();
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
