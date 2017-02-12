using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Phone
{
    class Phone
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ');

            var names = Console.ReadLine().Split(' ');

            bool done = false;

            do
            {
                var currentName = Console.ReadLine();

                for (int i = 0; i < names.Length; i++)
                {
                    int oddOrEvenSeconds = 0;
                    var currentNumber = "";

                    if (currentName == "call " + names[i] || currentName == "call " + numbers[i]) //call name or number
                    {
                        currentNumber = numbers[i];

                        string onlyDigits = ConvertNumberToDigits(currentNumber); //Calling convert number to digits Method

                        oddOrEvenSeconds = FindOddOrEvenSumOfDigits(onlyDigits); //Calling OddOrEven Method

                        if (currentName == "call " +  numbers[i])
                        {
                            Console.WriteLine($"calling {names[i]}...");
                        }
                        else if (currentName == "call " + names[i])
                        {
                            Console.WriteLine($"calling {numbers[i]}..."); ;
                        }
                       
                        if (oddOrEvenSeconds % 2 == 0) //call
                        {
                            var timespan = TimeSpan.FromSeconds(oddOrEvenSeconds);
                            Console.WriteLine("call ended. duration: " + timespan.ToString(@"mm\:ss"));
                        }
                        else
                        {
                            Console.WriteLine("no answer");
                        }
                    }
                    else if (currentName == "message " + numbers[i] || currentName == "message " + names[i])  //message
                    {
                        currentNumber = numbers[i];

                        string onlyDigits = ConvertNumberToDigits(currentNumber); //Calling convert number to digits Method

                        oddOrEvenSeconds = FindOddOrEvenSumOfDigits(onlyDigits);

                        if (currentName == "message " + names[i])
                        {
                            Console.WriteLine($"sending sms to {numbers[i]}...");
                        }
                        else if (currentName == "message " + numbers[i])
                        {
                            Console.WriteLine($"sending sms to {names[i]}...");
                        }

                        if (oddOrEvenSeconds % 2 == 0) //meet me there
                        {
                            Console.WriteLine("meet me there");
                        }
                        else //busy
                        {
                            Console.WriteLine("busy");
                        }
                    }
                    oddOrEvenSeconds = 0;
                }

                if (currentName == "done")
                {
                    done = true;
                }
            } while (done == false);
        }

        static int FindOddOrEvenSumOfDigits(string onlyDigits)
        {
            int[] currentNumArr = new int[onlyDigits.Length];
            var oddOrEvenSeconds = 0;

            for (int j = 0; j < onlyDigits.Length; j++)
            {
                currentNumArr[j] = int.Parse(onlyDigits[j].ToString());
                oddOrEvenSeconds += currentNumArr[j]; //summing digits
            }
            return oddOrEvenSeconds;
        }

        static string ConvertNumberToDigits(string number)
        {
            var onlyDigits = new StringBuilder();

            for (int i = 0; i < number.Length; i++)
            {
                if (char.IsDigit(number[i]))
                {
                    onlyDigits.Append(number[i]);
                }
            }
            return $"{onlyDigits}";
        }
    }
}
