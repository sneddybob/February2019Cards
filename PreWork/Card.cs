using System;
using System.Collections.Generic;
using System.Text;

namespace February2019Cards
{
    public class Card
    {
        public Card(string suit, string value)
        {
            Suit = suit;
            Value = value;
        }

        public string Suit { get; }
        public string Value { get;}


        public override string ToString()
        {
            return $"{Value} of {Suit}";
        }
    }
}
