using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Remove_Negatives_and_Reverse
{
    class RemoveNegatives
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var positiveNumbers = new List<int>();

            int emptyCount = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > 0)
                {
                    positiveNumbers.Add(numbers[i]);
                }
                else
                {
                    emptyCount++;
                }
            }

            positiveNumbers.Reverse();

            if (emptyCount != numbers.Count)
            {
                foreach (var num in positiveNumbers)
                {
                    Console.Write($"{num} ");
                }
            }
            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}
