using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Integer_Insertion
{
    class IntegerInsertion
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var currentNumber = "";
            var firstDigit = "";

            while (currentNumber != "end")
            {
                currentNumber = Console.ReadLine();

                if (currentNumber == "end")
                {
                    continue;
                }

                firstDigit = currentNumber[0].ToString();

                numbers.Insert(int.Parse(firstDigit), int.Parse(currentNumber));                
            }

            foreach (var item in numbers)
            {
                Console.Write(item + " ");
            }
        }
    }
}
