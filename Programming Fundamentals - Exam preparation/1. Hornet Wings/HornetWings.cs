using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Hornet_Wings
{
    class HornetWings
    {
        static void Main(string[] args)
        {
            //Distance after wingFlaps ?
            //For how much time ?

            var wingFlaps = long.Parse(Console.ReadLine());
            var distanceFor1000Flaps = double.Parse(Console.ReadLine());
            var endurance = long.Parse(Console.ReadLine());
            //endurance = how many flaps before stop for a break of 5 seconds
            //Hornet makes 100 wing flaps per second

            double distance = (wingFlaps / 1000L) * distanceFor1000Flaps;

            var movingTime = wingFlaps / 100;
            var seconds = (wingFlaps / endurance) * 5;
            var finalSecondsResult = movingTime + seconds;

            Console.WriteLine($"{distance:f2} m.");
            Console.WriteLine($"{finalSecondsResult} s.");
        }
    }
}
