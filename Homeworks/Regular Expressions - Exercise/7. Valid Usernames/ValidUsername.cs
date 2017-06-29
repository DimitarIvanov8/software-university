using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _7.Valid_Usernames
{
    class ValidUsername
    {
        static void Main(string[] args)
        {
            string[] users = Console.ReadLine().Split(new char[] { ' ', '/', '\\', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
            List<string> validUsers = new List<string>();
            Regex rg = new Regex(@"^[A-Za-z]\w{2,24}$");

            foreach (var user in users)
            {
                if (rg.IsMatch(user))
                {
                    validUsers.Add(user);
                }
            }

            int maxSumLength = 0;
            string user1 = "";
            string user2 = "";

            for (int i = 0; i < validUsers.Count - 1; i++)
            {
                int sumLength = validUsers[i].Length + validUsers[i + 1].Length;

                if (sumLength > maxSumLength)
                {
                    maxSumLength = sumLength;

                    user1 = validUsers[i];
                    user2 = validUsers[i + 1];
                }
            }

            Console.WriteLine(user1);
            Console.WriteLine(user2);
        }
    }
}
