/*
Scan through the lines for valid times.
A valid time:
•	Is in the interval 00:00:00 AM to 11:59:59 PM
•	Has no redundant symbols before, after or in between
Read lines until you get the "END" command.

Example input:
11:33:24 AM
33:12:11 PM
inv 23:52:34 AM
00:13:23     PM
9:3:12 АМ
END

Output:
valid
invalid
invalid
invalid
invalid
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _7.Valid_Time
{
    class ValidTime
    {
        static void Main(string[] args)
        {
            var inputTime = Console.ReadLine();

            Regex patern = new Regex(@"^(0[0-9]|1[012]):[0-5][0-9]:[0-5][0-9] [AP]M$");

            while (inputTime != "END")
            {
                Match match = patern.Match(inputTime);

                if (match.Success)
                {
                    Console.WriteLine("valid");
                }
                else
                {
                    Console.WriteLine("invalid");
                }

                inputTime = Console.ReadLine();
            }
        }
    }
}
