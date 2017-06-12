//int count = text.Select((c, i) => text.Substring(i)).Count(x => x.StartsWith(subString, StringComparison.CurrentCultureIgnoreCase));
//Console.WriteLine(count);

/*
Write a program to find how many times a given string appears in a given text as substring.
The text is given at the first input line.The search string is given at the second input
line. The output is an integer number.Please ignore the character casing.Overlapping
between occurrences is allowed.
*/

using System;
using System.Linq;

namespace _6.Count_Substring_Occurrences
{
    class CountSubstring
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            string pattern = Console.ReadLine();
            var index = inputString.IndexOf(pattern, StringComparison.OrdinalIgnoreCase);
            var counter = 0;

            while (index != -1)
            {
                counter++;
                index = inputString.IndexOf(pattern, index + 1, StringComparison.OrdinalIgnoreCase);
            }

            Console.WriteLine(counter);
        }
    } 
}
