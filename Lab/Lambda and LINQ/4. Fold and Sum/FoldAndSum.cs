using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Fold_and_Sum
{
    class FoldAndSum
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .ToArray();

            var k = numbers.Length / 4;
            var row1Left = numbers
                .Take(k)
                .Reverse()
                .ToArray();

            var row1Right = numbers
                .Reverse()
                .Take(k)
                .ToArray();

            var upperRow = row1Left
                .Concat(row1Right)
                .Select(int.Parse)
                .ToArray();

            var lowerRow = numbers
                .Skip(k)
                .Take(2 * k)
                .Select(int.Parse)
                .ToArray();

            var sum = new int[lowerRow.Length];
            for (int i = 0; i < upperRow.Length; i++)
            {
                sum[i] = upperRow[i] + lowerRow[i];
            }
            Console.WriteLine(String.Join(" ", sum));
        }
    }
}
