using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Equal_Sequence_of_Elements_in_Array
{
    class EqualSequence
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            bool elementsAreEqual = false;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    elementsAreEqual = true;
                }
                else
                {
                    Console.WriteLine("No");
                    return;
                }
            }

            if (elementsAreEqual == true)
            {
                Console.WriteLine("Yes");
            }
        }
    }
}
