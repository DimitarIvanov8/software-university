using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Tricky_Strings
{
    class TrickyStrings
    {
        static void Main(string[] args)
        {
            string delimiter = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            string currentString;
            var completeText = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                currentString = Console.ReadLine();
                if (i != n - 1)
                {
                    completeText.Append(currentString+delimiter);
                }
                else if (i == n - 1)
                {
                    completeText.Append(currentString);
                    Console.WriteLine(completeText);
                }
            }
        }
    }
}
