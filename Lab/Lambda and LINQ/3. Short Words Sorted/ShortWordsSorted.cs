using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Short_Words_Sorted
{
    class ShortWordsSorted
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine()
                .Split(new[] { '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.ToLower())
                .OrderBy(x => x)
                .Distinct()
                .Where(x => x.Length < 5)
                .ToList();

            Console.WriteLine(String.Join(", ", text));
        }
    }
}
