using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Nth_Digit
{
    class NthDigit
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int digit = int.Parse(Console.ReadLine());

            var numDigit = FindNthDigit(number, digit);
            Console.WriteLine(numDigit);
        }

        static int FindNthDigit(int number, int digit)
        {
            int numIndex = 1;
            int nDigit = 0;

            while (number != 0)
            {
                if (numIndex != digit)
                {
                    number = number / 10;
                    numIndex++;
                }
                else if (numIndex == digit)
                {
                    nDigit = number % 10;
                    break;
                }
            }

            return nDigit;
        }
    }
}
