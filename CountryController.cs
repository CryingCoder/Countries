using CountriesMVC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountriesMVC
{
    public class CountryController
    {

        public List<Country> CountryDb = new List<Country>()
        {
            new Country("Japan", Country.Continent.Asia, new List<string> { "Red", "White" }),
            new Country("Uruguay", Country.Continent.South_America, new List<string> { "White", "Gold", "Blue" }),
            new Country("Canada", Country.Continent.North_America, new List<string> { "Red", "White" }),
            new Country("Australia", Country.Continent.Australia, new List<string> { "Blue", "White", "Red" }),
            new Country("Germany", Country.Continent.Europe, new List<string> { "Red", "Black", "Yellow" }),
            new Country("Antarctica is a Country", Country.Continent.Antarctica, new List<string> { "Red", "White", "Blue" }),
            new Country("Chad", Country.Continent.Africa, new List<string> { "Blue", "Yellow", "Red" }),
            new Country("Senegal", Country.Continent.Africa, new List<string> { "Green", "Yellow", "Red" }),
            new Country("PenguinCity", Country.Continent.Antarctica, new List<string> { "Black" })
        };
        

        public CountryController()
        {

        }
        

        public void CountryAction(Country c)
        {

            CountryView cv = new CountryView(c);
            cv.Display();

        }


        public void WelcomeAction()
        {
            
            Console.WriteLine("Hello, welcome to the country app.");
            CountryListView cv = new CountryListView(CountryDb);
            cv.Display();

            Console.WriteLine();
            Console.WriteLine("Please select a country from the following list:");

            bool rightIndex = true;
            while (rightIndex == true)
            {
                
                int index;
                int.TryParse(Console.ReadLine().Trim(), out index);
                if (index <= CountryDb.Count && index >= 0)
                {
                    Country pick = CountryDb[index];
                    CountryAction(pick);
                    rightIndex = false;
                }
                else
                {
                    Console.WriteLine("I'm sorry, that number is not on the list. Please select a country by index.");

                }
            }
        }
    }
}
