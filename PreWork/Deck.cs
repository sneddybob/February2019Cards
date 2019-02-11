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

            for (int i = 0; i < 10; i++)
            {
                if (i%2 ==0)
                {
                    hand1.Add(Cards[i]);

                }
                else
                {
                    hand2.Add(Cards[i]);

                }
            }
                
             List<Card> sortedH1 = hand1.OrderByDescending(x=>x.Score).ToList();
            
             List<Card> sortedH2 = hand2.OrderByDescending(x => x.Score).ToList();

                List<int> hand1Values = new List<int>();
                List<string> hand1Suits = new List<string>();
                List<int> hand1Elem = new List<int>();
            foreach (var item in sortedH1)
            {
                hand1Elem.Add(item.Score);
            }
            int h1Counter = 0;
            for (int i = 0; i < 4; i++)
            {
                if(hand1Elem[i] == hand1Elem[i+1])
                {
                    h1Counter++;
                }
            }
            foreach (var item in sortedH1)
            {
                if (!hand1Suits.Contains(item.Suit))
                {
                    hand1Suits.Add(item.Suit);
                }
            }
            foreach (var item in sortedH1)
            {
                if (!hand1Values.Contains(item.Score))
                { 
                    hand1Values.Add(item.Score);
                }
            }

                List<int> hand2Values = new List<int>();
                List<string> hand2Suits = new List<string>();
                List<int> hand2Elem = new List<int>();
            foreach (var item in sortedH2)
            {
                hand2Elem.Add(item.Score);
            }
            int h2Counter = 0;
            for (int i = 0; i < hand2Elem.Count-1; i++)
            {
                if (hand2Elem[i] == hand2Elem[i + 1])
                {
                    h2Counter++;
                }
            }
            foreach (var item in sortedH2)
            {
                if (!hand2Suits.Contains(item.Suit))
                {
                    hand2Suits.Add(item.Suit);
                }
            }
            foreach (var item in sortedH2)
            {
                if (!hand2Values.Contains(item.Score))
                {
                    hand2Values.Add(item.Score);
                }
            }

            
            int yourHandVal = hand1Elem[0];
            int oppHandVal = hand2Elem[0];
            //for straight flush
            if (hand1Suits.Count == 1 && (hand1Values[0]+13) - 4 == hand1Values[4]+13)
            {
                yourHandVal = 1000+hand1Values[0];
            }
            if (hand2Suits.Count == 1 && (hand2Values[0]+13) - 4 == hand2Values[4]+13)
            {
                oppHandVal = 1000 + hand2Values[0];
            }
            
            //for four of a kind

            if (hand1Suits.Count == 4 && hand1Values.Count == 2 && h1Counter == 4)
            {
                yourHandVal = 900 + hand1Values[1];
            }

            if (hand2Suits.Count == 4 && hand2Values.Count == 2 && h2Counter == 4)
            {
                oppHandVal = 900 + hand2Values[1];
            }

            // for fullhouse
            if (hand1Suits.Count == 4 && hand1Values.Count == 2 && h1Counter == 3)
            {
                yourHandVal = 800 + hand1Values[0];
            }

            if (hand2Suits.Count == 4 && hand2Values.Count == 2 && h2Counter == 3)
            {
                oppHandVal = 800 + hand2Values[0];
            }
            //for flush
            if (hand1Suits.Count == 1)
            {
                yourHandVal = 700 + hand1Values[0];
            }

            if (hand2Suits.Count == 1)
            {
                oppHandVal = 700 + hand2Values[0];
            }
            //for straight
            if ((hand1Values[0]+13) - 4 == hand1Values[4]+13)
            {
                yourHandVal = 600 + hand1Values[0];
            }
            if ((hand2Values[0]+13) - 4 == hand2Values[4]+13)
            {
                oppHandVal = 600 + hand2Values[0];
            }

            //for thrre of a kind
            if (hand1Values.Count == 3 && h1Counter == 3)
            {
                yourHandVal = 500 + hand1Values[2];
            }
            if (hand2Values.Count == 3 && h2Counter == 3)
            {
                oppHandVal = 500 + hand2Values[2];
            }

            //for two pair
            if (hand1Values.Count == 3 && h1Counter == 2)
            {
                yourHandVal = 400 + hand1Values[1];
            }
            if (hand2Values.Count == 3 && h2Counter == 2)
            {
                oppHandVal = 400 + hand2Values[1];
            }

            //for pair
            if (h1Counter == 2)
            {
                for (int i = 0; i < 6 ; i++)
                {
                    if (hand1Elem[i] == hand1Elem[i + 1])
                    {
                        yourHandVal += hand1Elem[i];
                    }
                }
            }

            if (h2Counter == 2)
            {
                for (int i = 0; i < 6; i++)
                {
                    if (hand2Elem[i] == hand2Elem[i + 1])
                    {
                        oppHandVal += hand2Elem[i];
                    }
                }
            }
            


            Console.WriteLine($"You have:\n{sortedH1[indexpos]}\n{sortedH1[indexpos + 1]}\n{sortedH1[indexpos + 2]}\n" +
             $"{sortedH1[indexpos + 3]}\n{sortedH1[indexpos + 4]}\nYour hand value is: {yourHandVal}.");
            Console.WriteLine($"\nYour Opponent has:\n{sortedH2[indexpos]}\n{sortedH2[indexpos + 1]}\n{sortedH2[indexpos + 2]}\n" +
            $"{sortedH2[indexpos + 3]}\n{sortedH2[indexpos + 4]}\nTheir hand value is: {oppHandVal}.");
            if (yourHandVal > oppHandVal)
            {
                Console.WriteLine("\nYou won!");
            }
            if (yourHandVal < oppHandVal)
            {
                Console.WriteLine("\nYou Lost!");
            }
            if (yourHandVal == oppHandVal)
            {
                Console.WriteLine("\nYou Tied!");
            }
        }
        }
    


}
