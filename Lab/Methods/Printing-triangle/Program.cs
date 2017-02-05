using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printing_triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            UpperBody(n);
            PrintLine(n);
            LowerBody(n);
        }

        private static void LowerBody(int n)
        {
            for (int i = n - 1; i > 0; i--)
            {
                PrintLine(i);
            }
        }

        private static void UpperBody(int n)
        {
            for (int i = 1; i < n; i++)
            {
                PrintLine(i);
            }
        }

        static void PrintLine(int end, int start = 1)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
