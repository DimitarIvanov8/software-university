namespace p01_CardSuit.Models
{
    using System;
    using Enums;

    public class Card : IComparable<Card>
    {
        public Card(string rank, string suit)
        {
            this.Rank = (Rank)Enum.Parse(typeof(Rank), rank);
            this.Suit = (Suit)Enum.Parse(typeof(Suit), suit);
        }

        public Rank Rank { get; private set; }
        public Suit Suit { get; private set; }

        public int Power
        {
            get
            {
                return ((int)this.Rank + (int)this.Suit); 
            }
        }

        public string Name
        {
            get
            {
                return $"{this.Rank} of {this.Suit}";
            }
        }

        public int CompareTo(Card other)
        {
            if (ReferenceEquals(this, other)) return 0;
            if (ReferenceEquals(null, other)) return 1;
            int suitComparison = this.Suit.CompareTo(other.Suit);
            if (suitComparison != 0) return suitComparison;
            return this.Rank.CompareTo(other.Rank);
        }

        public override string ToString()
        {
            return $"Card name: {this.Name}; Card power: {this.Power}";
        }

        public override bool Equals(object obj)
        {
            //if (obj==null)
            //{
            //    return false;
            //}
            //Card card = obj as Card;
            return (this.CompareTo(obj as Card) == 0);
        }
    }
}