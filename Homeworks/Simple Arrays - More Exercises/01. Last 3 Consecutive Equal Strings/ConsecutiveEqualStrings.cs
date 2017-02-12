using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Last_3_Consecutive_Equal_Strings
{
    class ConsecutiveEqualStrings
    {
        static void Main(string[] args)
        {
            var randomStrings = Console.ReadLine()
                .Split(' ');

            string consequtiveWord = "";

            for (int i = 1; i < randomStrings.Length - 1; i++)
            {
                if (randomStrings[i] == randomStrings[i - 1] && randomStrings[i] == randomStrings[i + 1])
                { 
                    consequtiveWord = randomStrings[i];
                }

            }

            Console.WriteLine($"{consequtiveWord} {consequtiveWord} {consequtiveWord}");
        }
    }
}
