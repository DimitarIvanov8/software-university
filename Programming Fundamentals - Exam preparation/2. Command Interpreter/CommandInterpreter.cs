﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Command_Interpreter
{
    class CommandInterpreter
    {
        static void Main(string[] args)
        {
            List<string> array = Console.ReadLine().Split(new[] { ' '}, StringSplitOptions.RemoveEmptyEntries).ToList();

            string inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                string[] inputParams = inputLine.Split(' ');

                var command = inputParams[0];

                switch (command)
                {
                    case "reverse":
                        int reverseStart = int.Parse(inputParams[2]);
                        int reverseCount = int.Parse(inputParams[4]);
                        if (IsValid(array, reverseStart, reverseCount))
                        {
                            Reverse(array, reverseStart, reverseCount);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }

                        break;
                    case "sort":
                        int sortStart = int.Parse(inputParams[2]);
                        int sortCount = int.Parse(inputParams[4]);
                        if (IsValid(array, sortStart, sortCount))
                        {
                            Sort(array, sortStart, sortCount);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }

                        break;
                    case "rollLeft":
                        int rollLeftCount = int.Parse(inputParams[1]);
                        if (rollLeftCount >= 0)
                        {
                            RollLeft(array, rollLeftCount);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }

                        break;
                    case "rollRight":
                        int rollRightCount = int.Parse(inputParams[1]);
                        if (rollRightCount >= 0)
                        {
                            RollRight(array, rollRightCount);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }

                        break;
                    default:
                        break;
                }

                inputLine = Console.ReadLine();
            }

            Console.WriteLine($"[{string.Join(", ", array)}]");
        }

        private static bool IsValid(List<string> array, int start, int count)
        {
            bool result = start >= 0 &&
                start < array.Count &&
                count >= 0 && 
                (start + count) <= array.Count;

            return result;
        }

        private static void Reverse(List<string> array, int reverseStart, int reverseCount)
        {
            array.Reverse(reverseStart, reverseCount);
        }

        private static void Sort(List<string> array, int sortStart, int sortCount)
        {
            array.Sort(sortStart, sortCount, null);
        }

        private static void RollLeft(List<string> array, int rollLeftCount)
        {
            var rotations = rollLeftCount % array.Count;

            for (int i = 0; i < rotations; i++)
            {
                string firstElement = array[0];

                for (int j = 0; j < array.Count - 1; j++)
                {
                    array[j] = array[j + 1];   
                }

                array[array.Count - 1] = firstElement;
            }
        }

        private static void RollRight(List<string> array, int rollRightCount)
        {
            var rotations = rollRightCount % array.Count;

            for (int i = 0; i < rotations; i++)
            {
                string firstElement = array[array.Count - 1];

                for (int j = array.Count - 1; j > 0; j--)
                {
                    array[j] = array[j - 1];
                }

                array[0] = firstElement;
            }
        }
    }
}
