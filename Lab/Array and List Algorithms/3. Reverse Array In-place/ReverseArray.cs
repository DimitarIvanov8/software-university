using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Reverse_Array_In_place
{
    class ReverseArray
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < numbers.Length / 2; i++)
            {
                var leftSide = i;
                var rightSide = numbers.Length - 1 - i;

                var temp = numbers[leftSide];

                numbers[leftSide] = numbers[rightSide];
                numbers[rightSide] = temp;
            }

            foreach (var num in numbers)
            {
                Console.Write(num + " ");
            }
        }
    }
}
