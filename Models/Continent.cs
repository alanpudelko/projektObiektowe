using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuroExplorer.Models
{
    internal class Continent
    {
        public string Name { get; set; }
        public List<Country> Countries { get; set; }
    }
}
