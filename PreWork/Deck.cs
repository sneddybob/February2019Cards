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
            int[] score = new int[52];
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
        public override string ToString()
        {
            return string.Join(", ", Cards.Select(x => x.ToString()));
        }

        //public void Deal()
        //{


        //    //deal cards
        //    List<Card> hand1 = new List<Card>();
        //    List<Card> hand2 = new List<Card>();

        //    int indexer = 0;
        //    for (int i = indexer; i < Cards.Length; i++)
        //    {
        //        if (i % 2 == 0)
        //        {
        //            hand1.Add(Cards[i]);

        //        }
        //        else
        //        {
        //            hand2.Add(Cards[i]);
        //        }

        //    }





        // eval card hands


        //int yourWins = 0;
        //int oppWins = 0;
        //int ties = 0;
        //int indexpos = 0;


        //this is for war
        //while (indexpos < 26)
        //{
        //    int evalYourCard = hand1[indexpos].Score;
        //    int evalOppCard = hand2[indexpos].Score;
        //    if (evalYourCard > evalOppCard)
        //    {
        //        Console.WriteLine($"You have a {hand1[indexpos]} and your Opponent has a {hand2[indexpos]}, you win.");
        //        yourWins++;
        //        indexpos++;
        //    }
        //    else if(evalOppCard == evalYourCard)
        //    {
        //        Console.WriteLine($"You have a {hand1[indexpos]} and your Opponent has a {hand2[indexpos]}, you Tie.");
        //        ties++;
        //        indexpos++;
        //    }
        //    else
        //    {
        //        Console.WriteLine($"You have a {hand1[indexpos]} and your Opponent has a {hand2[indexpos]}, you Lose.");
        //        oppWins++;
        //        indexpos++;
        //    }

        //    Console.WriteLine($"These are your Wins: {yourWins}.");
        //    Console.WriteLine($"These are your Opponent's Wins: {oppWins}.");
        //    Console.WriteLine($"These are your ties: {ties}.");


        //}
        //if (yourWins > oppWins)
        //{
        //    Console.WriteLine("Congrats you won!");
        //}
        //else
        //{
        //    Console.WriteLine("Sorry you lost!");
        //}
        //this is for 5 card stud
        // while (indexpos< 21)
        //    {
        //        int evalYourHand = hand1[indexpos].Score + hand1[indexpos+1].Score + hand1[indexpos+2].Score 
        //            + hand1[indexpos+3].Score + hand1[indexpos +4].Score;
        //        int evalOppHand = hand2[indexpos].Score + hand2[indexpos + 1].Score + hand2[indexpos + 2].Score 
        //            + hand2[indexpos+3].Score + hand2[indexpos+4].Score;


        //        if (evalYourHand > evalOppHand)
        //        {
        //            Console.WriteLine($"You have a {hand1[indexpos]}, a {hand1[indexpos+1]}, a {hand1[indexpos+2]}, " +
        //                $"a {hand1[indexpos+3]}, and a {hand1[indexpos+4]} and your Opponent has a {hand2[indexpos]}, " +
        //                $"a {hand2[indexpos + 1]}, a {hand2[indexpos + 2]}, a {hand2[indexpos + 3]}, and a {hand2[indexpos+4]} you win.");

        //            yourWins++;
        //            indexpos+=5;
        //        }
        //        else if(evalOppHand == evalYourHand)
        //        {
        //            Console.WriteLine($"You have a {hand1[indexpos]}, a {hand1[indexpos + 1]}, a {hand1[indexpos + 2]}, " +
        //                $"a {hand1[indexpos + 3]}, and a {hand1[indexpos + 4]} and your Opponent has a {hand2[indexpos]}, " +
        //                $"a {hand2[indexpos + 1]}, a {hand2[indexpos + 2]}, a {hand2[indexpos + 3]}, and a {hand2[indexpos + 4]} you tie.");
        //            ties++;
        //            indexpos+=5;
        //        }
        //        else
        //        {
        //            Console.WriteLine($"You have a {hand1[indexpos]}, a {hand1[indexpos + 1]}, a {hand1[indexpos + 2]}, " +
        //                $"a {hand1[indexpos + 3]}, and a {hand1[indexpos + 4]} and your Opponent has a {hand2[indexpos]}, " +
        //                $"a {hand2[indexpos + 1]}, a {hand2[indexpos + 2]}, a {hand2[indexpos + 3]}, and a {hand2[indexpos + 4]} you lose.");
        //            oppWins++;
        //            indexpos+=5;
        //        }

        //        Console.WriteLine($"These are your Wins: {yourWins}.");
        //        Console.WriteLine($"These are your Opponent's Wins: {oppWins}.");
        //        Console.WriteLine($"These are your ties: {ties}.");


        //    }
        //    if (yourWins > oppWins)
        //    {
        //        Console.WriteLine("Congrats you won!");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Sorry you lost!");
        //    }

        // this is for 5 card draw

        public void FiveDraw() {
            

            List<Card> hand1 = new List<Card>();
            List<Card> hand2 = new List<Card>();
            int indexpos = 0;
            int hearts = 0;
            int spades = 0;
            int diamonds = 0;
            int clubs = 0;
            int twos = 0;
            int threes = 0;
            int fours = 0;
            int fives = 0;
            int sixes = 0;
            int sevens = 0;
            int eights = 0;
            int nines = 0;
            int tens = 0;
            int jacks = 0;
            int queens = 0;
            int kings = 0;
            int aces = 0;

            for (int i = indexpos; i < 10; i++)
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

            //Determine number of suited cards:
            foreach (var item in hand1)
            {
               if(item.Suit == "Clubs")
                {
                    clubs += 1;
                }
                if (item.Suit == "Hearts")
                {
                    hearts += 1;
                }
                if (item.Suit == "Diamonds")
                {
                    diamonds += 1;
                }
                if (item.Suit == "Spades")
                {
                    spades += 1;
                }
             
            }
            Console.WriteLine("Your hand has {0} Clubs, {1} Hearts, {2} Dimaonds, and {3}, Spades.", clubs, hearts, diamonds, spades);
            foreach (var item in hand2)
            {

            }
            Console.WriteLine($"You have a {hand1[indexpos]}, a {hand1[indexpos + 1]}, a {hand1[indexpos + 2]}, " +
        $"a {hand1[indexpos + 3]}, and a {hand1[indexpos + 4]}");
        }
    }


}
