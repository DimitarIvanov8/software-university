/*
Write a program that takes a base-N number and converts it to a base-10 number
(0 to 1050), where 2 <= N <= 10.The input consists of 1 line containing two
numbers separated by a single space.The first number is the base N to which
you have to convert.The second one is the base N number to be converted.
Do not use any built in converting functionality, try to write your own algorithm.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _5.Convert_from_base_N_to_base_10
{
    class ConvertFromBaseToBase
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Trim().Split();
            int baseN = int.Parse(line[0]);
            char[] number = line[1].ToCharArray();
            BigInteger result = new BigInteger(0);
            for (int i = number.Length - 1, n = 0; i >= 0; i--, n++)
            {
                BigInteger num = new BigInteger(char.GetNumericValue(number[n]));
                BigInteger forSum = BigInteger.Multiply(num, BigInteger.Pow(new BigInteger(baseN), i));
                result += forSum;
            }
            Console.WriteLine(result.ToString());
        }
    }
}
