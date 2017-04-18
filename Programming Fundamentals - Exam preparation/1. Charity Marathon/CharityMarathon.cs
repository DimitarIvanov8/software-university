using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Charity_Marathon
{
    class CharityMarathon
    {
        static void Main(string[] args)
        {
            var marathonDays = int.Parse(Console.ReadLine());
            var numOfRunners = long.Parse(Console.ReadLine());
            var averageLapsByRunner = int.Parse(Console.ReadLine());
            var trackLength = long.Parse(Console.ReadLine());
            var trackCapacity = int.Parse(Console.ReadLine());
            var moneyDonatedPerKm = double.Parse(Console.ReadLine());

            var overallCapacity = marathonDays * trackCapacity;
            numOfRunners = Math.Min(overallCapacity, numOfRunners);

            long distanceInKM = (numOfRunners * averageLapsByRunner * trackLength) / 1000;
            double totalMoneyDonated = distanceInKM * moneyDonatedPerKm;

            Console.WriteLine($"Money raised: {totalMoneyDonated:F2}");
        }
    }
}
