using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _3.Series_Of_Letters
{
    class SeriesOfLetters
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Console.WriteLine(Filtertetxt(text));
        }

        private static string Filtertetxt(string text)
        {
            var result = text[0].ToString();

            for (int i = 0; i < text.Length - 1; i++)
            {
                var current = text[i].ToString();
                var next = text[i + 1].ToString();

                if (current == next)
                {
                    continue;
                }

                result += next;
            }

            return result;
        }
    }
}
