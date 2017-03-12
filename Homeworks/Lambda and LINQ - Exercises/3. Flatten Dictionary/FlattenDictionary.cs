using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Flatten_Dictionary
{
    class FlattenDictionary
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var registry = new Dictionary<string, Dictionary<string, string>>();
            var flatten = "";

            while (line[0] != "end")
            {
                if (line[0] == "flatten")
                {
                    flatten = line[1];
                    registry[flatten] = registry[flatten]
                        .ToDictionary(x => x.Key + x.Value, x => "flattened");
                }
                else
                {
                    var inputKey = line[0];
                    var innerKey = line[1];
                    var innerValue = line[2];

                    if (!registry.ContainsKey(inputKey))
                    {
                        registry.Add(inputKey, new Dictionary<string, string>());
                    }
                    registry[inputKey][innerKey] = innerValue;
                }

                line = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            }

            Dictionary<string, Dictionary<string, string>> orderedRegistry = registry
                .OrderByDescending(x => x.Key.Length)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var entry in orderedRegistry)
            {
                Console.WriteLine($"{entry.Key}");

                Dictionary <string, string> orderedInnerDictionary =
                    entry.Value
                        .Where(x => x.Value != "flattened")
                        .OrderBy(x => x.Key.Length)
                        .ToDictionary(x => x.Key, x => x.Value);

                Dictionary<string, string> flattenedValues =
                    entry.Value
                        .Where(x => x.Value == "flattened")
                        .ToDictionary(x => x.Key, x => x.Value);

                int count = 1;
                foreach (var innerEntry in orderedInnerDictionary)
                {
                    if (innerEntry.Value != "flattened")
                    {
                        Console.WriteLine("{0}. {1} - {2}", count, innerEntry.Key, innerEntry.Value);
                        count++;
                    }
                }

                foreach (var flattenedEntry in flattenedValues)
                {
                    Console.WriteLine("{0}. {1}", count, flattenedEntry.Key);
                    count++;
                }
            }
        }
    }
}
