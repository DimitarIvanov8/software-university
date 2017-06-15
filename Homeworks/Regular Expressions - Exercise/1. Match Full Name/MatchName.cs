/*
Write a regular expression to match a valid full name.A valid full name consists of two words, 
each word starts with a capital letter and contains only lowercase letters afterwards; each 
word should be at least two letters long; the two words should be separated by a single space.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _1.Match_Full_Name
{
    class MatchName
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();

            var pattern = @"^[A-Z]{1}[a-z]+\s[A-Z][a-z]+";
            Regex regex = new Regex(pattern);

            while (text != "end")
            {
                Match matches = regex.Match(text);
                Console.WriteLine(matches.Value);

                text = Console.ReadLine();
            }
        }
    }
}
