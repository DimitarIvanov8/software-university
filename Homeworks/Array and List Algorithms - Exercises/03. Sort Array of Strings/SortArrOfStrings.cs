using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Sort_Array_of_Strings
{
    class SortArrOfStrings
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine()
                .Split(' ')
                .ToArray();

            for (int i = 0; i < text.Length - 1; i++)
            {

                var j = i + 1;

                while (j > 0)
                {
                    if (text[j].CompareTo(text[j - 1]) == -1)
                    {
                        var temp = text[j];
                        text[j] = text[j - 1];
                        text[j - 1] = temp;
                    }
                    j--;
                }
            }

            Console.WriteLine(String.Join(" ", text));
        }
    }
}
