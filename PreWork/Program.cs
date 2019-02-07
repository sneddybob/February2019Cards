using System;
using System.Linq;

namespace February2019Cards
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Here's a comment.
            //Here's another comment.
            //Here's a third comment.
            Deck deck = new Deck();

            deck.Shuffle();
            Console.WriteLine(deck);

            Deck otherDeck = new Deck();
            otherDeck.Shuffle();

            Console.WriteLine(otherDeck);
            Console.ReadLine();
        }
    }
}