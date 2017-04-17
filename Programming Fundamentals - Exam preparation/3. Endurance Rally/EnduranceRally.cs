using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.Endurance_Rally
{
    class Racer
    {
        public string Name { get; set; }
        public decimal Fuel { get; set; }
        public int ZoneReached { get; set; }
        public bool isTankEmptry { get; set; }
    }

    class EnduranceRally
    {
        private static decimal GetFuelAmount(char firstLetter)
        {
            var fuelLevel = (int)firstLetter;
            return fuelLevel;
        }

        static void Main(string[] args)
        {
            List<Racer> racers = new List<Racer>();

            var drivers = Console.ReadLine().Split(' ').ToList();
            var zones = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();
            var checkpointIndexes = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < drivers.Count; i++)
            {
                var currentName = drivers[i];

                Racer currentRacer = new Racer();
                currentRacer.Name = currentName;
                currentRacer.Fuel = GetFuelAmount(currentName[0]); //Finds the fuel according to first Letter of the name using ASCII table
                currentRacer.isTankEmptry = false;

                racers.Add(currentRacer);
            }

            foreach (var racer in racers)
            {
                for (int i = 0; i < zones.Count; i++)
                {
                    if (checkpointIndexes.Contains(i)) //Checkpoint (adding fuel)
                    {
                        racer.Fuel += zones[i];
                        racer.ZoneReached = i;
                    }
                    else //Non checkpoint
                    {
                        racer.Fuel -= zones[i];

                        if (racer.Fuel <= 0)
                        {
                            racer.isTankEmptry = true;
                            racer.ZoneReached = i;
                            racer.Fuel = 0;
                            break;
                        }
                    }
                }
            }

            foreach (var racer in racers)
            {
                Console.Write($"{racer.Name} - ");
                if (racer.isTankEmptry == true)
                {
                    Console.WriteLine($"reached {racer.ZoneReached}");
                }
                else
                {
                    Console.WriteLine($"fuel left {racer.Fuel:F2}");
                }
            }
        }
    }
}
