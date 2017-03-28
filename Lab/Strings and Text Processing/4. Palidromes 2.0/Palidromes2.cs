using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Palidromes_2._0
{
    class Palidromes2
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(new char[] { ',', ';', '!', '.', ' ', '?' }, StringSplitOptions.RemoveEmptyEntries);
            SortedSet<string> palindromes = new SortedSet<string>();

            foreach (string item in input)
            {
                if (isPalindrome(item))
                {
                    palindromes.Add(item);
                }
            }
            Console.WriteLine(string.Join(", ", palindromes));
        }

        static bool isPalindrome(string currentWord)
        {
            int startIndex = 0;
            int lastIndex = currentWord.Length - 1;
            int iterations = currentWord.Length / 2;
            bool hasMatch = false;

            for (int i = 0; i <= iterations; i++)
            {
                if (currentWord[startIndex] == currentWord[lastIndex])
                {
                    startIndex++;
                    lastIndex--;
                    hasMatch = true;
                    continue;
                }
                else
                {
                    hasMatch = false;
                    break;
                }
            }
            return hasMatch;
        }
    }
}
