using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Distance_of_the_Stars
{
    class DistanceOfTheStars
    {
        static void Main(string[] args)
        {
            decimal lightYearToKm = 9450000000000m;

            decimal earthToNearestStar = 4.22m;
            decimal toTheCenterOfMilkyWay = 26000; ;
            decimal diameterOfMilkyWay = 100000;
            decimal fromEarthToTheEdge = 46500000000;


            decimal earthToNearestStarInKm = earthToNearestStar * lightYearToKm;
            decimal toTheCenterOfMilkyWayInKm = toTheCenterOfMilkyWay * lightYearToKm;
            decimal diameterOfMilkyWayInKm = diameterOfMilkyWay * lightYearToKm;
            decimal fromEarthToTheEdgeInKm = fromEarthToTheEdge * lightYearToKm;

            Console.WriteLine(earthToNearestStarInKm.ToString("0.##e+000", CultureInfo.InvariantCulture));
            Console.WriteLine(toTheCenterOfMilkyWayInKm.ToString("0.##e+000", CultureInfo.InvariantCulture));
            Console.WriteLine(diameterOfMilkyWayInKm.ToString("0.##e+000", CultureInfo.InvariantCulture));
            Console.WriteLine(fromEarthToTheEdgeInKm.ToString("0.##e+000", CultureInfo.InvariantCulture));
        }
    }
}
