using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Dict_Ref_Advanced
{
    class DicRefAdvanced
    {
        static void Main(string[] args)
        {
            var namesAndDigits = new Dictionary<string, List<int>>();
            var line = Console.ReadLine();
            var numbers = new List<string>();

            while (line != "end")
            {
                var tokens = line.Split(' ',',');
                var name = tokens[0];

                if (tokens[2].Length == 1)
                {
                    for (int i = 2; i < tokens.Count(); i+=2)
                    {
                        if (tokens[i] != ",")
                        {
                            numbers.Add(tokens[i]);
                        }
                    }
                }
                
                if (!namesAndDigits.ContainsKey(name))
                {
                    namesAndDigits[name] = new List<int>();
                }
                if (tokens[2].Length < 3) //3?!
                {
                    for (int j = 0; j < numbers.Count; j++)
                    {
                        if (j != ' ')
                        {
                            namesAndDigits[name].Add(int.Parse(numbers[j]));
                        }
                    }
                }
                else if (tokens[2].Length > 2)
                {
                    var currentName = tokens[2];
                    if (namesAndDigits.ContainsKey(currentName))
                    {
                        namesAndDigits[name] = new List<int>(namesAndDigits[currentName]);
                    }
                }

                numbers.Clear();
                line = Console.ReadLine();
            }

            foreach (var nameAndNum in namesAndDigits)
            {
                var name = nameAndNum.Key;
                var digit = nameAndNum.Value;
                var endDigit = String.Join(", ", digit);

                if (endDigit != String.Empty)
                {
                    Console.WriteLine($"{name} === {endDigit}");
                }
            }
        }
    }
}
