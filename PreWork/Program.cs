using System;
using System.Linq;
using February2019Cards;

namespace February2019Cards
{
    public class Program
    {
        public object Deck { get; private set; }

        public static void Main(string[] args)
        {
            //Here's a comment.
            //Here's another comment.
            //Here's a third comment.
            //Here is Bob's comment.
            Deck deck = new Deck();


            deck.Shuffle();

            deck.Deal();

            
            //Console.WriteLine($"This is the first DECK: {deck}");

            Deck otherDeck = new Deck();

            otherDeck.Shuffle();

            //Console.WriteLine($"This is the second DECK: {otherDeck}");

           // deck.Hand();

           // Console.WriteLine(deck);

            Console.ReadLine();

            

           
        }
        

    }
}