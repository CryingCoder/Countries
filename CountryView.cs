using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountriesMVC
{
    public class CountryView
    {
      
        public Country DisplayCountry { get; set; }

        public void Display()
        {

            Console.WriteLine($"Country : {DisplayCountry.Name}");
            Console.WriteLine($"Colors : {DisplayCountry.Colors}");
            Console.WriteLine($"Continent : {DisplayCountry.Continents}");

        }

        public CountryView(Country country)
        {
            this.DisplayCountry = country;
        }
    

    }
    
}
