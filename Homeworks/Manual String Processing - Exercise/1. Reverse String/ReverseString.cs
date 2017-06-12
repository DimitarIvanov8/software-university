/*
Write a program that reads a string from the console, 
reverses it and prints the result back at the console.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Reverse_String
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            var inputText = Console.ReadLine();
            var reversedText = new StringBuilder();

            for (int i = inputText.Length - 1; i >= 0; i--)
            {
                reversedText.Append(inputText[i]);
            }
            Console.WriteLine(reversedText);
        }
    }
}
