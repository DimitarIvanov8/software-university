using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Default_Values
{
    class DefaultValues
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine()
                .Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var registry = new Dictionary<string, string>();

            while (line[0] != "end")
            {
                var inputKey = line[0];
                var inputValue = line[1];
                registry[inputKey] = inputValue;

                line = Console.ReadLine()
                .Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            }
            var defaultValue = Console.ReadLine();

            var sortedRegistry = registry //keys that have values
                .Where(x => x.Value != "null")
                .OrderByDescending(x => x.Value.Length)
                .ToDictionary(x => x.Key, x => x.Value);

            registry = registry //keys without values
                .Where(x => x.Value == "null")
                .ToDictionary(x => x.Key, x => defaultValue);
            
            foreach (var item in registry)
            {
                if (!sortedRegistry.ContainsKey(item.Key))
                {
                    sortedRegistry[item.Key] = defaultValue;
                }
            }

            foreach (var item in sortedRegistry)
            {
                Console.WriteLine($"{item.Key} <-> {item.Value}");;
            }
        }
    }
}
