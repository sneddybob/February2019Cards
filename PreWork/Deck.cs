using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace February2019Cards
{
    public class Deck
    {
        //internal static string[] deck;

        //This is a special type of method called a constructor.
        //it is run every time you create a deck of cards
        public Deck()
        {
            string[] suits = { "Spades", "Clubs", "Hearts", "Diamonds" };
            string[] values = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };
            Cards = new Card[52];
            for (int i = 0; i < suits.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    Cards[(i * values.Length) + j] = new Card(suits[i], values[j]);

                }
            }
        }

        public Card[] Cards { get; private set; }

        public void Shuffle()
        {
            Random rng = new Random();
            for (int i = 0; i < this.Cards.Length * 100; i++)
            {

                int position1 = rng.Next(0, this.Cards.Length);
                int position2 = rng.Next(0, this.Cards.Length);
                Card temp = this.Cards[position1];
                this.Cards[position1] = this.Cards[position2];
                this.Cards[position2] = temp;
                


            }
        }
        public void Deal()
        {
            List<Card> hand1 = new List<Card>();
            List<Card> hand2 = new List<Card>();


            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    hand1.Add(Cards[i]);

                }
                else
                {
                    hand2.Add(Cards[i]);
                }
               
            }
            foreach (var item in hand1)
            {
                Console.WriteLine($"Your Hand has a {item}.");
            }
            foreach (var item in hand2)
            {
                Console.WriteLine($"Your Opponent has a {item}.");
            }
        }


        public override string ToString()
        {
            return string.Join(", ", Cards.Select(x => x.ToString()));
        }
        


    }


}
