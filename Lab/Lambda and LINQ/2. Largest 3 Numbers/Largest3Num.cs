using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Largest_3_Numbers
{
    class Largest3Num
    {
        static void Main(string[] args)
        {
            var number = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .OrderByDescending(x => x)
                .Take(3)
                .ToList();

            Console.WriteLine(String.Join(" ", number));
        }
    }
}
