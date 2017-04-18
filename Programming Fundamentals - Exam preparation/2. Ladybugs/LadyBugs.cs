using System;
using System.Linq;

namespace _2.Ladybugs
{
    class LadyBugs
    {
        static void Main(string[] args)
        {
            int[] field = new int[int.Parse(Console.ReadLine())];  
            var ladyBugsIndexes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            foreach (var position in field)
            {
                field[position] = 0;
            }

            for (int i = 0; i < ladyBugsIndexes.Length; i++)
            {
                if (ladyBugsIndexes[i] < field.Length && ladyBugsIndexes[i] >= 0)
                {
                    field[ladyBugsIndexes[i]] = 1;
                }
            }

            var command = Console.ReadLine().Split(' ').ToArray();

            while (!command.Contains("end"))
            {
                var bugIndex = int.Parse(command[0]);
                var direction = command[1];
                var flyLength = int.Parse(command[2]);

                if (bugIndex < field.Length && bugIndex >= 0) //to fix
                {
                    if (field[bugIndex] == 1) //there is a lady bug inside
                    {
                        field = ReturnIndex(direction, bugIndex, flyLength, field);
                    }
                }

                command = Console.ReadLine().Split(' ').ToArray();
            }

            Console.WriteLine(string.Join(" ", field));
        }

        private static int[] ReturnIndex(string direction, int bugIndex, int flyLength, int[] field)
        {
            //Left
            if (direction == "left")
            {
                if (bugIndex - flyLength < 0) //remove lady bug
                {
                    field[bugIndex] = 0;
                }
                else
                {
                    var positionAfterMove = bugIndex - flyLength;
                    bool trigger = false;

                    while (trigger == false)
                    {
                        field[bugIndex] = 0;
                        if (positionAfterMove < 0)
                        {
                            break;
                        }
                        if (field[positionAfterMove] == 0) //empty spot
                        {
                            field[positionAfterMove] = 1;
                            trigger = true;
                        }
                        else if (field[positionAfterMove] == 1) //there is a lady bug
                        {
                            positionAfterMove -= 1;
                        }
                    }
                }
            }
            //Right
            else if (direction == "right")
            {
                if (bugIndex + flyLength >= field.Length) //remove lady bug
                {
                    field[bugIndex] = 0;
                }
                else
                {
                    var positionAfterMove = bugIndex + flyLength;
                    bool trigger = false;

                    while (trigger == false)
                    {
                        field[bugIndex] = 0;
                        if (positionAfterMove >= field.Length)
                        {
                            break;
                        }
                        if (field[positionAfterMove] == 0) //empty spot
                        {
                            field[positionAfterMove] = 1;
                            trigger = true;
                        }
                        else if (field[positionAfterMove] == 1) //there is a lady bug
                        {
                            positionAfterMove += 1;
                        }
                    }
                }
            }           
            return field;
        }
    }
}
