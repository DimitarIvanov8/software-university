using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Batteries
{
    class Batteries
    {
        static void Main(string[] args)
        {
            var capacities = Console.ReadLine() .Split(' ') .Select(double.Parse) .ToArray();
            var usagePerHour = Console.ReadLine() .Split(' ') .Select(double.Parse) .ToArray();
            var hours = int.Parse(Console.ReadLine());

            var batteryStatus = new double[capacities.Length];
            var lastedHours = new double[capacities.Length];
            var batteryPercentage = new double[capacities.Length];

            for (int i = 0; i < capacities.Length; i++)
            {
                batteryStatus[i] = capacities[i] - usagePerHour[i] * hours;

                if (batteryStatus[i] <= 0)
                {
                    lastedHours[i] = Math.Ceiling(capacities[i] / usagePerHour[i]);
                }
                else
                {
                    batteryPercentage[i] = batteryStatus[i] / capacities[i] * 100;
                }
            }

            for (int i = 0; i < capacities.Length; i++)
            {
                if (batteryStatus[i] > 0)
                {
                    Console.WriteLine($"Battery {i + 1}: {batteryStatus[i]:F2} mAh ({batteryPercentage[i]:F2})%");
                }
                else
                {
                    Console.WriteLine($"Battery {i + 1}: dead (lasted {lastedHours[i]} hours)");
                }
            }
        }
    }
}
