using System;
using System.Linq;

namespace _05.Decode_Radio_Frequencies
{
    class DecodeRadioFreq
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ', '.')
                .Select(int.Parse)
                .ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                numbers.Remove(0);
            }         
            var charRepresentation = new string[numbers.Count];
            var currentChar = ' ';

            for (int i = 0, j = 1, k = 0; k < numbers.Count / 2; i += 2, j += 2, k++)
            {
                currentChar = (char)numbers[i];
                charRepresentation[k] = currentChar.ToString();
                currentChar = (char)numbers[j];
                charRepresentation[numbers.Count - 1 - k] = currentChar.ToString();

                if (k == 0) //mid element
                {
                    currentChar = (char)numbers.Last();
                    charRepresentation[charRepresentation.Length / 2] = currentChar.ToString();
                }
            }
            Console.WriteLine(String.Join("",charRepresentation));           
        }
    }
}
