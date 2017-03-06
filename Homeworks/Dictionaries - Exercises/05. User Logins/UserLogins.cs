using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.User_Logins
{
    class UserLogins
    {
        static void Main(string[] args)
        {
            var nameAndPass = new Dictionary<string, string>();
            string line = Console.ReadLine();

            while (line != "login")
            {
                var tokens = line.Split(' ');
                var name = tokens[0];
                var password = tokens[2];

                nameAndPass[name] = password;
                
                line = Console.ReadLine();
            }

            line = Console.ReadLine();
            var unsuccessful = 0;

            while (line != "end")
            {
                var tokens = line.Split(' ');
                var name = tokens[0];
                var password = tokens[2];
         
                if (!nameAndPass.ContainsKey(name) || nameAndPass[name] != password)
                {
                    Console.WriteLine($"{name}: login failed");
                    unsuccessful++;
                }
                else
                {
                    Console.WriteLine($"{name}: logged in successfully");
                }
                line = Console.ReadLine();
            }
            Console.WriteLine($"unsuccessful login attempts: {unsuccessful}"); 
        }
    }
}
