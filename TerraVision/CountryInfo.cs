using System.Drawing;
using System.Globalization;
using System.Net.Http;
using System.Windows.Forms;
using TerraVision.Models;

namespace TerraVision
{
    public partial class CountryInfo : Form
    {
        private readonly PictureBox _flagPictureBox;
        private readonly TextBox _nameTextBox;
        private readonly TextBox _codeTextBox;
        private readonly TextBox _officialNameTextBox;
        private readonly TextBox _capitalTextBox;
        private readonly TextBox _populationTextBox;
        private readonly TextBox _languagesTextBox;
        private readonly TextBox _currenciesTextBox;
        private readonly TextBox _areaTextBox;
        private readonly TextBox _continentTextBox;
        private readonly TextBox _subregionTextBox;
        private readonly TextBox _timezonesTextBox;
        private readonly TextBox _coordinatesTextBox;
        private readonly TextBox _temperatureUnitTextBox;
        private readonly TextBox _speedUnitTextBox;
        private readonly TextBox _currentTemperatureTextBox;
        private readonly TextBox _currentWindSpeedTextBox;

        public CountryInfo()
        {
            InitializeComponent();
            
            var scrollablePanel = new Panel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true
            };
            
            _flagPictureBox = new PictureBox
            {
                Dock = DockStyle.Top,
                SizeMode = PictureBoxSizeMode.CenterImage,
                Height = 100
            };
            var nameLabel = new Label() { Text = "Common Name", Dock = DockStyle.Top };
            _nameTextBox = new TextBox() { Dock = DockStyle.Top, ReadOnly = true };
            var codeLabel = new Label() { Text = "Code", Dock = DockStyle.Top };
            _codeTextBox = new TextBox() { Dock = DockStyle.Top, ReadOnly = true };
            var officialNameLabel = new Label() { Text = "Official Name", Dock = DockStyle.Top };
            _officialNameTextBox = new TextBox() { Dock = DockStyle.Top, ReadOnly = true };
            var capitalLabel = new Label() { Text = "Capital", Dock = DockStyle.Top };
            _capitalTextBox = new TextBox() { Dock = DockStyle.Top, ReadOnly = true };
            var populationLabel = new Label() { Text = "Population", Dock = DockStyle.Top };
            _populationTextBox = new TextBox() { Dock = DockStyle.Top, ReadOnly = true };
            var languagesLabel = new Label() { Text = "Languages", Dock = DockStyle.Top };
            _languagesTextBox = new TextBox() { Dock = DockStyle.Top, ReadOnly = true };
            var currenciesLabel = new Label() { Text = "Currencies", Dock = DockStyle.Top };
            _currenciesTextBox = new TextBox() { Dock = DockStyle.Top, ReadOnly = true };
            var areaLabel = new Label() { Text = "Area", Dock = DockStyle.Top };
            _areaTextBox = new TextBox() { Dock = DockStyle.Top, ReadOnly = true };
            var continentLabel = new Label() { Text = "Continent", Dock = DockStyle.Top };
            _continentTextBox = new TextBox() { Dock = DockStyle.Top, ReadOnly = true };
            var subregionLabel = new Label() { Text = "Subregion", Dock = DockStyle.Top };
            _subregionTextBox = new TextBox() { Dock = DockStyle.Top, ReadOnly = true };
            var timezonesLabel = new Label() { Text = "Timezones", Dock = DockStyle.Top };
            _timezonesTextBox = new TextBox() { Dock = DockStyle.Top, ReadOnly = true };
            var coordinatesLabel = new Label() { Text = "Coordinates", Dock = DockStyle.Top };
            _coordinatesTextBox = new TextBox() { Dock = DockStyle.Top, ReadOnly = true };
            var temperatureUnitLabel = new Label() { Text = "Temperature Unit", Dock = DockStyle.Top };
            _temperatureUnitTextBox = new TextBox() { Dock = DockStyle.Top, ReadOnly = true };
            var speedUnitLabel = new Label() { Text = "Speed Unit", Dock = DockStyle.Top };
            _speedUnitTextBox = new TextBox() { Dock = DockStyle.Top, ReadOnly = true };
            var currentTemperatureLabel = new Label() { Text = "Current Temperature", Dock = DockStyle.Top };
            _currentTemperatureTextBox = new TextBox() { Dock = DockStyle.Top, ReadOnly = true };
            var currentWindSpeedLabel = new Label() { Text = "Current Wind Speed", Dock = DockStyle.Top };
            _currentWindSpeedTextBox = new TextBox() { Dock = DockStyle.Top, ReadOnly = true };
            
            scrollablePanel.Controls.Add(_currentWindSpeedTextBox);
            scrollablePanel.Controls.Add(currentWindSpeedLabel);
            scrollablePanel.Controls.Add(_currentTemperatureTextBox);
            scrollablePanel.Controls.Add(currentTemperatureLabel);
            scrollablePanel.Controls.Add(_speedUnitTextBox);
            scrollablePanel.Controls.Add(speedUnitLabel);
            scrollablePanel.Controls.Add(_temperatureUnitTextBox);
            scrollablePanel.Controls.Add(temperatureUnitLabel);
            scrollablePanel.Controls.Add(_coordinatesTextBox);
            scrollablePanel.Controls.Add(coordinatesLabel);
            scrollablePanel.Controls.Add(_timezonesTextBox);
            scrollablePanel.Controls.Add(timezonesLabel);
            scrollablePanel.Controls.Add(_subregionTextBox);
            scrollablePanel.Controls.Add(subregionLabel);
            scrollablePanel.Controls.Add(_continentTextBox);
            scrollablePanel.Controls.Add(continentLabel);
            scrollablePanel.Controls.Add(_areaTextBox);
            scrollablePanel.Controls.Add(areaLabel);
            scrollablePanel.Controls.Add(_currenciesTextBox);
            scrollablePanel.Controls.Add(currenciesLabel);
            scrollablePanel.Controls.Add(_languagesTextBox);
            scrollablePanel.Controls.Add(languagesLabel);
            scrollablePanel.Controls.Add(_populationTextBox);
            scrollablePanel.Controls.Add(populationLabel);
            scrollablePanel.Controls.Add(_capitalTextBox);
            scrollablePanel.Controls.Add(capitalLabel);
            scrollablePanel.Controls.Add(_officialNameTextBox);
            scrollablePanel.Controls.Add(officialNameLabel);
            scrollablePanel.Controls.Add(_codeTextBox);
            scrollablePanel.Controls.Add(codeLabel);
            scrollablePanel.Controls.Add(_nameTextBox);
            scrollablePanel.Controls.Add(nameLabel);
            scrollablePanel.Controls.Add(_flagPictureBox);
            
            Controls.Add(scrollablePanel);
            
            Text = "Country Info";
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        public async void ShowCountryInfo(Country country)
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(country.Flag);
                using (var stream = await response.Content.ReadAsStreamAsync())
                {
                    _flagPictureBox.Image = new Bitmap(stream);
                }
            }
            _nameTextBox.Text = country.CommonName;
            _codeTextBox.Text = country.Code;
            _officialNameTextBox.Text = country.OfficialName;
            _capitalTextBox.Text = country.Capital;
            _populationTextBox.Text = country.Population.ToString();
            _languagesTextBox.Text = string.Join(", ", country.Languages);
            _currenciesTextBox.Text = string.Join(", ", country.Currencies);
            _areaTextBox.Text = country.Area;
            _continentTextBox.Text = country.Continent.Name;
            _subregionTextBox.Text = country.Subregion;
            _timezonesTextBox.Text = string.Join(", ", country.Timezones);
            _coordinatesTextBox.Text = $"Lat: {country.Lat}, Lng: {country.Lng}";
            _temperatureUnitTextBox.Text = country.TemperatureUnit;
            _speedUnitTextBox.Text = country.SpeedUnit;
            _currentTemperatureTextBox.Text = country.CurrentTemperature.ToString(CultureInfo.CurrentCulture);
            _currentWindSpeedTextBox.Text = country.CurrentWindSpeed.ToString(CultureInfo.CurrentCulture);
        }
    }
}