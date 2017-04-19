using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _3.Nether_Realms_2._0
{
    class Demon
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public double Damage { get; set; }
    }

    class NetherRealms2
    {
        static void Main(string[] args)
        {
            List<Demon> demons = new List<Demon>();

            var inputDemons = Console.ReadLine()
                .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            foreach (var demon in inputDemons)
            {
                var currentHealthSymbols = demon
                    .Where(x => !char.IsDigit(x) && x != '+' && x != '-' &&
                    x != '*' && x != '/' && x != '.').ToList();

                var currentHealth = 0;

                for (int i = 0; i < currentHealthSymbols.Count; i++)
                {
                    currentHealth += (int)currentHealthSymbols[i];
                }

                var regex = new Regex(@"-?\d+\.?\d*");
                var matches = regex.Matches(demon);
                var damageSum = 0.0;

                foreach (Match match in matches)
                {
                    var currentNum = double.Parse(match.Value);
                    damageSum += currentNum;
                }

                var modifiers = demon.Where(x => x == '*' || x == '/');

                foreach (var modifier in modifiers)
                {
                    if (modifier == '*')
                    {
                        damageSum *= 2;
                    }
                    else if (modifier == '/')
                    {
                        damageSum /= 2;
                    }
                }

                Demon currentDemon = new Demon();
                currentDemon.Name = demon;
                currentDemon.Health = currentHealth;
                currentDemon.Damage = damageSum;
                demons.Add(currentDemon);
            }

            demons = demons.OrderBy(x => x.Name).ToList();

            foreach (var demon in demons)
            {
                Console.WriteLine($"{demon.Name} - {demon.Health} health, {demon.Damage:F2} damage");
            }
        }
    }
}
