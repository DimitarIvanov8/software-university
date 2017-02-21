using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Distinct_List
{
    class DistingList
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int currentNum = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                currentNum = numbers[i];

                for (int j = i + 1; j < numbers.Count; j++)
                {
                    if (currentNum == numbers[j])
                    {
                        numbers.RemoveAt(j);
                        j--;
                    }
                }
            }

            foreach (var item in numbers)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
