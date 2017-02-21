using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._hard__Stuck_Zipper
{
    class StuckZipper
    {
        static void Main(string[] args)
        {
            var firstList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var secondList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            secondList.Min();
        }
    }
}
