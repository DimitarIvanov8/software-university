using System;
using System.Linq;

namespace _2._2_Knight_Game
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var nSide = long.Parse(Console.ReadLine());
            var chessBoard = new char[nSide][];
            var knightsBefore = 0L;
            var knightsAfter = 0L;

            for (int row = 0; row < nSide; row++)
            {
                chessBoard[row] = Console.ReadLine().ToCharArray();
                knightsBefore += chessBoard[row].Where(w => w == 'K').Count();
            }

            for (int row = 0; row < nSide; row++)
            {
                for (int col = 0; col < nSide; col++)
                {
                    long currentPosHits = 0;

                    if (chessBoard[row][col] == 'K')
                    {
                        currentPosHits = CurrentKNumberOfHits(chessBoard, row, col, currentPosHits, nSide);
                    }

                    if (currentPosHits > 1)
                    {
                        chessBoard[row][col] = '0';
                    }
                }
            }

            //Console.WriteLine("===========");
            //foreach (var item in chessBoard)
            //{
            //    Console.WriteLine(string.Join("", item));
            //}

            for (int row = 0; row < nSide; row++)
            {
                knightsAfter += chessBoard[row].Where(w => w == 'K').Count();
            }

            Console.WriteLine(knightsBefore - knightsAfter);
        }

        private static long CurrentKNumberOfHits(char[][] chessBoard, int row, int col, long currentPosHits, long nSide)
        {
            if (row >= 2 && col > 0)
            {
                if (chessBoard[row - 2][col - 1] == 'K')
                {
                    currentPosHits++;
                }
            }

            if (row >= 2 && col < nSide - 1)
            {
                if (chessBoard[row - 2][col + 1] == 'K')
                {
                    currentPosHits++;
                }
            }

            if (row > 0 && col < nSide - 2)
            {
                if (chessBoard[row - 1][col + 2] == 'K')
                {
                    currentPosHits++;
                }
            }

            if (row < nSide - 1 && col < nSide - 2)
            {
                if (chessBoard[row + 1][col + 2] == 'K')
                {
                    currentPosHits++;
                }
            }

            if (row < nSide - 2 && col < nSide - 1)
            {
                if (chessBoard[row + 2][col + 1] == 'K')
                {
                    currentPosHits++;
                }
            }

            if (row < nSide - 2 && col > 0)
            {
                if (chessBoard[row + 2][col - 1] == 'K')
                {
                    currentPosHits++;
                }
            }

            if (row < nSide - 1 && col >= 2)
            {
                if (chessBoard[row + 1][col - 2] == 'K')
                {
                    currentPosHits++;
                }
            }

            if (row > 0 && col >= 2)
            {
                if (chessBoard[row - 1][col - 2] == 'K')
                {
                    currentPosHits++;
                }
            }

            return currentPosHits;
        }
    }
}
