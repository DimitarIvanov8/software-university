using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Smallest_Element_in_Array
{
    class SmallestElementInArray
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(
                new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int smallestNum = int.MaxValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < smallestNum)
                {
                    smallestNum = numbers[i];
                }
            }

            Console.WriteLine(smallestNum);
        }
    }
}
