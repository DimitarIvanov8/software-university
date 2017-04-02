using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Placeholders
{
    class Placeholders
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();

            while (line != "end")
            {
                var tokens = line.Split(new[] {'-', '>'},StringSplitOptions.RemoveEmptyEntries);

                var sentence = tokens[0].Trim();
                var placeholders = new List<string>(tokens[1].Trim().Split(new[] { ' ', ',' },StringSplitOptions.RemoveEmptyEntries));

                for (int i = 0; i < placeholders.Count(); i++)
                {
                    if (sentence.Contains($"{{{i}}}"))
                    {
                        sentence = sentence.Replace($"{{{i}}}", $"{placeholders[i]}");
                    }
                }
                Console.WriteLine(sentence);

                line = Console.ReadLine();
            }
        }
    }
}
