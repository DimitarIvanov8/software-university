using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Mixed_Phones
{
    class MixedPhones
    {
        static void Main(string[] args)
        {
            var phoneBook = new SortedDictionary<string, long>();
            var input = new List<string>();

            while (!input.Contains("Over"))
            {
                var number = 0l;
                input = Console.ReadLine().Split(' ').ToList();
                if (input.Contains("Over"))
                {
                    continue;
                }
                bool parsed = long.TryParse(input[2], out number);
                if (parsed == true)
                {
                    phoneBook[input[0]] = long.Parse(input[2]);
                }
                else
                {
                    number = long.Parse(input[0]);
                    phoneBook[input[2]] = number;
                }
            }
            foreach (var kvp in phoneBook)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
