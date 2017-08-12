namespace p01_CardSuit
{
    using System;
    using Enums;
    using Models;

    public class StartUp
    {
        public static void Main()
        {
            //P01_CardSuit();
            //P02_CardRank();
            //P03_CardPower();
            P05_CardCompareTo();
        }

        public static void P01_CardSuit()
        {
            PrintEnum(typeof(Suit));
            //string input = Console.ReadLine();
            //Console.WriteLine($"{input}:");
            //foreach (var item in Enum.GetValues(typeof(Suit)))
            //{
            //    Console.WriteLine($"Ordinal value: {(int)item}; Name value: {item}");
            //}
        }

        public static void P02_CardRank()
        {
            PrintEnum(typeof(Rank));
            //string input = Console.ReadLine();
            //Console.WriteLine($"{input}:");
            //foreach (var item in Enum.GetValues(typeof(Rank)))
            //{
            //    Console.WriteLine($"Ordinal value: {(int)item}; Name value: {item}");
            //}
        }

        public static void PrintEnum(Type type)
        {
            string input = Console.ReadLine();
            Console.WriteLine($"{input}:");
            foreach (var item in Enum.GetValues(type))
            {
                Console.WriteLine($"Ordinal value: {(int)item}; Name value: {item}");
            }
        }

        public static void P03_CardPower()
        {
            Card card = ReadCard();
            Console.WriteLine(card);
        }

        public static void P05_CardCompareTo()
        {
            Card cardFirst = ReadCard();
            Card cardSecond = ReadCard();

            if (cardFirst.CompareTo(cardSecond) > 0)
            {
                Console.WriteLine(cardFirst);
            }
            else
            {
                Console.WriteLine(cardSecond);
            }


        }

        public static Card ReadCard()
        {
            string rank = Console.ReadLine();
            string suit = Console.ReadLine();
            Card card = new Card(rank, suit);
            return card;
        }

    }
}
