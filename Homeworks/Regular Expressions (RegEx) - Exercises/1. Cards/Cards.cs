using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _1.Cards
{
    class Cards
    {
        static void Main(string[] args)
        {
            string inputCards = Console.ReadLine();

            Regex regex = new Regex("([1]?[0-9JKQKA])([SHDC])");
            
            MatchCollection matchedCards = regex.Matches(inputCards);
            List<string> validCards = new List<string>();

            foreach (Match card in matchedCards)
            {
                int power = 0;
                if (int.TryParse(card.Groups[1].Value, out power))
                {
                    if (power < 2 || power > 10)
                    {
                        continue;
                    }
                }
                validCards.Add(card.Value);
            }
            Console.WriteLine(String.Join(", ", validCards));
        }
    }
}
