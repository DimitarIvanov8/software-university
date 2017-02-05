using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Get_Multiplier_of_digits
{
    class MultiplierOfDigits
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            var result = GetMultipleOfDigits(num);
            Console.WriteLine(result);
        }

        static int GetMultipleOfDigits(int num)
        {
            int sumEvens = GetSumOfEvensDigits(num);
            int sumOdds = GetSumOfOddsDigits(num);

            return sumEvens * sumOdds;
        }

        static int GetSumOfEvensDigits(int num)
        {
            int sum = 0;
            while (Math.Abs(num) > 0)
            {
                int lastDigit = num % 10;
                if (lastDigit % 2 == 0)
                {
                    sum += lastDigit;
                }
                num /= 10;
            }
            return sum;
        }

        static int GetSumOfOddsDigits(int num)
        {
            int sum = 0;
            while (Math.Abs(num) > 0)
            {
                int lastDigit = num % 10;
                if (lastDigit % 2 != 0)
                {
                    sum += lastDigit;
                }
                num /= 10;
            }
            return sum;
        }
    }
}
