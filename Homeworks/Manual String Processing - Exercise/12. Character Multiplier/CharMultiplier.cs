/*
Create a method that takes two strings as arguments and returns the sum of their character codes
multiplied(multiply str1.charAt (0) with str2.charAt(0) and add to the total sum). Then continue 
with the next two characters.If one of the strings is longer than the other, add the remaining
character codes to the total sum without multiplication.

Example:
Input: 
Gosho Pesho

Output:
53253
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Character_Multiplier
{
    class CharMultiplier
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            var stringA = input[0];
            var stringB = input[1];

            var minLength = Math.Min(stringA.Length, stringB.Length);
            var maxLength = Math.Max(stringA.Length, stringB.Length);
            var sum = 0;

            for (int i = 0; i < minLength; i++)
            {
                sum += MultiplyCharsASCII(stringA[i], stringB[i]);
            }

            if (stringA.Length != stringB.Length)
            {
                string longerInput = stringA.Length > stringB.Length ? stringA : stringB;
                for (int i = minLength; i < maxLength; i++)
                {
                    sum += longerInput[i];
                }
            }
            Console.WriteLine(sum);
        }

        static int MultiplyCharsASCII(char charA, char charB)
        {
            int multiply = charA * charB;
            return multiply;
        }
    }
}
