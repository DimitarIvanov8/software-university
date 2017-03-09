using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Shellbound
{
    class Spellbound
    {
        static void Main(string[] args)
        {
            var shellsAndLocation = new Dictionary<string, HashSet<int>>();
            var line = Console.ReadLine();

            while (line != "Aggregate")
            {
                var tokens = line.Split(' ');
                var region = tokens[0].ToString();
                int shells = int.Parse(tokens[1]);

                if (!shellsAndLocation.ContainsKey(region))
                {
                    shellsAndLocation[region] = new HashSet<int>();
                }
                shellsAndLocation[region].Add(shells);

                line = Console.ReadLine();
            }

            foreach (var locationShells in shellsAndLocation)
            {
                var countZ = locationShells.Value;
                var giantShell = countZ.Sum() - countZ.Sum() / countZ.Count();
                Console.WriteLine($"{locationShells.Key} -> {String.Join(", ", countZ)} ({giantShell})");
            }
        }
    }
}
