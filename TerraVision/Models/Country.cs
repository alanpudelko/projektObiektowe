using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerraVision.Models
{
    public class Country
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Flag { get; set; }
        public Continent Continent { get; set; }
        public string Capital { get; set; }
        public int Population { get; set; }
        public string Area { get; set; }
        public string Region { get; set; }
        public string Subregion { get; set; }
        public string NativeName { get; set; }
        public string NumericCode { get; set; }
        public string[] Borders { get; set; }
        public string[] Languages { get; set; }
        public string[] Currencies { get; set; }
        public string[] Timezones { get; set; }
    }


    public class CountryDataResponse
    {
        public string cca3 { get; set; }
        public string flag { get; set; }
        public Name name { get; set; }
    }

    public class Name
    {
        public string common { get; set; }
    }
}
