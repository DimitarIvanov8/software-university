using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _4.Happiness_Index
{
    class HappinessIndex
    {
        static void Main(string[] args)
        {
            Regex happyPattern = new Regex("([:;(*c\\[][)D*\\]}:;])");
            Regex sadPattern = new Regex("([:D;:)\\]][(:[{c;])");

            int happyCount = 0;
            int sadCount = 0;

            var emoticons = Console.ReadLine();

            MatchCollection happyMatches = happyPattern.Matches(emoticons);
            MatchCollection sadMatches = sadPattern.Matches(emoticons);

            foreach (Match match in happyMatches)
            {
                happyCount++;
            }

            foreach  (Match match in sadMatches)
            {
                sadCount++;
            }

            decimal happinessIndex = (decimal)happyCount / sadCount;
            var emoticon = "";
            if (happinessIndex >= 2)
            {
                emoticon = ":D";
            }
            else if (happinessIndex > 1)
            {
                emoticon = ":)";
            }
            else if (happinessIndex == 1)
            {
                emoticon = ":|";
            }
            else
            {
                emoticon = ":(";
            }

            Console.WriteLine($"Happiness index: {happinessIndex:F2} {emoticon}");
            Console.WriteLine($"[Happy count: {happyCount}, Sad count: {sadCount}]");
        }
    }
}
