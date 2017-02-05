using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.String_Repeater
{
    class StringRepeater
    {
        static void Main(string[] args)
        {
            string userText = Console.ReadLine();
            int repeatCount = int.Parse(Console.ReadLine());

            var repeatedString = RepeatString(userText, repeatCount);
            Console.WriteLine(repeatedString);
        }

        static string RepeatString(string userText, int repeatCount)
        {
            string repeatedString = string.Empty;

            for (int i = 0; i < repeatCount; i++)
            {
                repeatedString += userText;
            }

            return repeatedString;
        }
    }
}
