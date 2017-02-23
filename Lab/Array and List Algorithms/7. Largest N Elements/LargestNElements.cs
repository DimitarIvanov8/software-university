using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Largest_N_Elements
{
    class LargestNElements
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int totalNumbers = int.Parse(Console.ReadLine());

            numbers.Sort();
            numbers.Reverse();

            List<int> result = numbers.Take(totalNumbers).ToList();

            Console.WriteLine(string.Join(" ", result));

        }
    }
}
