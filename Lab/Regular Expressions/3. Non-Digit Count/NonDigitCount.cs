/*
Find the count of all non-digit characters in a given text using regex.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _3.Non_Digit_Count
{
    class NonDigitCount
    {
        static void Main(string[] args)
        {
            Regex pattern = new Regex("[^0-9]");
            var inputText = Console.ReadLine();
            var nonDigitCharacters = pattern.Matches(inputText);
            Console.WriteLine($"Non-digits: {nonDigitCharacters.Count}");
        }
    }
}
