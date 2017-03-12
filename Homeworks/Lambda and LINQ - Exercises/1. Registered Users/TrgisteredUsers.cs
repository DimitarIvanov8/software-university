using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace _1.Registered_Users
{
    class TrgisteredUsers
    {
        static void Main(string[] args)
        {
            var nameAndDate = Console.ReadLine()
                .Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            var registry = new Dictionary<string, DateTime>();

            while (nameAndDate[0] != "end")
            {
                var name = nameAndDate[0];
                var date = DateTime.ParseExact(nameAndDate[1], "dd/MM/yyyy",CultureInfo.InvariantCulture);
                registry.Add(name, date);

                nameAndDate = Console.ReadLine()
                .Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            }

            var resultRegistry = registry
                .Reverse()
                .OrderBy(x => x.Value)
                .Take(5)
                .OrderByDescending(x => x.Value)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var item in resultRegistry)
            {
                Console.WriteLine($"{item.Key}");
            }
        }
    }
}
