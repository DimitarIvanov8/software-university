using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _2.Append_Lists
{
    class AppendLists
    {
        static void Main(string[] args)
        {
            List<string> numbers = "7 | 4  5|1 0| 2 5 |3"//Console.ReadLine()
                .Split('|')
                .ToList();

            numbers.Reverse();

            var resultString = string.Join(" ", numbers);

            var tagsSplit = resultString.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(s => s.Trim());

            foreach (var num in tagsSplit)
            {
                Console.Write(num + " ");
            }

        }
    }
}
