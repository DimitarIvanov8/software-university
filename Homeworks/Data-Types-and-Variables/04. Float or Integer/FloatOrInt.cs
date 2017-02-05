using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Float_or_Integer
{
    class FloatOrInt
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            if (n != Math.Floor(n))
            {
                //lose
                Console.WriteLine(Math.Round(n));
            }
            else if (n == Math.Floor(n))
            {
                //win
                Console.WriteLine(n);
            }
        }
    }
}
