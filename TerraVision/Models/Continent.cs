using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerraVision.Models
{
    public class Continent
    {
        public string Name { get; set; }
        public List<Country> Countries { get; set; }
    }
}
