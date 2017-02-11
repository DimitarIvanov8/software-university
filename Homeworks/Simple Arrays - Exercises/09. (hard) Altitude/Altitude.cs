using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._hard__Altitude
{
    class Altitude
    {
        static void Main(string[] args)
        {
            var commands = Console.ReadLine()
                .Split(' ');

            double numberInitialAltitude = Int32.Parse(commands[0]);

            int altitude = 0;
            bool flyUp = false;
            bool flyDown = false;

            for (int i = 1; i < commands.Length; i++)
            {           
                if (commands[i].All(Char.IsDigit)) //get altitude value
                {
                    altitude = Int32.Parse(commands[i]);
                }
              
                if (flyUp == true) //altitude change UP
                {
                    numberInitialAltitude += altitude;
                    flyUp = false;
                }
                else if (flyDown == true) //altitude change Down
                {
                    numberInitialAltitude -= altitude;
                    flyDown = false;
                }

                if (numberInitialAltitude <= 0) //Check for crash
                {
                    Console.WriteLine("crashed");
                    return;
                }

                if (commands[i] == "up") //get altitude direction Up
                {
                    flyUp = true;
                }
                else if (commands[i] == "down") //get altitude direction Down
                {
                    flyDown = true;
                }
            }

            //print current altitude if there is no crash
            Console.WriteLine($"got through safely. current altitude: {numberInitialAltitude}m");
        }
    }
}
