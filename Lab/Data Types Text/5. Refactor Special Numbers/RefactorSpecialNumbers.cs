using System;

namespace _5.Refactor_Special_Numbers
{
    class RefactorSpecialNumbers
    {
        static void Main()
        {
            int numberCount = int.Parse(Console.ReadLine());
            int digitsSum = 0;
            int currentNumber = 0;
            bool isSpecial = false;

            for (int num = 1; num <= numberCount; num++)
            {
                currentNumber = num;
                while (num > 0)
                {
                    digitsSum += num % 10;
                    num = num / 10;
                }
                isSpecial = (digitsSum == 5) || (digitsSum == 7) || (digitsSum == 11);
                Console.WriteLine($"{currentNumber} -> {isSpecial}");
                digitsSum = 0;
                num = currentNumber;
            }
        }
    }
}
