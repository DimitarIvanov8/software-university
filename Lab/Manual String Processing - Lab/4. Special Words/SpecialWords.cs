using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Special_Words
{
/*
Read a string containing a list of special words and a text containing some of these words.
Write a program count special words in text and print their count.
A word separator can be() [ ] < > , - ! ? and space(‘ ’)

Example input:
.NET Microsoft runs framework
.NET Framework (pronounced dot net) is a software framework developed by Microsoft that runs primarily on Microsoft Windows.

Output:
.NET – 1
Microsoft – 2
runs – 1
framework - 1
*/

    class SpecialWords
    {
        static void Main(string[] args)
        {
            var inputWords = Console.ReadLine().Split(new[] { ' ', '(', ')', '<', '>', '-', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            var inputText = Console.ReadLine().Split(new[] { ' ', '(', ')', '<', '>', '-', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            var specialWords = new Dictionary<string, int>();

            for (int i = 0; i < inputWords.Length; i++)
            {
                var currentWord = inputWords[i];
                specialWords[currentWord] = 0;
            }

            for (int i = 0; i < inputText.Length; i++)
            {
                var currentWord = inputText[i];
                if (specialWords.ContainsKey(currentWord))
                {
                    specialWords[currentWord]++;
                }
            }

            foreach (var kvp in specialWords)
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value}");
            }
        }
    }
}
