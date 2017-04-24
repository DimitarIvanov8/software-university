using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Array_Manipulator_2._0
{
    class Version2
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                string[] inputParams = inputLine.Split(' ');
                var command = inputParams[0];

                switch (command)
                {
                    case "exchange":
                        var index = int.Parse(inputParams[1]);
                        array = Exchange(array, index);
                        break;

                    case "max":
                    case "min":
                        var maxOrMin = command; ;
                        var oddOrEven = inputParams[1];
                        FindMaxOrMinOddOrEven(array, maxOrMin, oddOrEven);
                        break;

                    case "first":
                    case "last":
                        var firstOrLast = inputParams[0];
                        var oddOrEvenElement = inputParams[2];
                        var elementCount = int.Parse(inputParams[1]);
                        FindFirstOrLastEvenOrOddElements(array, firstOrLast, oddOrEvenElement, elementCount);
                        break;
                    default: break;
                }

                inputLine = Console.ReadLine();
            }

            Console.WriteLine("[{0}]", string.Join(", ", array));
        }

        private static void FindFirstOrLastEvenOrOddElements(int[] array, string firstOrLast, string oddOrEvenElement, int elementCount)
        {
            if (elementCount > array.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }

            var evenOrOddParity = oddOrEvenElement == "even" ? 0 : 1;
            var evenOrOddElements = array.Where(a => a % 2 == evenOrOddParity).ToArray();

            int[] foundElements;
            if (firstOrLast == "first")
            {
                foundElements = evenOrOddElements
                    .Take(elementCount)
                    .ToArray();

                Console.WriteLine("[{0}]", string.Join(", ", foundElements));
            }
            else if (firstOrLast == "last")
            {
                foundElements = evenOrOddElements
                    .Reverse()
                    .Take(elementCount)
                    .Reverse()
                    .ToArray();

                Console.WriteLine("[{0}]", string.Join(", ", foundElements));
            }
        }

        private static void FindMaxOrMinOddOrEven(int[] array, string maxOrMin, string oddOrEven)
        {
            var evenOrOddElementsParity = oddOrEven == "even" ? 0 : 1;
            var evenOrOddElements = array
                .Where(a => a % 2 == evenOrOddElementsParity)
                .ToArray();

            if (!evenOrOddElements.Any())
            {
                Console.WriteLine("No matches");
                return;
            }

            var maxOrMinElement = maxOrMin == "max" ? evenOrOddElements.Max() : evenOrOddElements.Min();
            var maxOrMinElementIndex = Array.LastIndexOf(array, maxOrMinElement);
            //var arrayToList = evenOrOddElements.ToList(); => then we can use .IndexOf(maxOrMinElement)
            Console.WriteLine(maxOrMinElementIndex);
        }

        private static int[] Exchange(int[] array, int index)
        {
            var isValidIndex = index >= 0 && index < array.Length;

            if (!isValidIndex)
            {
                Console.WriteLine("Invalid index");
                return array;
            }

            var leftPart = array.Take(index + 1);
            var rightPart = array.Skip(index + 1);

            var combinedArray = rightPart.Concat(leftPart).ToArray();

            return combinedArray;
        }
    }
}
