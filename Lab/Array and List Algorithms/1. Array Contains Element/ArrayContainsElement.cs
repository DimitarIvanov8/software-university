using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Array_Contains_Element
{
    class ArrayContainsElement
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var n = int.Parse(Console.ReadLine());

            var found = false;

            foreach (var num in numbers)
            {
                if (num == n)
                {
                    found = true;
                    Console.WriteLine("yes");
                    break;
                }
            }
            if (found == false)
            {
                Console.WriteLine("no");
            }
        }
    }
}
