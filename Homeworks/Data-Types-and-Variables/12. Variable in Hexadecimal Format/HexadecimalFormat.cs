using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Variable_in_Hexadecimal_Format
{
    class HexadecimalFormat
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int convertedString = Convert.ToInt32(input, 16);
            Console.WriteLine(convertedString);
        }
    }
}
