using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _2.Match_Phone_Number
{
    class MatchPhoneNum
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Regex regex = new Regex(@"^\+359-\d-\d{3}-\d{4}$");
            Regex regexTwo = new Regex(@"^\+359 \d \d{3} \d{4}$");

            while (text != "end")
            {
                if (regex.IsMatch(text) || regexTwo.IsMatch(text))
                {
                    Console.WriteLine(text);
                }

                text = Console.ReadLine();
            }
        }
    }
}
