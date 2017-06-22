using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _4.Replace_a_tag
{
    class ReplaceATag
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            while (true)
            {
                if (input == "end")
                {
                    break;
                }
                else
                {
                    Console.WriteLine(Regex.Replace(input, @"<a.*?href.*?=(.*?)>(.*?)<\/a>", @"[URL href=$1]$2[/URL]"));

                    input = Console.ReadLine();
                }
            }
        }
    }
}
