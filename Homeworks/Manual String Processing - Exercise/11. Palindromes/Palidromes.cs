/*
Write a program that extracts from a given text all palindromes, e.g.ABBA, lamal, 
exe and prints them on the console on a single line, separated by comma and space.
Use spaces, commas, dots, question marks and exclamation marks as word delimiters.
Print only unique palindromes, sorted lexicographically (small letters are before
big ones).
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.Palindromes
{
    class Palidromes
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine()
                .Split(new[] { ' ', ',', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var palyndromes = new SortedSet<string>();

            foreach (string word in words)
            {
                if (IsPalyndrome(word))
                {
                    palyndromes.Add(word);
                }
            }
            Console.WriteLine("[" + string.Join(", ", palyndromes) + "]");
        }

        private static bool IsPalyndrome(string word)
        {
            if (word.Length == 1)
            {
                return true;
            }

            var wordLength = word.Length;
            for (int i = 0; i < wordLength / 2; i++)
            {
                if (word[i] != word[wordLength - i - 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
