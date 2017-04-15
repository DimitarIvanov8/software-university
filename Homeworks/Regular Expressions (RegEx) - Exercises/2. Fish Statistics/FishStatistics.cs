using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _2.Fish_Statistics
{
    class FishStatistics
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"(>*)(?:<+)(\(+)('|-|x)>");

            string inputFish = Console.ReadLine();

            MatchCollection matchedFish = regex.Matches(inputFish);

            if (matchedFish.Count == 0)
            {
                Console.WriteLine("No fish found.");
                return;
            }

            int fishCounter = 1;

            foreach (Match fish in matchedFish)
            {
                var tailLength = fish.Groups[1].ToString();
                var bodyLength = fish.Groups[2].ToString();
                var status = fish.Groups[3].ToString();

                Console.WriteLine($"Fish {fishCounter}: {fish}");
                fishCounter++;

                var tailType = "";
                var bodyType = "";
                var statusType = "";

                //tail type
                if (tailLength.Length > 5)
                {
                    tailType = "Long";
                }
                else if (tailLength.Length > 1 && tailLength.Length <= 5)
                {
                    tailType = "Medium";
                }
                else if (tailLength.Length == 1)
                {
                    tailType = "Short";
                }
                else if (tailLength.Length == 0)
                {
                    tailType = "None";
                }

                //body type
                if (bodyLength.Length > 10)
                {
                    bodyType = "Long";
                }
                else if (bodyLength.Length > 5 && bodyLength.Length <= 10)
                {
                    bodyType = "Medium";
                }
                else if (bodyLength.Length <= 5)
                {
                    bodyType = "Short";
                }

                //status type
                if (status == "'")
                {
                    statusType = "Awake";
                }
                else if (status == "-")
                {
                    statusType = "Asleep";
                }
                else if (status == "x")
                {
                    statusType = "Dead";
                }

                Console.WriteLine($"Tail type: {tailType} ({tailLength.Length * 2} cm)");
                Console.WriteLine($"Body type: {bodyType} ({bodyLength.Length * 2} cm)");
                Console.WriteLine($"Status: {statusType}");
            }
        }
    }
}
