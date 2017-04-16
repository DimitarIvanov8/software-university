using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Sino_The_Walker
{
    class SinoTheWalker
    {
        static void Main(string[] args)
        {
            TimeSpan span = TimeSpan.Parse(Console.ReadLine());
            
            //alternatively we can take the initial input like this:
            //var timeFormat = @"hh\:mm\:ss";
            //var span = TimeSpan.ParseExact(Console.Readline(), timeFormat, CultureInfo.InvariantCulture);

            var stepsCount = int.Parse(Console.ReadLine());
            var stepsPerSecond = int.Parse(Console.ReadLine());

            int secondsPerDay = 60 * 60 * 24;
            var totalSecondsNeeded = (int)(((double)stepsCount * stepsPerSecond) % secondsPerDay);

            TimeSpan traveledInSeconds = new TimeSpan(0, 0, totalSecondsNeeded);
            var timeArrival = span.Add(traveledInSeconds);

            Console.WriteLine("Time Arrival: {0:hh\\:mm\\:ss}", timeArrival);
        }
    }
}
