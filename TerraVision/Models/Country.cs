namespace TerraVision.Models
{
    public class Country
    {
        public string Code { get; set; }
        public string CommonName { get; set; }
        public string OfficialName { get; set; }
        public string Flag { get; set; }
        public string Capital { get; set; }
        public int Population { get; set; }
        public string Area { get; set; }
        public Continent Continent { get; set; }
        public string Subregion { get; set; }
        public string[] Languages { get; set; }
        public string[] Currencies { get; set; }
        public string[] Timezones { get; set; }
        public double Lat { get; set; }
        public double Lng { get; set; }
        public string TemperatureUnit { get; set; }
        public string SpeedUnit { get; set; }
        public double CurrentTemperature { get; set; }
        public double CurrentWindSpeed { get; set; }
    }
}
