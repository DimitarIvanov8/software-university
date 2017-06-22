using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _5.Extract_Email
{
    class ExtractEmail
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Regex regex = new Regex(@"((?<=\s)[a-zA-Z0-9]+([-.]\w*)*@[a-zA-Z]+?([.-][a-zA-Z]*)*(\.[a-z]{2,}))");

            MatchCollection matches = regex.Matches(input);

            foreach (Match item in matches)
            {
                Console.WriteLine(item.Value);
            }
        }
    }
}
