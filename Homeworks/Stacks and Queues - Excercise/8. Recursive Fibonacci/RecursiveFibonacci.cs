﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Recursive_Fibonacci
{
    class RecursiveFibonacci
    {
        private static long[] fibNumbers;

        static void Main(string[] args)
        {
            int nthNumber = int.Parse(Console.ReadLine());
            fibNumbers = new long[nthNumber];
            var result = GetFibonacci(nthNumber);
            Console.WriteLine(result);
        }

        private static long GetFibonacci(long nthNumber)
        {
            if (nthNumber <= 2)
            {
                return 1;
            }
            if (fibNumbers[nthNumber - 1] != 0)
            {
                return fibNumbers[nthNumber - 1];
            }
            return fibNumbers[nthNumber - 1] = GetFibonacci(nthNumber - 1) + GetFibonacci(nthNumber - 2);
        }
    }
}
