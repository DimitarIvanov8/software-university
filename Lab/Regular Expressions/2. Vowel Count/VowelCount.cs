/*
Find the count of all vowels in a given text using a regex.
The vowels that you should be looking for are upper and lower a, e, i, o, u and y.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _2.Vowel_Count
{
    class VowelCount
    {
        static void Main(string[] args)
        {
            Regex pattern = new Regex("[aeiouyAEIOUY]");
            var inputText = Console.ReadLine();
            var matchesCount = pattern.Matches(inputText).Count;
            Console.WriteLine($"Vowels: {matchesCount}");
        }
    }
}
