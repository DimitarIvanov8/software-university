using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._hard__Ballistics_Training
{
    class BalisticsTraining
    {
        static void Main(string[] args)
        {
            var targetXY = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var commands = Console.ReadLine()
                .Split(' ');

            int[] aimXY = new int[2];

            var currentAim = 0;
            
            for (int i = 0, j = 1; i < commands.Length - 1; i += 2, j += 2)
            {
                currentAim = int.Parse(commands[j]);

                if (commands[i] == "up")
                {
                    aimXY[1] += currentAim;
                }
                else if (commands[i] == "down")
                {
                    aimXY[1] -= currentAim;
                }
                else if (commands[i] == "left")
                {
                    aimXY[0] -= currentAim;
                }
                else if (commands[i] == "right")
                {
                    aimXY[0] += currentAim;
                }
            }

            Console.WriteLine($"firing at [{aimXY[0]}, {aimXY[1]}]");

            if (targetXY[0] == aimXY[0] && targetXY[1] == aimXY[1])
            {
                Console.WriteLine("got 'em!");
            }
            else
            {
                Console.WriteLine("better luck next time...");
            }
        }
    }
}
