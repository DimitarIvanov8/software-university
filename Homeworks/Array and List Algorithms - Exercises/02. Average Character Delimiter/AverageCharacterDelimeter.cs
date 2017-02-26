using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Average_Character_Delimiter
{
    class AverageCharacterDelimeter
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine()
                .Split(' ')
                .ToArray();

            var sumOfLetters = 0;
            var currentString = "";
            var currentChar = ' ';
            var lettersCount = 0;

            for (int i = 0; i < text.Length; i++)
            {
                currentString = text[i];

                for (int j = 0; j < text[i].Length; j++)
                {
                    currentChar = currentString[j];
                    sumOfLetters += (int)(currentChar);
                    lettersCount++;
                }
            }
            sumOfLetters /= lettersCount;

            currentChar = (char)sumOfLetters;
            Console.WriteLine(String.Join($"{currentChar}".ToUpper(), text));
        }
    }
}
