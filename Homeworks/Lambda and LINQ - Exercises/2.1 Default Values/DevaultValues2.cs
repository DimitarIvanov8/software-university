using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1_Default_Values
{
    class DevaultValues2
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

            registry                                //keys that have values
                .Where(x => x.Value != "null")
                .OrderByDescending(x => x.Value.Length)
                .ToList()
                .ForEach(x => Console.WriteLine("{0} <-> {1}",x.Key, x.Value));

            registry                                //keys without values
                .Where(x => x.Value == "null")
                .ToDictionary(x => x.Key, x => defaultValue)
                .Select(x => x.Key + " <-> " + x.Value)
                .ToList()
                .ForEach(Console.WriteLine);            
        }
    }
}
