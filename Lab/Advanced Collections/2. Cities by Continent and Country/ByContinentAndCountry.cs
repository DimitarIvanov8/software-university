using System;
using System.Collections.Generic;
using System.Linq;

class ByContinentAndCountry
{
    static void Main()
    {
        var simpleGeography = new Dictionary<string, Dictionary<string, List<string>>>();
        var n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var line = Console.ReadLine().Split(' ');
            var continent = line[0];
            var country = line[1];
            var city = line[2];

            AddLocationss(simpleGeography, continent, country, city);
        }

        foreach (var continents in simpleGeography.Keys)
        {
            Console.WriteLine(continents + ":");
            var inContinents = simpleGeography[continents];
            foreach (var country in inContinents.Keys)
            {
                var towns = inContinents[country];
                Console.WriteLine("  {0} -> {1}", country,
                    String.Join(", ",towns));
            }
        }
    }

    private static void AddLocationss(Dictionary<string, Dictionary<string, List<string>>> 
        simpleGeography, string continent, string country, string city)
    {
        if (!simpleGeography.ContainsKey(continent))
        {
            simpleGeography[continent] = new Dictionary<string, List<string>>();
        }
        if (!simpleGeography[continent].ContainsKey(country))
        {
            simpleGeography[continent][country] = new List<string>(); 
        }
        simpleGeography[continent][country].Add(city);
    }
}

