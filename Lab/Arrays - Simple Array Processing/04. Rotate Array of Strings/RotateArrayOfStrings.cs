using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Rotate_Array_of_Strings
{
    class RotateArrayOfStrings
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine()
                .Split(
                new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var rotatedArray = new string[words.Length];

            for (int i = 0; i < words.Length - 1; i++)
            {
                rotatedArray[i + 1] = words[i];
            }

            var lastElement = words[words.Length - 1];
            rotatedArray[0] = lastElement;

            Console.WriteLine(String.Join(" ", rotatedArray));
        }
    }
}
