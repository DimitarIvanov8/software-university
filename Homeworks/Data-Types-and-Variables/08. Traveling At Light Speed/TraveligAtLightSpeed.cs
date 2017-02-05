using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Traveling_At_Light_Speed
{
    class TraveligAtLightSpeed
    {
        static void Main(string[] args)
        {
            decimal lightYears = decimal.Parse(Console.ReadLine());

            decimal lightYearToKm = lightYears * 9450000000000;
            decimal kmPerSeconds = lightYearToKm / 300000;

            //weeks
            decimal weeks = (((kmPerSeconds / 60) / 60) / 24) / 7;
            decimal weeksResidue = weeks % 1; //ostatuk

            //days
            decimal days = weeksResidue * 7;
            decimal dayResidue = days % 1;

            //hours
            decimal hours = dayResidue * 24;
            decimal hoursResidue = hours % 1;

            //minutes
            decimal minutes = hoursResidue * 60;
            decimal minutesResidue = minutes % 1;

            //seconds
            decimal seconds = minutesResidue * 60;
            decimal secondResidue = seconds % 1;

            Console.WriteLine($"{Math.Floor(weeks)} weeks\n{Math.Floor(days)} days\n{Math.Floor(hours)} hours\n{Math.Round(minutes)} minutes\n{Math.Floor(seconds)} seconds");
        }
    }
}
