using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Maximum_sum_of_2x2_submatrix
{
    class MaxSumOfSubmatrix
    {
        static void Main(string[] args)
        {
            var matrixSizes = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.None).ToArray();

            int[][] matrix = new int[int.Parse(matrixSizes[0])][];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                matrix[row] = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.None).Select(int.Parse).ToArray();
            }

            var maxSquareRow = 0;
            var maxSqaureCol = 0;
            var maxSum = int.MinValue;

            for (int row = 0; row < matrix.Length - 1; row++)
            {
                for (int col = 0; col < matrix[row].Length - 1; col++)
                {
                    var currentSum = matrix[row][col] + matrix[row][col + 1] + 
                        matrix[row + 1][col] + matrix[row + 1][col + 1];

                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        maxSquareRow = row;
                        maxSqaureCol = col;
                    }
                }
            }

            Console.WriteLine($"{matrix[maxSquareRow][maxSqaureCol]} {matrix[maxSquareRow][maxSqaureCol + 1]}\n{matrix[maxSquareRow + 1][maxSqaureCol]} {matrix[maxSquareRow + 1][maxSqaureCol + 1]}");
            Console.WriteLine(maxSum);
        }
    }
}
