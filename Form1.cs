using EuroExplorer.Models;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace EuroExplorer
{
    public partial class Form1 : Form
    {
        private User user;

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



        private void Title_Click(object sender, EventArgs e)
        {
            // Obs³uga klikniêcia na tytu³, jeœli jest wymagana
        }

        private void CountryA_Click(object sender, EventArgs e)
        {
            FormA newFormA = new FormA(user);
            newFormA.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void CountryB_Click(object sender, EventArgs e)
        {
            FormB newFormB = new FormB(user);
            newFormB.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void CountryC_Click(object sender, EventArgs e)
        {
            FormC newFormC = new FormC(user);
            newFormC.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void CountryD_Click(object sender, EventArgs e)
        {
            FormD newFormD = new FormD(user);
            newFormD.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void CountryE_Click(object sender, EventArgs e)
        {
            FormE newFormE = new FormE(user);
            newFormE.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void CountryF_Click(object sender, EventArgs e)
        {
            FormF newFormF = new FormF(user);
            newFormF.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void CountryG_Click(object sender, EventArgs e)
        {
            FormG newFormG = new FormG(user);
            newFormG.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void CountryH_Click(object sender, EventArgs e)
        {
            FormH newFormH = new FormH(user);
            newFormH.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void CountryI_Click(object sender, EventArgs e)
        {
            FormI newFormI = new FormI(user);
            newFormI.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void CountryL_Click(object sender, EventArgs e)
        {
            FormL newFormL = new FormL(user);
            newFormL.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void Country£_Click(object sender, EventArgs e)
        {
            Form£ newForm£ = new Form£(user);
            newForm£.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void CountryM_Click(object sender, EventArgs e)
        {
            FormM newFormM = new FormM(user);
            newFormM.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void CountryN_Click(object sender, EventArgs e)
        {
            FormN newFormN = new FormN(user);
            newFormN.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void CountryP_Click(object sender, EventArgs e)
        {
            FormP newFormP = new FormP(user);
            newFormP.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void CountryR_Click(object sender, EventArgs e)
        {
            FormR newFormR = new FormR(user);
            newFormR.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void CountryS_Click(object sender, EventArgs e)
        {
            FormS newFormS = new FormS(user);
            newFormS.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void CountryW_Click(object sender, EventArgs e)
        {
            FormW newFormW = new FormW(user);
            newFormW.Show();
            this.WindowState = FormWindowState.Minimized;
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
                switch (country)
                {
                        case "Poland":
                            OpenCountryForm(new Polska(user));
                            break;
                        case "Austria":
                            OpenCountryForm(new Austria(user));
                            break;
                        case "Belgium":
                            OpenCountryForm(new Belgia(user)); // Change to Belgium
                            break;
                        case "Bulgaria":
                            OpenCountryForm(new Bu³garia(user)); // Change to Bulgaria
                            break;
                        case "Croatia":
                            OpenCountryForm(new Chorwacja(user)); // Change to Croatia
                            break;
                        case "Cyprus":
                            OpenCountryForm(new Cypr(user)); // Change to Cyprus
                            break;
                        case "Czechia":
                            OpenCountryForm(new Czechy(user)); // Change to Czechy
                            break;
                        case "Denmark":
                            OpenCountryForm(new Dania(user)); // Change to Dania
                            break;
                        case "Estonia":
                            OpenCountryForm(new Estonia(user));
                            break;
                        case "Finland":
                            OpenCountryForm(new Finlandia(user)); // Change to Finlandia
                            break;
                        case "France":
                            OpenCountryForm(new Francja(user)); // Change to Francja
                            break;
                        case "Germany":
                            OpenCountryForm(new Niemcy(user)); // Change to Niemcy
                            break;
                        case "Greece":
                            OpenCountryForm(new Grecja(user)); // Change to Grecja
                            break;
                        case "Spain":
                            OpenCountryForm(new Hiszpania(user)); // Change to Hiszpania
                            break;
                        case "Netherlands":
                            OpenCountryForm(new Holandia(user)); // Change to Holandia
                            break;
                        case "Ireland":
                            OpenCountryForm(new Irlandia(user)); // Change to Irlandia
                            break;
                        case "Lithuania":
                            OpenCountryForm(new Litwa(user)); // Change to Litwa
                            break;
                        case "Luxembourg":
                            OpenCountryForm(new Luksemburg(user)); // Change to Luksemburg
                            break;
                        case "Latvia":
                            OpenCountryForm(new £otwa(user)); // Change to £otwa
                            break;
                        case "Malta":
                            OpenCountryForm(new Malta(user));
                            break;
                        case "Portugal":
                            OpenCountryForm(new Portugalia(user)); // Change to Portugalia
                            break;
                        case "Romania":
                            OpenCountryForm(new Rumunia(user)); // Change to Rumunia
                            break;
                        case "Slovakia":
                            OpenCountryForm(new S³owacja(user)); // Change to S³owacja
                            break;
                        case "Slovenia":
                            OpenCountryForm(new S³owenia(user)); // Change to S³owenia
                            break;
                        case "Sweden":
                            OpenCountryForm(new Szwecja(user)); // Change to Szwecja
                            break;
                        case "Hungary":
                            OpenCountryForm(new Wêgry(user));
                            break;
                        case "Italy":
                        OpenCountryForm(new W³ochy(user));// Change to Wêgry
                            break;

                    default:
                        MessageBox.Show("Country not recognized or not implemented.");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Failed to retrieve country information from the API.", "Error");
            }
        }

        private void OpenCountryForm(Form countryForm)
        {
            countryForm.Show();
            this.WindowState = FormWindowState.Minimized;
        }


    }
}
