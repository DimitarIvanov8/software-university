using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Larger_Numbers_in_Array
{
    class LargerNumsInArr
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(Double.Parse)
                .ToArray();

            double p = double.Parse(Console.ReadLine());
            int elementsBiggerThanP = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > p)
                {
                    elementsBiggerThanP++;
                }
            }

            Console.WriteLine(elementsBiggerThanP);
        }
    }
}
