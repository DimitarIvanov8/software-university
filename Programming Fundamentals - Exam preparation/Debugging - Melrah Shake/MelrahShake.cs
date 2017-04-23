using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Debugging___Melrah_Shake
{
    class MelrahShake
    {
        static void Main(string[] args)
        {
            var inputString = Console.ReadLine();
            var inputPattern = Console.ReadLine();
            Regex regex = new Regex(Regex.Escape(inputPattern));
            var matches = regex.Matches(inputString);

            while (matches.Count >= 2 && inputPattern.Length > 0)
            {
                var startIndex = inputString.IndexOf(inputPattern);
                var lastIndex = inputString.LastIndexOf(inputPattern);

                inputString = inputString.Remove(lastIndex, inputPattern.Length);
                inputString = inputString.Remove(startIndex, inputPattern.Length);
                Console.WriteLine("Shaked it.");

                inputPattern = inputPattern.Remove((inputPattern.Length / 2), 1);

                regex = new Regex(Regex.Escape(inputPattern));
                matches = regex.Matches(inputString);
            }
            Console.WriteLine("No shake.");
            Console.WriteLine(inputString);
        }
    }
}
