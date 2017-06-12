/*
  Write a program that reads 3 numbers (separated by whitespace): an integer a (0 ≤ a ≤ 2222), 
  a floating-point b and a floating-point c and prints them in 4 virtual columns on the console. 
  Each column should have a width of 10 characters. The number a should be printed in hexadecimal, 
  left aligned; then the number a should be printed in binary form, padded with zeroes (if it is 
  bigger than 10 bits remove the least significant ones), then the number b should be printed with 
  2 digits after the decimal point, right aligned; the number c should be printed with 3 digits 
  after the decimal point, left aligned.
*/

using System;

namespace _3.Formatting_Numbers
{
    class FormatingNum
    {
        static void Main(string[] args)
        {
            var inputNumbers = Console.ReadLine().Split(new[] { ' ', '\t'}, StringSplitOptions.RemoveEmptyEntries);
            var numberA = int.Parse(inputNumbers[0]);
            var numberB = double.Parse(inputNumbers[1]);
            var numberC = double.Parse(inputNumbers[2]);

            var numberAinHEX = $"{numberA:X}";
            var formatedNumberB = $"{numberB:f2}";
            var formatedNumberC = $"{numberC:f3}";
            var numberAinBinary = $"{Convert.ToString(numberA, 2)}";

            if (numberAinBinary.Length > 10)
            {
                numberAinBinary = numberAinBinary.Substring(0, 10);
            }

            Console.Write("|{0}", numberAinHEX.PadRight(10, ' '));
            Console.Write("|{0}", numberAinBinary.PadLeft(10, '0'));
            Console.Write("|{0}", formatedNumberB.PadLeft(10, ' '));
            Console.WriteLine("|{0}", formatedNumberC.PadRight(10, ' ') + "|");
        }
    }
}
