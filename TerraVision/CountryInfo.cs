using System;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Windows.Forms;
using TerraVision.Models;

namespace TerraVision
{
    public partial class CountryInfo : Form
    {
        private PictureBox flagPictureBox;
        private Label nameLabel;
        private TextBox nameTextBox;
        private Label codeLabel;
        private TextBox codeTextBox;
        private Label officialNameLabel;
        private TextBox officialNameTextBox;
        private Label capitalLabel;
        private TextBox capitalTextBox;
        private Label populationLabel;
        private TextBox populationTextBox;
        private Label languagesLabel;
        private TextBox languagesTextBox;
        private Label currenciesLabel;
        private TextBox currenciesTextBox;
        private Label areaLabel;
        private TextBox areaTextBox;
        private Label continentLabel;
        private TextBox continentTextBox;
        private Label subregionLabel;
        private TextBox subregionTextBox;
        private Label timezonesLabel;
        private TextBox timezonesTextBox;
        private Label coordinatesLabel;
        private TextBox coordinatesTextBox;
        private Label temperatureUnitLabel;
        private TextBox temperatureUnitTextBox;
        private Label speedUnitLabel;
        private TextBox speedUnitTextBox;
        private Label currentTemperatureLabel;
        private TextBox currentTemperatureTextBox;
        private Label currentWindSpeedLabel;
        private TextBox currentWindSpeedTextBox;
        public CountryInfo()
        {
            InitializeComponent();
            
            Panel scrollablePanel = new Panel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true
            };
            
            flagPictureBox = new PictureBox
            {
                Dock = DockStyle.Top,
                SizeMode = PictureBoxSizeMode.CenterImage,
                Height = 100
            };
            nameLabel = new Label() { Text = "Common Name", Dock = DockStyle.Top };
            nameTextBox = new TextBox() { Dock = DockStyle.Top, ReadOnly = true };
            codeLabel = new Label() { Text = "Code", Dock = DockStyle.Top };
            codeTextBox = new TextBox() { Dock = DockStyle.Top, ReadOnly = true };
            officialNameLabel = new Label() { Text = "Official Name", Dock = DockStyle.Top };
            officialNameTextBox = new TextBox() { Dock = DockStyle.Top, ReadOnly = true };
            capitalLabel = new Label() { Text = "Capital", Dock = DockStyle.Top };
            capitalTextBox = new TextBox() { Dock = DockStyle.Top, ReadOnly = true };
            populationLabel = new Label() { Text = "Population", Dock = DockStyle.Top };
            populationTextBox = new TextBox() { Dock = DockStyle.Top, ReadOnly = true };
            languagesLabel = new Label() { Text = "Languages", Dock = DockStyle.Top };
            languagesTextBox = new TextBox() { Dock = DockStyle.Top, ReadOnly = true };
            currenciesLabel = new Label() { Text = "Currencies", Dock = DockStyle.Top };
            currenciesTextBox = new TextBox() { Dock = DockStyle.Top, ReadOnly = true };
            areaLabel = new Label() { Text = "Area", Dock = DockStyle.Top };
            areaTextBox = new TextBox() { Dock = DockStyle.Top, ReadOnly = true };
            continentLabel = new Label() { Text = "Continent", Dock = DockStyle.Top };
            continentTextBox = new TextBox() { Dock = DockStyle.Top, ReadOnly = true };
            subregionLabel = new Label() { Text = "Subregion", Dock = DockStyle.Top };
            subregionTextBox = new TextBox() { Dock = DockStyle.Top, ReadOnly = true };
            timezonesLabel = new Label() { Text = "Timezones", Dock = DockStyle.Top };
            timezonesTextBox = new TextBox() { Dock = DockStyle.Top, ReadOnly = true };
            coordinatesLabel = new Label() { Text = "Coordinates", Dock = DockStyle.Top };
            coordinatesTextBox = new TextBox() { Dock = DockStyle.Top, ReadOnly = true };
            temperatureUnitLabel = new Label() { Text = "Temperature Unit", Dock = DockStyle.Top };
            temperatureUnitTextBox = new TextBox() { Dock = DockStyle.Top, ReadOnly = true };
            speedUnitLabel = new Label() { Text = "Speed Unit", Dock = DockStyle.Top };
            speedUnitTextBox = new TextBox() { Dock = DockStyle.Top, ReadOnly = true };
            currentTemperatureLabel = new Label() { Text = "Current Temperature", Dock = DockStyle.Top };
            currentTemperatureTextBox = new TextBox() { Dock = DockStyle.Top, ReadOnly = true };
            currentWindSpeedLabel = new Label() { Text = "Current Wind Speed", Dock = DockStyle.Top };
            currentWindSpeedTextBox = new TextBox() { Dock = DockStyle.Top, ReadOnly = true };
            
            scrollablePanel.Controls.Add(currentWindSpeedTextBox);
            scrollablePanel.Controls.Add(currentWindSpeedLabel);
            scrollablePanel.Controls.Add(currentTemperatureTextBox);
            scrollablePanel.Controls.Add(currentTemperatureLabel);
            scrollablePanel.Controls.Add(speedUnitTextBox);
            scrollablePanel.Controls.Add(speedUnitLabel);
            scrollablePanel.Controls.Add(temperatureUnitTextBox);
            scrollablePanel.Controls.Add(temperatureUnitLabel);
            scrollablePanel.Controls.Add(coordinatesTextBox);
            scrollablePanel.Controls.Add(coordinatesLabel);
            scrollablePanel.Controls.Add(timezonesTextBox);
            scrollablePanel.Controls.Add(timezonesLabel);
            scrollablePanel.Controls.Add(subregionTextBox);
            scrollablePanel.Controls.Add(subregionLabel);
            scrollablePanel.Controls.Add(continentTextBox);
            scrollablePanel.Controls.Add(continentLabel);
            scrollablePanel.Controls.Add(areaTextBox);
            scrollablePanel.Controls.Add(areaLabel);
            scrollablePanel.Controls.Add(currenciesTextBox);
            scrollablePanel.Controls.Add(currenciesLabel);
            scrollablePanel.Controls.Add(languagesTextBox);
            scrollablePanel.Controls.Add(languagesLabel);
            scrollablePanel.Controls.Add(populationTextBox);
            scrollablePanel.Controls.Add(populationLabel);
            scrollablePanel.Controls.Add(capitalTextBox);
            scrollablePanel.Controls.Add(capitalLabel);
            scrollablePanel.Controls.Add(officialNameTextBox);
            scrollablePanel.Controls.Add(officialNameLabel);
            scrollablePanel.Controls.Add(codeTextBox);
            scrollablePanel.Controls.Add(codeLabel);
            scrollablePanel.Controls.Add(nameTextBox);
            scrollablePanel.Controls.Add(nameLabel);
            scrollablePanel.Controls.Add(flagPictureBox);

            // Add the Panel to the Form
            Controls.Add(scrollablePanel);
            

            Text = "Country Info";
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            
        }

        public async void ShowCountryInfo(Country country)
        {
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(country.Flag);
                using (var stream = await response.Content.ReadAsStreamAsync())
                {
                    flagPictureBox.Image = new Bitmap(stream);
                }
            }
            nameTextBox.Text = country.CommonName;
            codeTextBox.Text = country.Code;
            officialNameTextBox.Text = country.OfficialName;
            capitalTextBox.Text = country.Capital;
            populationTextBox.Text = country.Population.ToString();
            languagesTextBox.Text = string.Join(", ", country.Languages);
            currenciesTextBox.Text = string.Join(", ", country.Currencies);
            areaTextBox.Text = country.Area;
            continentTextBox.Text = country.Continent.Name;
            subregionTextBox.Text = country.Subregion;
            timezonesTextBox.Text = string.Join(", ", country.Timezones);
            coordinatesTextBox.Text = $"Lat: {country.Lat}, Lng: {country.Lng}";
            temperatureUnitTextBox.Text = country.TemperatureUnit;
            speedUnitTextBox.Text = country.SpeedUnit;
            currentTemperatureTextBox.Text = country.CurrentTemperature.ToString();
            currentWindSpeedTextBox.Text = country.CurrentWindSpeed.ToString();
        }
    }
}