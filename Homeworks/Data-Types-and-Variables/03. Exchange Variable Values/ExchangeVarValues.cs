using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Exchange_Variable_Values
{
    class ExchangeVarValues
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine()); ;
            int b = int.Parse(Console.ReadLine()); ;
            int c = a;
            //Console.WriteLine($"{a}\n{b}");
            a = b;
            b = c;
            Console.WriteLine($"{a}\n{b}");
        }
    }
}
