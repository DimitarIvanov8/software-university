using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.String_Matrix_Rotation
{
    class StrMatrixRotation
    {
        static void Main(string[] args)
        {
            // initial database
            List<string> lines = new List<string>();

            // input
            string[] command = Console.ReadLine().Split(new char[] { '(', ')' }, StringSplitOptions.RemoveEmptyEntries);

            while (true)
            {
                string input = Console.ReadLine();

                if (input != "END")
                {
                    lines.Add(input);
                }
                else
                {
                    break;
                }
            }

            // converting input lines into a 2D matrix
            int firstDim = lines.Count;

            var sorted = from s in lines
                         orderby s.Length descending
                         select s;
            int secondDim = sorted.First().Length;

            char[,] matrix = To2D(lines, firstDim, secondDim);
            //PrintMatrix(matrix); // uncomment if you want to see how the initial matrix looks like

            // apply the rotation
            int degrees = int.Parse(command[1]);

            switch (degrees % 360)
            {
                case 0: PrintMatrix(matrix); break;
                case 90: Rotate90(matrix); break;
                case 180: Rotate180(matrix); break;
                case 270: Rotate270(matrix); break;
            }
        }

        static char[,] To2D(List<string> source, int N, int M)
        {

            var result = new char[N, M];
            for (int i = 0; i < N; ++i)
            {
                for (int j = 0; j < M; ++j)
                {
                    result[i, j] = source[i].PadRight(M, ' ')[j];
                }
            }
            return result;
        }

        private static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }

        private static void Rotate90(char[,] matrix)
        {
            for (int rows = 0; rows < matrix.GetLength(1); rows++)
            {
                for (int cols = matrix.GetLength(0) - 1; cols >= 0; cols--)
                {
                    Console.Write(matrix[cols, rows]);
                }
                Console.WriteLine();
            }
        }

        private static void Rotate180(char[,] matrix)
        {
            for (int rows = matrix.GetLength(0) - 1; rows >= 0; rows--)
            {
                for (int cols = matrix.GetLength(1) - 1; cols >= 0; cols--)
                {
                    Console.Write(matrix[rows, cols]);
                }
                Console.WriteLine();
            }
        }

        private static void Rotate270(char[,] matrix)
        {
            for (int rows = matrix.GetLength(1) - 1; rows >= 0; rows--)
            {
                for (int cols = 0; cols < matrix.GetLength(0); cols++)
                {
                    Console.Write(matrix[cols, rows]);
                }
                Console.WriteLine();
            }
        }
    }
}
