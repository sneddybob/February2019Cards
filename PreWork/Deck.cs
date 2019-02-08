using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace February2019Cards
{
    public class Deck
    {
        internal static string[] deck;

        //This is a special type of method called a constructor.
        //it is run every time you create a deck of cards
        public Deck()
        {
            string[] suits = { "Spades", "Clubs", "Hearts", "Diamonds" };
            string[] values = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };
            int[] score = new int [52];
            for (int i = 1; i < 14; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    score[i] = i;
                }
            }
            Cards = new Card[52];
            for (int i = 0; i < suits.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    Cards[(i * values.Length) + j] = new Card(suits[i], values[j], score[j]);

                }
            }
        }

        public Card[] Cards { get; set; }

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


            //deal cards
            List<Card> hand1 = new List<Card>();
            List<Card> hand2 = new List<Card>();

            int indexer = 0;
            for (int i = indexer; i < Cards.Length; i++)
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





            // eval card hands


            int yourWins = 0;
            int oppWins = 0;
            int ties = 0;
            int indexpos = 0;
            


            while (indexpos < 26)
            {
                int evalYourCard = hand1[indexpos].Score;
                int evalOppCard = hand2[indexpos].Score;
                if (evalYourCard > evalOppCard)
                {
                    Console.WriteLine($"You have a {hand1[indexpos]} and your Opponent has a {hand2[indexpos]}, you win.");
                    yourWins++;
                    indexpos++;
                }
                else if(evalOppCard == evalYourCard)
                {
                    Console.WriteLine($"You have a {hand1[indexpos]} and your Opponent has a {hand2[indexpos]}, you Tie.");
                    ties++;
                    indexpos++;
                }
                else
                {
                    Console.WriteLine($"You have a {hand1[indexpos]} and your Opponent has a {hand2[indexpos]}, you Lose.");
                    oppWins++;
                    indexpos++;
                }
                
                Console.WriteLine($"These are your Wins: {yourWins}.");
                Console.WriteLine($"These are your Opponent's Wins: {oppWins}.");
                Console.WriteLine($"These are your ties: {ties}.");
                

            }
            if (yourWins > oppWins)
            {
                Console.WriteLine("Congrats you won!");
            }
            else
            {
                Console.WriteLine("Sorry you lost!");
            }
        }

        public override string ToString()
        {
            return string.Join(", ", Cards.Select(x => x.ToString()));
        }
        


    }


}
