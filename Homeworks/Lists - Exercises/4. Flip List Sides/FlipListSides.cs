using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Flip_List_Sides
{
    class FlipListSides
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var firstNum = numbers[0];
            var lastNum = numbers[numbers.Count-1];

            numbers.Reverse();

            numbers[0] = firstNum;
            numbers[numbers.Count - 1] = lastNum;

            foreach (var num in numbers)
            {
                Console.Write(num + " ");
            }
        }
    }
}
