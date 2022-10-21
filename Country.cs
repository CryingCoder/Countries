using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountriesMVC
{
    public class Country
    {
        public string Name { get; set; }

        public Continent Continents { get; set; }

        public enum Continent
        {
            Asia,
            Africa,
            Europe,
            Antarctica,
            Australia,
            South_America,
            North_America
        }

        public  List<string> Colors { get; set; } = new List<string>();

        public Country(string Name, Continent Continents, List<string> Colors) 
        {
            this.Name = Name;
            this.Colors = Colors;
            this.Continents = Continents;
            
        }
    }
}
