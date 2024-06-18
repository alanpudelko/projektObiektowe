using System;
using System.Windows.Forms;
using TerraVision.Models;

namespace TerraVision
{
    public partial class CountryInfo : Form
    {
        private Label nameLabel;
        private TextBox nameTextBox;
        // Dodaj więcej kontrolek dla innych właściwości kraju
        
        public CountryInfo()
        {
            InitializeComponent();
            
            nameLabel = new Label() { Text = "Name", Dock = DockStyle.Top };
            nameTextBox = new TextBox() { Dock = DockStyle.Top, ReadOnly = true };
            // Inicjalizuj więcej kontrolek dla innych właściwości kraju

            Controls.Add(nameTextBox);
            Controls.Add(nameLabel);
            // Dodaj więcej kontrolek do formy

            Text = "Country Info";
            StartPosition = FormStartPosition.CenterScreen;
        }
        
        public void ShowCountryInfo(Country country)
        {
            nameTextBox.Text = country.CommonName;
            // Ustaw wartości dla innych kontrolek na podstawie obiektu country
        }
    }
}