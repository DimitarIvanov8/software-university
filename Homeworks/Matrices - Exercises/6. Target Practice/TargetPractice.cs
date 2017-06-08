using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Target_Practice
{
    class TargetPractice
    {
        static void Main(string[] args)
        {
            var input =
                Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var rows = input[0];
            var cols = input[1];
            var snakeString = Console.ReadLine();
            var ladder = new char[rows][];
            var counter = 1;
            var currentIndex = 0;

            for (int rowIndex = ladder.Length - 1; rowIndex >= 0; rowIndex--)
            {
                ladder[rowIndex] = new char[cols];

                var snakeLength = snakeString.Length - 1;


                if (counter % 2 != 0)
                {
                    for (int colIndex = ladder[rowIndex].Length - 1; colIndex >= 0; colIndex--)
                    {
                        ladder[rowIndex][colIndex] = snakeString[currentIndex];

                        if (currentIndex == snakeLength)
                        {
                            currentIndex = 0;
                        }
                        else
                        {
                            currentIndex++;
                        }
                    }
                }
                else
                {
                    for (int colIndex = 0; colIndex < ladder[rowIndex].Length; colIndex++)
                    {
                        ladder[rowIndex][colIndex] = snakeString[currentIndex];


                        if (currentIndex == snakeLength)
                        {
                            currentIndex = 0;
                        }
                        else
                        {
                            currentIndex++;
                        }
                    }
                }

                counter++;
            }

            var shot = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var targetedRow = shot[0];
            var targetedCol = shot[1];
            var targetedElement = ladder[targetedRow][targetedCol];
            var radius = shot[2];

            ladder[targetedRow][targetedCol] = ' ';
            var count = radius;
            for (int row = 0; row <= radius; row++)
            {

                for (int col = 0; col <= count; col++)
                {
                    if (targetedCol + col < ladder[row].Length)
                    {
                        if (targetedRow + row < ladder.Length)
                        {
                            ladder[targetedRow + row][targetedCol + col] = ' ';
                        }
                        if (targetedRow - row >= 0)
                        {
                            ladder[targetedRow - row][targetedCol + col] = ' ';
                        }

                    }
                    if (targetedCol - col > 0)
                    {
                        if (targetedRow + row < ladder.Length)
                        {
                            ladder[targetedRow + row][targetedCol - col] = ' ';
                        }
                        if (targetedRow - row >= 0)
                        {
                            ladder[targetedRow - row][targetedCol - col] = ' ';
                        }

                    }

                }

                count--;

            }

            for (int row = 0; row < ladder.Length - 1; row++)
            {
                for (int col = 0; col < ladder[row].Length; col++)
                {
                    if (ladder[row + 1][col] == ' ' && ladder[row][col] != ' ')
                    {
                        var current = ladder[row][col];
                        var onNextRow = ladder[row + 1][col];

                        for (int i = row; i >= 0; i--)
                        {
                            var temp = ladder[i + 1][col];
                            ladder[i + 1][col] = ladder[i][col];
                            ladder[i][col] = temp;
                        }

                    }
                }
            }

            foreach (var row in ladder)
            {
                Console.WriteLine(string.Join("", row));
            }
        }
    }
}
