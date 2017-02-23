using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Smallest_Element_in_Array
{
    class SmallestElementInArray
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var smallest = int.MaxValue;

            foreach (var num in numbers)
            {
                if (num < smallest)
                {
                    smallest = num;
                }
            }
            Console.WriteLine(smallest);
        }
    }
}
