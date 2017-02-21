using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Camel_s_Back
{
    class CamelsBack
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var camelBackSize = int.Parse(Console.ReadLine());

            if (numbers.Count == camelBackSize)
            {
                Console.Write("already stable: ");
                foreach (var item in numbers)
                {
                    Console.Write(item + " ");
                }
                return;
            }

            var oneSideDifference = (numbers.Count - camelBackSize) / 2;

            var rounds = 0;

            do
            {
                numbers.RemoveAt(numbers.Count - 1);
                numbers.RemoveAt(0);

                oneSideDifference--;
                rounds++;

            } while (oneSideDifference != 0);

            Console.WriteLine($"{rounds} rounds");
            Console.Write("remaining: ");

            foreach (var item in numbers)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
