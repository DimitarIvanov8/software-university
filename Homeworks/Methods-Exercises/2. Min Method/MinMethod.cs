using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Min_Method
{
    class MinMethod
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            var smallestNum = GetMin(firstNum, secondNum, thirdNum);
            Console.WriteLine(smallestNum);
        }

        static int GetMin(int firstNum, int secondNum, int thirdNum)
        {
            int smaller1;
            int smaller2 = thirdNum;

            var twoSmallest = (firstNum < secondNum) ? smaller1 = firstNum : smaller1 = secondNum;
            var smallestNum = Math.Min(smaller1, smaller2);
            return smallestNum;
        }
    }
}
