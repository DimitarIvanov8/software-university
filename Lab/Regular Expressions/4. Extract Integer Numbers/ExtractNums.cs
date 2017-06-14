/*
Extract all integer numbers from a given text using regex.
Ignore number signs or decimal separators (See the examples below).
If there are no numbers, don't print anything.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _4.Extract_Integer_Numbers
{
    class ExtractNums
    {
        static void Main(string[] args)
        {
            Regex pattern = new Regex("\\d+");
            var inputText = Console.ReadLine();
            var matches = pattern.Matches(inputText);

            foreach (Match match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}
