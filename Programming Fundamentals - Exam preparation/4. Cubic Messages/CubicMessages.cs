using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _4.Cubic_Messages
{
    class CubicMessages
    {
        static void Main(string[] args)
        {
            var pattern = @"^(?<firstNumber>\d+)(?<text>[a-zA-Z]+)(?<secondNumber>[^a-zA-Z]+)?$";

            var line = Console.ReadLine();

            while (line != "Over!")
            {
                var matches = Regex.Match(line, pattern);

                if (!matches.Success)
                {
                    line = Console.ReadLine();
                    continue;
                }

                var num = int.Parse(Console.ReadLine());

                var text = matches.Groups["text"].Value;

                if (text.Length != num)
                {
                    line = Console.ReadLine();
                    continue;
                }

                var firstNums = matches.Groups["firstNumber"].Value;
                var secondNums = matches.Groups["secondNumber"].Value;

                var verificationCode = String.Empty;

                var allNumbers = firstNums + secondNums;

                foreach (var @char in allNumbers)
                {
                    int index;
                    var isDigit = int.TryParse(@char.ToString(), out index);
                    var isValidIndex = index >= 0 && index < text.Length;

                    if (isDigit && isValidIndex)
                    {
                        var messageChar = text[index];
                        verificationCode += messageChar;
                    }
                    else
                    {
                        verificationCode += " ";
                    }
                }

                Console.WriteLine($"{text} == {verificationCode}");

                line = Console.ReadLine();
            }
        }
    }
}



