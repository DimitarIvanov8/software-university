using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _3.Rage_Quit
{
    class RageQuit
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine();
            Regex regex = new Regex(@"(\D+)(\d+)");
            var matches = regex.Matches(inputLine);

            StringBuilder result = new StringBuilder();

            foreach (Match match in matches)
            {
                var partition = match.Groups[1].Value;
                int times = int.Parse(match.Groups[2].Value);

                result.Append(Repeat(partition, times).ToUpper());
            }

            int count = result.ToString().Distinct().Count();

            Console.WriteLine($"Unique symbols used: {count}");
            Console.WriteLine(string.Join("", result));
        }

        private static string Repeat(string partition, int times)
        {
            StringBuilder final = new StringBuilder();

            for (int i = 0; i < times; i++)
            {
                final.Append(partition);
            }

            return final.ToString();
        }
    }
}
