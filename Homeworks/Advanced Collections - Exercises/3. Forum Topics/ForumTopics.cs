using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Forum_Topics
{
    class ForumTopics
    {
        static void Main(string[] args)
        {
            var forum = new Dictionary<string, HashSet<string>>();
            var line = Console.ReadLine() .Split(new[] {' ', '-', '>', ',' }, 
                StringSplitOptions.RemoveEmptyEntries);
;
            while (!line.Contains("filter"))
            {
                var topic = line[0];
                if (!forum.ContainsKey(topic))
                {
                    forum[topic] = new HashSet<string>();
                }

                for (int i = 1; i < line.Count(); i++)
                {
                    forum[topic].Add(line[i]);
                }

                line = Console.ReadLine().Split(new[] { ' ', '-', '>', ',' },
                    StringSplitOptions.RemoveEmptyEntries);
            }
            var filter = Console.ReadLine().Split(new[] { ' ', ',' },
                StringSplitOptions.RemoveEmptyEntries);

            string[] search = filter;

            foreach (var topicAndTags in forum)
            {
                var topic = topicAndTags.Key;
                var tags = topicAndTags.Value;
                var counter = 0;

                for (int j = 0; j < search.Length; j++)
                {
                    if (topicAndTags.Value.Contains(search[j]))
                    {
                        counter++;
                    }
                }
                if (search.Length == counter)
                {
                    Console.WriteLine($"{topic} | #{String.Join(", #", tags)}");
                }
            }
        }
    }
}
