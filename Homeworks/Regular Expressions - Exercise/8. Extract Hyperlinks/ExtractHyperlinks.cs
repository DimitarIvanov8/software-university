using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _8.Extract_Hyperlinks
{
    class ExtractHyperlinks
    {
        public static List<String> result;
        static void Main(string[] args)
        {
            result = new List<String>();
            String input = GetInput();

            GetResults(input);
            PrintResults();
        }

        public static void PrintResults()
        {
            foreach (var i in result)
            {
                Console.WriteLine(i);
            }
        }

        public static void GetResults(String input)
        {
            //String pat = @"\u\s;
            String pattern = @"(?:<a)(?:[\s\n_0-9a-zA-Z=""()]*?.*?)(?:href([\s\n]*)?=(?:['""\s\n]*)?)([a-zA-Z:#\/._\-0-9!?=^+]*(\([""'a-zA-Z\s.()0-9]*\))?)(?:[\s\na-zA-Z=""()0-9]*.*?)?(?:\>)";
            Regex rex = new Regex(pattern);
            Match match = rex.Match(input);

            while (match.Success)
            {
                if (!(match.Groups[2].Value == "fake"))
                {
                    result.Add(match.Groups[2].Value);
                }
                match = match.NextMatch();
            }
        }

        public static String GetInput()
        {
            StringBuilder bld = new StringBuilder();
            while (true)
            {
                String input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }

                bld.Append(input);
                bld.Append("\n");
            }

            return bld.ToString();
        }
    }
}
