using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Odd_Occurrences
{
    class OddOccurrences
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .ToLower()
                .Split(' ')
                .ToArray();

            var result = new Dictionary<string, int>();

            foreach (var item in numbers)
            {
                if (!result.ContainsKey(item))
                {
                    result[item] = 0;
                }
                result[item]++;
            }

            var oddNumbers = new List<string>();

            foreach (var kvp in result)
            {
                if (kvp.Value % 2 != 0)
                {
                    oddNumbers.Add(kvp.Key);
                }
            }
            Console.WriteLine(String.Join(", ", oddNumbers));
        }
    }
}
