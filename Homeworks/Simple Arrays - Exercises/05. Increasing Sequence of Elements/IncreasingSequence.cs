using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Increasing_Sequence_of_Elements
{
    class IncreasingSequence
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            bool isSequence = false;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > numbers[i - 1])
                {
                    isSequence = true;
                }
                else
                {
                    Console.WriteLine("No");
                    return;
                }
            }

            if (isSequence == true)
            {
                Console.WriteLine("Yes");
            }
        }
    }
}
