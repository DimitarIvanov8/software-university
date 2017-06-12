/*
Write a program that takes a base-10 number(0 to 1050) and converts it to a base-N number, where 2 <= N <= 10.
The input consists of 1 line containing two numbers separated by a single space.The first number is the base N
to which you have to convert.The second one is the base 10 number to be converted.Do not use any built in 
converting functionality, try to write your own algorithm
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _4.Convert_from_base_10_to_base_N
{
    class ConvertFromBase
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(BigInteger.Parse)
                .ToArray();

            var numberToConvert = input[1];
            var baseN = input[0];

            string conversion = string.Empty;

            while (numberToConvert != 0)
            {
                conversion += Convert.ToString(numberToConvert % baseN);
                numberToConvert = numberToConvert / baseN;
            }
            var conversionReverse = conversion.ToCharArray().Reverse();
            Console.WriteLine(string.Join("", conversionReverse));
        }
    }
}
