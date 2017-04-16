using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.SoftUni_Karaoke
{
    class SoftUniKaraoke
    {
        static void Main(string[] args)
        {
            var peopleSongsAndAwards = new Dictionary<string, List<string>>();
            var participants = Console.ReadLine().Split(new[] { ' ', ',' },StringSplitOptions.RemoveEmptyEntries).ToList();
            var songs = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.None);

            var line = Console.ReadLine();
            while (line != "dawn")
            {
                string[] tokens = line.Split(new[] { ',' });
                var currentName = tokens[0].Trim();
                var currentSong = tokens[1].Trim();
                var currentAward = tokens[2].Trim();

                if (participants.Contains(currentName) && songs.Contains(currentSong)) //need fix
                {
                    if (!peopleSongsAndAwards.ContainsKey(currentName))
                    {
                        peopleSongsAndAwards[currentName] = new List<string>();
                    }

                    if (!peopleSongsAndAwards[currentName].Contains(currentAward))
                    {
                        peopleSongsAndAwards[currentName].Add(currentAward);
                    }
                }

                line = Console.ReadLine();
            }

            if (peopleSongsAndAwards.Values.Count == 0)
            {
                Console.WriteLine("No awards");
                return;
            }

            foreach (var item in peopleSongsAndAwards
                .OrderByDescending(x => x.Value.Count)
                .ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count} awards");
                item.Value.Sort();

                foreach (var award in item.Value)
                {
                    Console.WriteLine($"--{award}");
                }
            }
        }
    }
}
