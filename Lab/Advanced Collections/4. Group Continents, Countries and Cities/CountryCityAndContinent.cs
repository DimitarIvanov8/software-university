using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Group_Continents__Countries_and_Cities
{
    class CountryCityAndContinent
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, SortedDictionary<string, SortedSet<string>>> location =
                new SortedDictionary<string, SortedDictionary<string, SortedSet<string>>>();

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Split(' ');
                var continent = line[0];
                var country = line[1];
                var city = line[2];

                AddLocations(location, continent, country, city);
            }

            foreach (var continentsCountries in location)
            {
                var continentName = continentsCountries.Key;
                var countries = continentsCountries.Value;

                Console.WriteLine($"{continentName}:");
                foreach (var countryCities in countries)
                {
                    var countryName = countryCities.Key;
                    var cities = countryCities.Value;
                    Console.WriteLine("  {0} -> {1}",
                        countryName, String.Join(", ", cities));
                }
            }
        }

        private static void AddLocations(SortedDictionary<string, SortedDictionary<string, SortedSet<string>>> 
            location, string continent, string country, string city)
        {
            if (!location.ContainsKey(continent))
            {
                location[continent] = new SortedDictionary<string, SortedSet<string>>();
            }
            if (!location[continent].ContainsKey(country))
            {
                location[continent][country] = new SortedSet<string>();
            }
            location[continent][country].Add(city);
        }
    }
}
