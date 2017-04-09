using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Stateless
{
    class Stateless
    {
        static void Main(string[] args)
        {
            var lineFirst = Console.ReadLine();
            string lineSecond = Console.ReadLine();
            while (lineFirst != "collapse" && lineSecond != "collapse")
            {
                while (lineSecond.Length > 0)
                {
                    lineFirst = lineFirst.Replace(lineSecond, "").Trim();
                    if (lineSecond.Length == 1) break;
                    lineSecond = lineSecond.Remove(0, 1).Remove(lineSecond.Length - 2, 1).Trim();

                }
                if (lineFirst.Length == 0)
                {
                    Console.WriteLine("(void)");
                }
                else
                {
                    Console.WriteLine(lineFirst);
                }

                lineFirst = Console.ReadLine();
                lineSecond = Console.ReadLine();
            }
        }
    }
}
