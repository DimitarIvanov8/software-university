using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greater_of_two_values
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine();

            switch (type)
            {
                case "int":
                    var int1 = int.Parse(Console.ReadLine());
                    var int2 = int.Parse(Console.ReadLine());

                    var greaterNum = GetMax(int1, int2);

                    Console.WriteLine(greaterNum);
                    break;

                case "char":
                    var char1 = char.Parse(Console.ReadLine());
                    var char2 = char.Parse(Console.ReadLine());

                    var greaterChar = GetMax(char1, char2);

                    Console.WriteLine(greaterChar);
                    break;

                case "string":
                    var string1 = Console.ReadLine();
                    var string2 = Console.ReadLine();

                    var greaterString = GetMax(string1, string2);

                    Console.WriteLine(greaterString);
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;
            }
        }
        //int
        static int GetMax(int int1, int int2)
        {
            if (int1 > int2)
            {
                return int1;
            }
            else
            {
                return int2;
            }
        }

        //char
        static char GetMax(char char1, char char2)
        {
            if (char1.CompareTo(char2) >= 0)
            {
                return char1;
            }
            else
            {
                return char2;
            }
        }

        //string
        static string GetMax(string string1, string string2)
        {
            if (string1.CompareTo(string2) >= 0)
            {
                return string1;
            }
            else
            {
                return string2;
            }
        }
    }
}
