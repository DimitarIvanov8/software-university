using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Palindromes
{
    class Palindromes
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(new[] { ',','!',' ', '.', '?'},StringSplitOptions.RemoveEmptyEntries);

            var palindromesToList = new List<string>();

            foreach (var word in input)
            {
                var palindrome = word.Reverse().ToList();
                if (word == String.Join("",palindrome))
                {
                    palindromesToList.Add(word);
                }
            }

            palindromesToList.Sort();
            Console.WriteLine(String.Join(", ", palindromesToList));
        }
    }
}
