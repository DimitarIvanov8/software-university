/*
Write a program that reads from the console a string of maximum 20 characters.If the length of the string 
is less than 20, the rest of the characters should be filled with*. Print the resulting string on the console.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.String_Length
{
    class StringLength
    {
        static void Main(string[] args)
        {
            var inputText = Console.ReadLine();
            var textLength = inputText.Length;

            if (textLength >= 20)
            {
                Console.WriteLine(string.Join("", inputText.Take(20).ToArray()));
            }
            else
            {
                var symbolsToBeAdded = 20 - textLength;
                Console.WriteLine(inputText + new string('*', symbolsToBeAdded));
            }
        }
    }
}
