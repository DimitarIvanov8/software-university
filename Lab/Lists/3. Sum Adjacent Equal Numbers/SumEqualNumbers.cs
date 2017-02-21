using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Sum_Adjacent_Equal_Numbers
{
    class SumEqualNumbers
    {
        static void Main(string[] args)
        {
            var numbers = "3 3 6 1"//Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var adjacentElement = 0;

            for (int num = 0; num < numbers.Count; num++)
            {
                if (numbers[0] == numbers[1])
                {
                    adjacentElement = numbers[num];
                    numbers.Remove(adjacentElement);
                    numbers[num] = adjacentElement * 2;
                    adjacentElement = 0;
                }
                else if (numbers[num] == numbers[num + 1])
                {
                    //numbers[num + 1] = numbers[num] * 2;
                    //numbers.RemoveAt(numbers[num]);

                    adjacentElement = numbers[num];
                    numbers.Remove(adjacentElement);
                    numbers[num] = adjacentElement * 2;
                    adjacentElement = 0;
                }
            }

            foreach (var item in numbers)
            {
                Console.Write(item + " ");
            }
        }
    }
}
