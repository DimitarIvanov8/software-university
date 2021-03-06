﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


namespace Debugging___GUnit
{
    class GUnit
    {
        static void Main(string[] args)
        {
            Regex validationRegex = new Regex(@"^([A-Z][a-zA-Z0-9]+) \| ([A-Z][a-zA-Z0-9]+) \| ([A-Z][a-zA-Z0-9]+)$");

            Dictionary<string, Dictionary<string, List<string>>> classes = new Dictionary<string, Dictionary<string, List<string>>>();

            string inputLine = Console.ReadLine();

            while (inputLine != "It's testing time!")
            {
                var matches = validationRegex.Matches(inputLine);

                if (validationRegex.IsMatch(inputLine))
                {
                    Match match = validationRegex.Match(inputLine);

                    string className = match.Groups[1].Value;
                    string methodName = match.Groups[2].Value;
                    string unitTestName = match.Groups[3].Value;

                    if (!classes.ContainsKey(className))
                    {
                        classes[className] = new Dictionary<string, List<string>>();
                    }

                    if (!classes[className].ContainsKey(methodName))
                    {
                        classes[className][methodName] = new List<string>();
                    }

                    if (!classes[className][methodName].Contains(unitTestName))
                    {
                        classes[className][methodName].Add(unitTestName);
                    }
                }

                inputLine = Console.ReadLine();
            }

            Dictionary<string, Dictionary<string, List<string>>> sortedClasses =
                classes.OrderByDescending(x => x.Value.Values.Sum(y => y.Count))
                .ThenBy(x => x.Value.Count)
                .ThenBy(x => x.Key, StringComparer.Ordinal).ToDictionary(x => x.Key, x => x.Value);

            foreach (var classEntry in sortedClasses)
            {
                Console.WriteLine($"{classEntry.Key}:");

                Dictionary<string, List<string>> sortedMethods =
                    classEntry.Value
                    .OrderByDescending(m => m.Value.Count)
                    .ThenBy(m => m.Key, StringComparer.Ordinal)
                    .ToDictionary(m => m.Key, m => m.Value);

                foreach (var methodEntry in sortedMethods)
                {
                    Console.WriteLine("##" + methodEntry.Key);

                    List<string> sortedUnitTests =
                        methodEntry.Value.OrderBy(u => u.Length)
                        .ThenBy(u => u, StringComparer.Ordinal).ToList();

                    foreach (var unitTestEntry in sortedUnitTests)
                    {
                        Console.WriteLine("####" + unitTestEntry);
                    }
                }
            }
        }
    }
}
