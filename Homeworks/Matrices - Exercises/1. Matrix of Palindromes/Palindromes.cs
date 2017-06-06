using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Matrix_of_Palindromes
{
    class Palindromes
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int matrixRow = list[0];
            int matrixCol = list[1];
            string[,] matrix = new string[matrixRow, matrixCol];
            for (int row = 0; row < matrixRow; row++)
            {
                for (int col = 0; col < matrixCol; col++)
                {
                    matrix[row, col] = "" + (char)('a' + row) + (char)('a' + row + col) + (char)('a' + row);

                }
            }
            for (int row = 0; row < matrixRow; row++)
            {
                for (int col = 0; col < matrixCol; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
