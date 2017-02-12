using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Char_Rotation
{
    class ChatRotation
    {
        static void Main(string[] args)
        {
            var inputString = Console.ReadLine();
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var stringToChar = inputString.ToCharArray();
            var currentChar = 0;

            for (int i = 0; i < stringToChar.Length; i++)
            {
                currentChar = stringToChar[i];

                if (numbers[i] % 2 != 0) //add
                {
                    currentChar += numbers[i];
                    Console.Write((char)currentChar);
                }
                else //substract
                {
                    currentChar -= numbers[i];
                    Console.Write((char)currentChar);
                }
            }
        }
    }
}
