using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Letter_Repetition
{
    class LetterRepetition
    {
        static void Main(string[] args)
        {
            var randomCharacters = Console.ReadLine();
            var characterCollection = new Dictionary<char, int>();

            foreach (var item in randomCharacters)
            {
                if (!characterCollection.ContainsKey(item))
                {
                    characterCollection[item] = 0;
                }

                characterCollection[item]++;
            }
            foreach (var kvp in characterCollection)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
