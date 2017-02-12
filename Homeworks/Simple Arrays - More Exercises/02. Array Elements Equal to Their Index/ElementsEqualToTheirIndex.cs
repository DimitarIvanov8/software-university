using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Array_Elements_Equal_to_Their_Index
{
    class ElementsEqualToTheirIndex
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int indexCounter = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (indexCounter == numbers[i])
                {
                    Console.Write($"{numbers[i]} ");
                }

                indexCounter++;
            }

        }
    }
}
