using System;

namespace Data_Types
{
    public class SumOfDigits
    {
        public static void Main()
        {
            int numbersCount = int.Parse(Console.ReadLine());
            int firstDigit = 0;
            int secondDigit = 0;
            var currentNumber = 0;

            Console.WriteLine(1233 % 10);
            for (int i = 1; i <= numbersCount; i++)
            {
                currentNumber = i;
                firstDigit = currentNumber / 10;
                secondDigit = currentNumber % 10;

                int totalSum = firstDigit + secondDigit;

                var specialNumber = totalSum == 5 || totalSum == 7 || totalSum == 11;

                if (specialNumber == true)
                {
                    Console.WriteLine($"{i} -> {specialNumber}");
                }
                else if (specialNumber == false)
                {
                    Console.WriteLine($"{i} -> {specialNumber}");
                }
            }
        }
    }
}
