using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_power
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = double.Parse(Console.ReadLine());
            var power = int.Parse(Console.ReadLine());

            var numberRisedToPower = RaiseToPower(number, power);

            Console.WriteLine(numberRisedToPower);
        }

        static double RaiseToPower(double number, int power)
        {
            var result = 1d;

            for (int i = 0; i < power; i++)
            {
                result *= number;
            }

            return result;
        }
    }
}
