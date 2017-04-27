using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _3.Football_League_2._0
{
    public class Score
    {
        public decimal Points { get; set; }

        public decimal Goals { get; set; }
    }

    class FootballLeague20
    {
        static void Main(string[] args)
        {
            var firstLine = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var key = Regex.Escape(string.Join("", firstLine));

            var pattern = new Regex($@"^.*(?:{key})(?<team1>[A-Za-z]*)(?:{key}).* .*(?:{key})(?<team2>[A-Za-z]*)(?:{key}).* (?<team1Score>\d+):(?<team2Score>\d+).*$").ToString();

            var teamScores = new Dictionary<string, Score>(); 

            var line = Console.ReadLine();

            while (line != "final")
            {
                var matches = Regex.Match(line, pattern);

                if (!matches.Success)
                {
                    line = Console.ReadLine();
                    continue;
                }

                var team1Name = new string(matches.Groups["team1"].Value.ToUpper().Reverse().ToArray());
                var team2Name = new string(matches.Groups["team2"].Value.ToUpper().Reverse().ToArray());
                var team1Goals = int.Parse(matches.Groups["team1Score"].Value);
                var team2Goals = int.Parse(matches.Groups["team2Score"].Value);

                if (!teamScores.ContainsKey(team1Name))
                {
                    teamScores[team1Name] = new Score();
                }

                if (!teamScores.ContainsKey(team2Name))
                {
                    teamScores[team2Name] = new Score();
                }

                if (team1Goals > team2Goals) //team 1 wins
                {
                    teamScores[team1Name].Points += 3;
                }
                else if (team1Goals == team2Goals) //tie
                {
                    teamScores[team1Name].Points++;
                    teamScores[team2Name].Points++;
                }
                else //team 2 wins
                {
                    teamScores[team2Name].Points += 3;
                }

                teamScores[team1Name].Goals += team1Goals;
                teamScores[team2Name].Goals += team2Goals;

                line = Console.ReadLine();
            }

            Console.WriteLine("League standings:");

            int place = 1;
            foreach (var teamInfo in teamScores.OrderByDescending(x => x.Value.Points).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{place++}. {teamInfo.Key} {teamInfo.Value.Points}");
            }

            Console.WriteLine("Top 3 scored goals:");

            foreach (var teamGoals in teamScores.OrderByDescending(x => x.Value.Goals).ThenBy(x => x.Key).Take(3))
            {
                Console.WriteLine($"- {teamGoals.Key} -> {teamGoals.Value.Goals}");
            }
        }
    }
}
