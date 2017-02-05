using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.From_Terabytes_to_Bits
{
    class TerabyteToBits
    {
        static void Main(string[] args)
        {
            decimal input = decimal.Parse(Console.ReadLine());

            long terabyteToBit = 8796093022208;
            decimal transferToBits = input * terabyteToBit;
            Console.WriteLine(Math.Round(transferToBits));
        }
    }
}
