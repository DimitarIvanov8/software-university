namespace p01_CardSuit
{
    using System;
    using System.Collections.Generic;
    using Attributes;
    using Enums;
    using Models;

    public class StartUp
    {
        private static Card biggest;
        private static string winner;


        public static void Main()
        {
            //P01_CardSuit();
            //P02_CardRank();
            //P03_CardPower();
            //P05_CardCompare();
            //P06_PrintAttribute();
            //P07_PrintDeck();
            P08_CardGame();
        }

        private static void P01_CardSuit()
        {
            PrintEnum(typeof(Suit));
            //string input = Console.ReadLine();
            //Console.WriteLine($"{input}:");
            //foreach (var item in Enum.GetValues(typeof(Suit)))
            //{
            //    Console.WriteLine($"Ordinal value: {(int)item}; Name value: {item}");
            //}
        }

        private static void P02_CardRank()
        {
            PrintEnum(typeof(Rank));
            //string input = Console.ReadLine();
            //Console.WriteLine($"{input}:");
            //foreach (var item in Enum.GetValues(typeof(Rank)))
            //{
            //    Console.WriteLine($"Ordinal value: {(int)item}; Name value: {item}");
            //}
        }

        private static void PrintEnum(Type type)
        {
            string input = Console.ReadLine();
            Console.WriteLine($"{input}:");
            foreach (var item in Enum.GetValues(type))
            {
                Console.WriteLine($"Ordinal value: {(int)item}; Name value: {item}");
            }
        }

        private static void P03_CardPower()
        {
            Card card = ReadCard();
            Console.WriteLine(card);
        }

        private static void P05_CardCompare()
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

        private static Card ReadCard()
        {
            string rank = Console.ReadLine();
            string suit = Console.ReadLine();
            Card card = new Card(rank, suit);
            return card;
        }

        private static void P06_PrintAttribute()
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

        private static void PrintAttribute(Type type)
        {
            var customAttributes = type.GetCustomAttributes(false);
            foreach (TypeAttribute customAttribute in customAttributes)
            {
                Console.WriteLine(customAttribute);
            }
        }

        private static List<Card> GenerateDeck()
        {
            List<Card> deck = new List<Card>();
            foreach (var suit in Enum.GetNames(typeof(Suit)))
            {
                foreach (var rank in Enum.GetNames(typeof(Rank)))
                {
                    deck.Add(new Card(rank,suit));
                }
            }

            return deck;
        }

        private static void P07_PrintDeck()
        {
            List<Card> deck = GenerateDeck();
            foreach (Card card in deck)
            {
                Console.WriteLine(card.Name);
            }
        }

        private static void P08_CardGame()
        {
            string playerOne = Console.ReadLine();
            string playerTwo = Console.ReadLine();

            List<Card> deck = GenerateDeck();
            List<Card> playerOneDeck = new List<Card>();
            List<Card> playerTwoDeck = new List<Card>();

            while (playerOneDeck.Count<5 || playerTwoDeck.Count < 5)
            {
                string[] inParams = Console.ReadLine().Split();
                try
                {
                    Card card = new Card(inParams[0], inParams[inParams.Length-1]);
                    if (deck.Contains(card))
                    {
                        deck.Remove(card);
                        if (playerOneDeck.Count<5)
                        {
                            playerOneDeck.Add(card);
                            WinnerCheck(card, playerOne);
                        }
                        else
                        {
                            playerTwoDeck.Add(card);
                            WinnerCheck(card, playerTwo);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Card is not in the deck.");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("No such card exists.");
                }
            }

            Console.WriteLine($"{winner} wins with {biggest.Name}.");
        }

        public static void WinnerCheck(Card card, string player)
        {
            if (card.CompareTo(biggest)>0)
            {
                biggest = card;
                winner = player;
            }
        }
    }
}
