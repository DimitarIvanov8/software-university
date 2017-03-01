using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


namespace _01.Rabbit_Hole_2._0
{
    class NewRabbitHole
    {
        static void Main(string[] args)
        {
            var obstacles = Console.ReadLine()
                .Split(' ')
                .ToList();
            var energy = int.Parse(Console.ReadLine());

            if (obstacles[0].Contains("RabbitHole"))
            {
                Console.WriteLine("You have 5 years to save Kennedy!");
                return;
            }

            var steps = 0;
            var leftOrRight = "";
            var currentPosition = 0;
            bool lastBomb = false;

            while (energy > 0)
            {
                lastBomb = false;

                if (obstacles[currentPosition].Contains("RabbitHole"))
                {
                    Console.WriteLine("You have 5 years to save Kennedy!");
                    return;
                }
                else if (obstacles[currentPosition].Contains("Bomb")) //to add boom
                {
                    steps = int.Parse(Regex.Match(obstacles[currentPosition], @"\d+").Value);
                    obstacles.RemoveAt(currentPosition);
                    currentPosition = 0;
                    energy -= steps;
                    lastBomb = true;
                    continue;
                }
                else
                {
                    leftOrRight = obstacles[currentPosition].Contains("Left") ? "Left" : "Right";
                    steps = int.Parse(Regex.Match(obstacles[currentPosition], @"\d+").Value);
                    energy -= steps;
                }

                if (energy <= 0)
                {
                    Console.WriteLine("You are tired. You can't continue the mission.");
                    break;
                }
                else
                {
                    if (leftOrRight == "Right")
                    {
                        currentPosition = (currentPosition + steps) % obstacles.Count;
                    }
                    else if (leftOrRight == "Left")
                    {
                        currentPosition = Math.Abs(currentPosition - steps) % obstacles.Count;
                    }
                }
                if (!obstacles[obstacles.Count-1].Contains("RabbitHole"))
                {
                    obstacles.RemoveAt(obstacles.Count - 1);
                }
                obstacles.Add($"Bomb|{energy}");
            }
            if (lastBomb)
            {
                Console.WriteLine("You are dead due to bomb explosion!");
            }
        }
    }
}
