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
            //track suits by hands
            int heartsH1 = 0;
            int spadesH1 = 0;
            int diamondsH1 = 0;
            int clubsH1 = 0;
            int heartsH2 = 0;
            int spadesH2 = 0;
            int diamondsH2 = 0;
            int clubsH2 = 0;
            // track of a kinds by hands
            int twosH1 = 0;
            int threesH1 = 0;
            int foursH1 = 0;
            int fivesH1 = 0;
            int sixesH1 = 0;
            int sevensH1 = 0;
            int eightsH1 = 0;
            int ninesH1 = 0;
            int tensH1 = 0;
            int jacksH1 = 0;
            int queensH1 = 0;
            int kingsH1 = 0;
            int acesH1 = 0;
            int twosH2 = 0;
            int threesH2 = 0;
            int foursH2 = 0;
            int fivesH2 = 0;
            int sixesH2 = 0;
            int sevensH2 = 0;
            int eightsH2 = 0;
            int ninesH2 = 0;
            int tensH2 = 0;
            int jacksH2 = 0;
            int queensH2 = 0;
            int kingsH2 = 0;
            int acesH2 = 0;
            // track winning hands
            int twoPair = 0;
            int threeKind = 0;
            int straight = 0;
            int flush = 0;
            int fullHouse = 0;
            int fourKind = 0;
            int straightFlush = 0;
            int yourHandVal = 0;
            int oppHandVal = 0;
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
                    clubsH1 += 1;
                }
                if (item.Suit == "Hearts")
                {
                    heartsH1 += 1;
                }
                if (item.Suit == "Diamonds")
                {
                    diamondsH1 += 1;
                }
                if (item.Suit == "Spades")
                {
                    spadesH1 += 1;
                }
                if (item.Value == "2")
                {
                    twosH1 += 1;
                }
                if (item.Value == "3")
                {
                   threesH1 += 1;
                }
                if (item.Value == "4")
                {
                    foursH1 += 1;
                }
                if (item.Value == "5")
                {
                    fivesH1 += 1;
                }
                if (item.Value == "6")
                {
                    sixesH1 += 1;
                }
                if (item.Value == "7")
                {
                    sevensH1 += 1;
                }
                if (item.Value == "8")
                {
                    eightsH1 += 1;
                }
                if (item.Value == "9")
                {
                    ninesH1 += 1;
                }
                if (item.Value == "10")
                {
                    tensH1 += 1;
                }
                if (item.Value == "Jacks")
                {
                    jacksH1 += 1;
                }
                if (item.Value == "Queens")
                {
                    queensH1 += 1;
                }
                if (item.Value == "Kings")
                {
                    kingsH1 += 1;
                }
                if (item.Value == "Aces")
                {
                    acesH1 += 1;
                }

            }

            Console.WriteLine($"You have a {hand1[indexpos]}, a {hand1[indexpos + 1]}, a {hand1[indexpos + 2]}, " +
             $"a {hand1[indexpos + 3]}, and a {hand1[indexpos + 4]}");
            Console.WriteLine("Your hand has {0} Clubs, {1} Hearts, {2} Dimaonds, and {3}, Spades.", clubsH1, heartsH1, diamondsH1, spadesH1);

            foreach (var item in hand2)

            {
                if (item.Suit == "Clubs")
                {
                    clubsH2 += 1;
                }
                if (item.Suit == "Hearts")
                {
                    heartsH2 += 1;
                }
                if (item.Suit == "Diamonds")
                {
                    diamondsH2 += 1;
                }
                if (item.Suit == "Spades")
                {
                    spadesH2 += 1;
                }
                if (item.Value == "2")
                {
                    twosH2 += 1;
                }
                if (item.Value == "3")
                {
                    threesH2 += 1;
                }
                if (item.Value == "4")
                {
                    foursH2 += 1;
                }
                if (item.Value == "5")
                {
                    fivesH2 += 1;
                }
                if (item.Value == "6")
                {
                    sixesH2 += 1;
                }
                if (item.Value == "7")
                {
                    sevensH2 += 1;
                }
                if (item.Value == "8")
                {
                    eightsH2 += 1;
                }
                if (item.Value == "9")
                {
                    ninesH2 += 1;
                }
                if (item.Value == "10")
                {
                    tensH2 += 1;
                }
                if (item.Value == "Jacks")
                {
                    jacksH2 += 1;
                }
                if (item.Value == "Queens")
                {
                    queensH2 += 1;
                }
                if (item.Value == "Kings")
                {
                    kingsH2 += 1;
                }
                if (item.Value == "Aces")
                {
                    acesH2 += 1;
                }
              
            }
            
            Console.WriteLine($"Your Opponent has a {hand2[indexpos]}, a {hand2[indexpos + 1]}, a {hand2[indexpos + 2]}, " +
            $"a {hand2[indexpos + 3]}, and a {hand2[indexpos + 4]}");
            Console.WriteLine("Your Opponent has {0} Clubs, {1} Hearts, {2} Dimaonds, and {3}, Spades.", clubsH2, heartsH2, diamondsH2, spadesH2);
        }
    }


}
