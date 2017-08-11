namespace p01_CardSuit
{
    using System;
    using Enums;

    public class StartUp
    {
        public static void Main()
        {
            Problem01();
        }

        public static void Problem01()
        {
            string input = Console.ReadLine();
            Console.WriteLine($"{input}:");
            foreach (var item in Enum.GetValues(typeof(Suit)))
            {
                Console.WriteLine($"Ordinal value: {(int)item}; Name value: {item}");
            }
        }
    }
}
