using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Sort_Array_Using_Bubble_Sort
{
    class SortUsingBubbleSort
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            bool swap;

            do
            {
                swap = false;

                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    if (numbers[i] > numbers[i + 1])
                    {
                        var temp = numbers[i + 1];
                        numbers[i + 1] = numbers[i];
                        numbers[i] = temp;
                        swap = true;                        
                    }
                }
            } while (swap == true);

            foreach (var num in numbers)
            {
                Console.Write(num + " ");
            }
        }
    }
}
