using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Population_Counter
{
    class PopulationCounter
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> populations = new Dictionary<string, Dictionary<string, long>>();

            string city = "";
            string country = "";
            long population = 0;
            while (true)
            {
                var data = Console.ReadLine().Split('|').ToList();
                city = data[0];

                if (city == "report") 
                {
                    break;
                }
                else
	            {
                    country = data[1];
                }

                population = long.Parse(data[2]);
                Dictionary<string, long> cityPopulation = new Dictionary<string, long>();

                if (!populations.ContainsKey(country))
                {
                    cityPopulation[city] = population;
                    populations[country] = cityPopulation;
                }
                else
                {
                    cityPopulation = populations[country];

                    if (cityPopulation.ContainsKey(city))
                    {
                        cityPopulation[city] += population;
                    }
                    else
                    {
                        cityPopulation.Add(city, population);
                    }

                    populations[country] = cityPopulation;
                }
            }

            foreach (var state in populations.OrderByDescending(x => x.Value.Sum(y => y.Value)))
            {
                var sumOfTowns = state.Value.Select(x => x.Value).ToList();
                Console.WriteLine($"{state.Key} (total population: {sumOfTowns.Sum()})");

                Console.Write($"=>{string.Join("=>", state.Value.OrderByDescending(x => x.Value).Select(x => $"{x.Key}: {x.Value}\r\n"))}");
            }
        }
    }
}
