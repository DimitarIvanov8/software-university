namespace p01_CardSuit
{
    using System;
    using Attributes;
    using Enums;
    using Models;

    public class StartUp
    {
        public static void Main()
        {
            //P01_CardSuit();
            //P02_CardRank();
            //P03_CardPower();
            //P05_CardCompare();
            P06_PrintAttribute();
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

        public static void P05_CardCompare()
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

        public static void P06_PrintAttribute()
        {
            string input = Console.ReadLine();
            Type type = null;

            if (input== "Rank")
            {
                //type = typeof(Rank);
                PrintAttribute(typeof(Rank));
            }
            else if (input == "Suit")
            {
                //type = typeof(Suit);
                PrintAttribute(typeof(Suit));
            }
        }

        public static void PrintAttribute(Type type)
        {
            var customAttributes = type.GetCustomAttributes(false);
            foreach (TypeAttribute customAttribute in customAttributes)
            {
                Console.WriteLine(customAttribute);
            }
        }
    }
}
