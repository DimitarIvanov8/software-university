using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Multiply_an_Array_of_Doubles
{
    class MultiplyArrayOfDoubles
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            double p = double.Parse(Console.ReadLine());

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i] * p} ");
            }
        }
    }
}
