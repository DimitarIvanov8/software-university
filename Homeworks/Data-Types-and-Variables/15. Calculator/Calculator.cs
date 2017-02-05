using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Calculator
{
    class Calculator
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            char sign = char.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            switch (sign) {
                case '+': Console.WriteLine($"{firstNum} + {secondNum} = {firstNum+secondNum}"); break;
                case '-': Console.WriteLine($"{firstNum} - {secondNum} = {firstNum-secondNum}"); break;
                case '*': Console.WriteLine($"{firstNum} * {secondNum} = {firstNum*secondNum}"); break;
                case '/': Console.WriteLine($"{firstNum} / {secondNum} = {firstNum/secondNum}"); break;
                default: Console.WriteLine("Invalid"); break;
            }
        }
    }
}
