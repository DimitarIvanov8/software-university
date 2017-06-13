/*
Write a program that converts a string to a sequence 
of Unicode character literals

Example input:
What?!?

Output:
\u0057\u0068\u0061\u0074\u003f\u0021\u003f
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Unicode_Characters
{
    class UnicodeChars
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            foreach (var chr in input)
            {
                Console.Write("\\u{0:x4}", (int)chr);
            }
            Console.WriteLine();
        }
    }
}
