using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Randomize_Words
{
    class RandomizeWords
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine()
                .Split(' ')
                .ToArray();

            var random = new Random();

            for (int pos = 0; pos < words.Length; pos++)
            {
                var pos2 = random.Next(words.Length);
                var current = words[pos];
                words[pos] = words[pos2];
                words[pos2] = current;
            }
            Console.WriteLine(String.Join("\r\n", words));
        }
    }
}
