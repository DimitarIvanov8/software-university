using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Exact_Product_of_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal currentNum;
            decimal total = 1m;
            for (int i = 0; i < n; i++)
            {
                currentNum = decimal.Parse(Console.ReadLine());
                total = total * currentNum;
            }
            Console.WriteLine(total);
        }
    }
}
