using System;
using System.Linq;

namespace _02.Japanese_Roulette
{
    class JapaneseRoulette
    {
        static void Main(string[] args)
        {
            var cylinder = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var directionAndSpins = Console.ReadLine().Split(' ').ToArray();
            var bulletSpot = 0;
            var player = 0;

            for (int j = 0; j < cylinder.Length; j++)
            {
                if (cylinder[j] == 1)
                {
                    bulletSpot = j + 1;
                }
            }

            for (int i = 0; i < directionAndSpins.Length; i++)
            {
                var currentRotation = directionAndSpins[i].ToString().Split(',');
                string rotationNum = currentRotation[0];
                var direction = directionAndSpins[i].Contains("Left") ? "Left" : "Right";
                bulletSpot = BulletPlace(int.Parse(rotationNum), bulletSpot, direction);

                if (bulletSpot == 3)
                {
                    Console.WriteLine($"Game over! Player {player} is dead.");
                    return;
                }
                player++;

                bulletSpot = BulletPlace(1, bulletSpot, "Right");
            }
            Console.WriteLine("Everybody got lucky!");
        }

        private static int BulletPlace(int rotationNum, int bulletSpot, string direction)
        {
            if (direction == "Right")
            {
                if (bulletSpot + rotationNum == 6)
                {
                    bulletSpot = (bulletSpot + rotationNum) % 6 + 6;
                }
                else
                {
                    bulletSpot = (bulletSpot + rotationNum) % 6;
                }
            }
            else if (direction == "Left")
            {
                if (bulletSpot - rotationNum <= 0)
                {
                    bulletSpot = 6 - (Math.Abs((bulletSpot - rotationNum) % 6));
                }
                else if (bulletSpot - rotationNum > 0)
                {
                    bulletSpot = Math.Abs((bulletSpot - rotationNum) % 6);
                }
            }
            return bulletSpot;
        }
    }
}
