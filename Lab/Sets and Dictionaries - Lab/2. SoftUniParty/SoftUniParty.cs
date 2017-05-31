using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.SoftUniParty
{
    class SoftUniParty
    {
        static void Main(string[] args)
        {
            var reserverations = new SortedSet<string>();
            var input = Console.ReadLine();

            while (input != "PARTY")
            {
                reserverations.Add(input);
                input = Console.ReadLine();
            } 

            while (input != "END")
            {
                reserverations.Remove(input);
                input = Console.ReadLine();
            }

            Console.WriteLine(reserverations.Count);
            foreach (var reservation in reserverations)
            {
                Console.WriteLine(reservation);
            }
        }
    }
}
