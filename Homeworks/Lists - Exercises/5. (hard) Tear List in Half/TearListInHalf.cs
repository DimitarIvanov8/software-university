using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._hard__Tear_List_in_Half
{
    class TearListInHalf
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var secondList = new List<int>(3 * (numbers.Count));

            int secondHalf = numbers.Count / 2;
            int firstDigt = 0;
            var secondDigit = 0;
            int counter = 0;

            for (int i = secondHalf; i < numbers.Count; i++)
            {
                firstDigt = numbers[i] / 10;
                secondDigit = numbers[i] % 10;

                secondList.Add(firstDigt);
                secondList.Add(numbers[counter]);
                secondList.Add(secondDigit);
                counter++;
            }

            foreach (var item in secondList)
            {
                Console.Write(item + " ");
            }
        }
    }
}
