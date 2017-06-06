using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Maximal_Sum
{
    class MaxSum
    {
        static void Main(string[] args)
        {
            var input =
                Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var matrix = new int[input[0]][];

            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] =
                    Console.ReadLine()
                        .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToArray();
            }
            long maxSum = long.MinValue;
            var resultMatrix = new int[3][];

            for (int row = 0; row < matrix.Length; row++)
            {

                for (int col = 0; col < matrix[row].Length; col++)
                {
                    if (row + 2 < matrix.Length && col + 2 < matrix[row].Length)
                    {
                        long currentSum = 0;

                        currentSum = matrix[row][col] + matrix[row][col + 1] + matrix[row][col + 2]
                                     + matrix[row + 1][col] + matrix[row + 1][col + 1] + matrix[row + 1][col + 2]
                                     + matrix[row + 2][col] + matrix[row + 2][col + 1] + matrix[row + 2][col + 2];

                        if (currentSum > maxSum)
                        {
                            maxSum = currentSum;
                            resultMatrix[0] = new int[] { matrix[row][col], matrix[row][col + 1], matrix[row][col + 2] };
                            resultMatrix[1] = new int[] { matrix[row + 1][col], matrix[row + 1][col + 1], matrix[row + 1][col + 2] };
                            resultMatrix[2] = new int[] { matrix[row + 2][col], matrix[row + 2][col + 1], matrix[row + 2][col + 2] };
                        }
                    }
                }
            }
            Console.WriteLine($"Sum = {maxSum}");
            foreach (var line in resultMatrix)
            {
                Console.WriteLine(string.Join(" ", line));
            }
        }
    }
}
