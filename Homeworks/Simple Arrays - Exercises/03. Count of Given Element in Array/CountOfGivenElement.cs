using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Count_of_Given_Element_in_Array
{
    class CountOfGivenElement
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int givenElement = int.Parse(Console.ReadLine());
            int repeatedElement = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == givenElement)
                {
                    repeatedElement++;
                }
            }

            Console.WriteLine(repeatedElement);
        }
    }
}
