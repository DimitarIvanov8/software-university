namespace p01_CardSuit
{
    using System;
    using Enums;

    public class StartUp
    {
        public static void Main()
        {
            //P01_CardSuit();
            P02_CardRank();
        }

        public static void P01_CardSuit()
        {
            string input = Console.ReadLine();
            Console.WriteLine($"{input}:");
            foreach (var item in Enum.GetValues(typeof(Suit)))
            {
                Console.WriteLine($"Ordinal value: {(int)item}; Name value: {item}");
            }
        }

        public static void P02_CardRank()
        {
            string input = Console.ReadLine();
            Console.WriteLine($"{input}:");
            foreach (var item in Enum.GetValues(typeof(Rank)))
            {
                Console.WriteLine($"Ordinal value: {(int)item}; Name value: {item}");
            }
        }

    }
}
