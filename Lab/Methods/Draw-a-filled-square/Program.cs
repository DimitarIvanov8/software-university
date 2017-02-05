using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw_a_filled_square
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PrintHeaderRow(n);
            PrintMiddleRow(n);
            PrintHeaderRow(n);
        }

        static void PrintMiddleRow(int n)
        {
            for (int i = 1; i <= n - 2; i++)
            {
                Console.Write("-");
                for (int j = 1; j <= n * 2 - 2; j++)
                {
                    if (j % 2 != 0)
                    {
                        Console.Write(new string('\\',1));
                    }
                    else
                    {
                        Console.Write(new string('/', 1));
                    }
                }
                Console.Write("-");
                Console.WriteLine();
            }
        }
        static void PrintHeaderRow(int n)
        {
            Console.WriteLine(new string('-', n * 2));
        }
    }
}
