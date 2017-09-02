using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Cubic_s_Rube
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var cubeDimensions = long.Parse(Console.ReadLine());
            var cube = new long[cubeDimensions, cubeDimensions, cubeDimensions];
            var unchangedCells = 0l;
            var cellsSum = 0l;

            var line = Console.ReadLine();

            while (line != "Analyze")
            {
                var inputParams = line.Split(' ').Select(long.Parse).ToArray();
                long currentRow = inputParams[0];
                long currentCol = inputParams[1];
                long currentDepth = inputParams[2];
                long currentBomb = inputParams[3];

                if ((currentRow >= 0 && currentRow < cubeDimensions) &&
                    (currentCol >= 0 && currentCol < cubeDimensions) &&
                    (currentDepth >= 0 && currentDepth < cubeDimensions))
                {
                    cube[currentRow, currentCol, currentDepth] = currentBomb;
                }

                line = Console.ReadLine();
            }

            for (int row = 0; row < cube.GetLength(0); row++)
            {
                for (int col = 0; col < cube.GetLength(1); col++)
                {
                    for (int depth = 0; depth < cube.GetLength(2); depth++)
                    {
                        if (cube[row, col, depth] == 0)
                        {
                            unchangedCells++;
                        }

                        cellsSum += cube[row, col, depth];
                    }
                }
            }

            Console.WriteLine(cellsSum);
            Console.WriteLine(unchangedCells);
        }
    }
}
