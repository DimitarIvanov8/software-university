using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _4.Roli_The_Coder
{
    class Event
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<string> participants { get; set; }
    }

    class RoliTheCoder
    {
        static void Main(string[] args)
        {
            List<Event> result = new List<Event>();
            var eventById = new Dictionary<int, Event>();

            var line = string.Empty;
            while (line != "Time for Code")
            {
                line = Console.ReadLine();

                var lineParts = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                var eventID = 0;

                if (!int.TryParse(lineParts[0], out eventID))
                {
                    continue;
                }

                var eventName = string.Empty;

                if (lineParts.Length > 1 && lineParts[1].StartsWith("#"))
                {
                    eventName = lineParts[1].Trim('#');
                }
                else
                {
                    continue;
                }

                var participants = new List<string>();

                if (lineParts.Length > 2)
                {
                    participants = lineParts.Skip(2).ToList();

                    if (!participants.All(p => p.StartsWith("@")))
                    {
                        continue;
                    }
                }

                if (eventById.ContainsKey(eventID))
                {
                    if (eventById[eventID].Name == eventName)
                    {
                        var existingEvent = eventById[eventID];
                        eventById[eventID].participants.AddRange(participants);
                    }
                    else
                    {
                        continue;
                    }
                }
                else
                {
                    Event currentEvent = new Event();
                    currentEvent.Id = eventID;
                    currentEvent.Name = eventName;
                    currentEvent.participants = participants;

                    result.Add(currentEvent);

                    eventById.Add(eventID, currentEvent);
                }
            }

            var sortedEvents = result
                .OrderByDescending(e => e.participants.Distinct().Count())
                .ThenBy(e => e.Name);

            foreach (var ev in sortedEvents)
            {
                var distinctParticipants = ev.participants.Distinct().ToList();
                Console.WriteLine($"{ev.Name} - {distinctParticipants.Count}");
                foreach (var participant in distinctParticipants.OrderBy(p => p))
                {
                    Console.WriteLine($"{participant}");
                }
            }
        }
    }
}
