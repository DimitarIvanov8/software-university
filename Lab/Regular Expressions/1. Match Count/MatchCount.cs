/*
Find the count of occurrences of a word in a given text using regex.
The word to search for is given on the first line.
The text to search in is given on the second line.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _1.Match_Count
{
    class MatchCount
    {
        static void Main(string[] args)
        {
            var pattern = Console.ReadLine();
            var inputText = Console.ReadLine();

            Regex regex = new Regex(pattern);
            var matchCounter = regex.Matches(inputText).Count;
            Console.WriteLine(matchCounter);
        }
    }
}
