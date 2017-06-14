/*
Scan through the lines for valid usernames.
A valid username:
•	Has length between 3 and 16 characters
•	Contains only letters, numbers, hyphens and underscores
•	Has no redundant symbols before, after or in between
Read lines until you get the "END" command.

Example input:
sh
too_long_username
!lleg@l ch@rs
jeff_butt
END

Output:
invalid
invalid
invalid
valid
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _6.Valid_Usernames
{
    class ValidUsernames
    {
        static void Main(string[] args)
        {
            var userName = Console.ReadLine();

            Regex pattern = new Regex(@"^[A-Za-z0-9\-_]{3,16}$");

            while (userName != "END")
            {
                Match match = pattern.Match(userName);

                if (match.Success)
                {
                    Console.WriteLine("valid");
                }
                else
                {
                    Console.WriteLine("invalid");
                }

                userName = Console.ReadLine();
            }
        }
    }
}
