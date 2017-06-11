using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Concatenate_Strings
{
/*
Write a program that read number N on first line.And on next N lines read single words
and concatenate them like single line text with " " separator after each word. 

Example input:
3
StringBuilder
is
awesome
*/
    class ConcatenateStrings
    {
        static void Main(string[] args)
        {
            var numberOfWords = int.Parse(Console.ReadLine());
            var text = new StringBuilder();

            for (int i = 0; i < numberOfWords; i++)
            {
                var currentWord = Console.ReadLine();
                text.Append(currentWord).Append(" ");
            }

            Console.WriteLine(text);
        }
    }
}
