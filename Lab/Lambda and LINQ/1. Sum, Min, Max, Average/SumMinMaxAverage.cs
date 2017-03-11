using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Sum__Min__Max__Average
{
    class SumMinMaxAverage
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var numbers = new List<int>();

            for (int i = 0; i < n; i++)
            {
                var line = int.Parse(Console.ReadLine());
                numbers.Add(line);
            }

            var sum = numbers.Sum();
            var min = numbers.Min();
            var max = numbers.Max();
            var average = numbers.Average();

            Console.WriteLine($"Sum = {sum}\nMin = {min}\nMax = {max}\nAverage = {average}");
        }
    }
}
