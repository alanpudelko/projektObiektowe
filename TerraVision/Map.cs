using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.Projections;
using Newtonsoft.Json.Linq;

namespace TerraVision
{
    public partial class Map : Form
    {
        private GMapControl gmap;
        private HttpClient httpClient;

        public Map()
        {
            httpClient = new HttpClient();

            gmap = new GMapControl();
            gmap.Dock = DockStyle.Fill;
            Controls.Add(gmap);

            gmap.MapProvider = GMapProviders.GoogleMap;
            gmap.DragButton = MouseButtons.Left;

            gmap.Position = new PointLatLng(51.5074, -0.1278); // London
            gmap.MinZoom = 0;
            gmap.MaxZoom = 24;
            gmap.Zoom = 9;
            gmap.AutoScroll = true;

            gmap.OnMapClick += async (latLng, mouseEventArgs) =>
            {
                if (mouseEventArgs.Button == MouseButtons.Left)
                {
                    var countryInfo = await GetCountryInfo(latLng.Lat, latLng.Lng);
                    MessageBox.Show(countryInfo, "Country Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            };
        }

        private async Task<string> GetCountryInfo(double lat, double lng)
        {
            var url = $"https://api.bigdatacloud.net/data/reverse-geocode-client?latitude={lat}&longitude={lng}&localityLanguage=en";
            var response = await httpClient.GetStringAsync(url);
            var jobj = JObject.Parse(response);
            var countryName = jobj["countryName"].ToString();
            var city = jobj["locality"].ToString();

            return $"Country: {countryName}\nCity: {city}";
        }
    }
}
