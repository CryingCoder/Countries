using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountriesMVC
{
    public class CountryListView
    {
        public List<Country> Countries { get; set; }



        public CountryListView(List<Country> Countries)
        {
            this.Countries = Countries;
        }


        public void Display()
        {
            int i = 1;
            foreach (Country country in Countries)
            {

                Console.WriteLine($"{i} : {Countries}");
                i++;

            }
        }
    }
}
