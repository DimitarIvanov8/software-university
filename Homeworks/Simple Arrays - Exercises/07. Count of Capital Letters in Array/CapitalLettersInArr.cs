using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Count_of_Capital_Letters_in_Array
{
    class CapitalLettersInArr
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine()
                .Split(' ')
                .ToArray();

            int capitalLettersCount = 0;

            for (int i = 0; i < text.Length; i++)
            {
                string currentWord = text[i];

                if (currentWord.Length == 1)
                {
                    char currentChar = currentWord[0];
                    if (currentChar >= 65 && currentChar <= 90)
                    {
                        capitalLettersCount++;
                    }
                }
            }

            Console.WriteLine(capitalLettersCount);
        }
    }
}
