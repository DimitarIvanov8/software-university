﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Count_Symbols
{
    class CountSymbols
    {
        static void Main(string[] args)
        {
            // Write a program that reads some text from the console and counts the occurrences of each character in it. 
            // Print the results in alphabetical (lexicographical) order. 

            string input = Console.ReadLine();
            char[] symbols = input.ToCharArray();
            SortedDictionary<char, int> charDataBase = new SortedDictionary<char, int>();
            for (int i = 0; i < symbols.Length; i++)
            {
                char currentChar = symbols[i];

                if (!charDataBase.ContainsKey(currentChar))
                {
                    charDataBase.Add(currentChar, 0);
                }
                charDataBase[currentChar]++;
            }

            foreach (var kvp in charDataBase)
            {
                Console.WriteLine("{0}: {1} time/s", kvp.Key, kvp.Value);
            }
        }
    }
}
