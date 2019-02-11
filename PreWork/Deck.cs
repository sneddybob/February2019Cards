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
            int pairH1 = 0;
            int pairH2 = 0;
            int twoPairH1 = 0;
            int twoPairH2 = 0;
            int threeKindH1 = 0;
            int threeKindH2 = 0;
            int straightH1 = 0;
            int straightH2 = 0;
            int flushH1C = 0;
            int flushH2C = 0;
            int flushH1H = 0;
            int flushH2H = 0;
            int flushH1D = 0;
            int flushH2D = 0;
            int flushH1S = 0;
            int flushH2S = 0;      
            int fullHouse = 0;
            int fourKind = 0;
            int straightFlush = 0;
            //track hands' values
            

            for (int i = 11; i < 21; i++)
            {
                if (i < 16)
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

            //Determine number of suited cards:
            foreach (var item in sortedH1)
            {
               if(item.Suit == "Clubs")
                {
                    clubsH1 += 1;
                    flushH1C++;
                }
                if (item.Suit == "Hearts")
                {
                    heartsH1 += 1;
                    flushH1H++;
                }
                if (item.Suit == "Diamonds")
                {
                    diamondsH1 += 1;
                    flushH1D++;
                }
                if (item.Suit == "Spades")
                {
                    spadesH1 += 1;
                    flushH1S++;
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
            
            
            //Console.WriteLine("Your hand has {0} Clubs, {1} Hearts, {2} Dimaonds, and {3}, Spades.", clubsH1, heartsH1, diamondsH1, spadesH1);

            foreach (var item in sortedH2)

            {
                if (item.Suit == "Clubs")
                {
                    clubsH2 += 1;
                    flushH2C++;
                }
                if (item.Suit == "Hearts")
                {
                    heartsH2 += 1;
                    flushH2H++;
                }
                if (item.Suit == "Diamonds")
                {
                    diamondsH2 += 1;
                    flushH2D++;
                }
                if (item.Suit == "Spades")
                {
                    spadesH2 += 1;
                    flushH2S++;
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
            
            
            //Console.WriteLine("Your Opponent has {0} Clubs, {1} Hearts, {2} Dimaonds, and {3}, Spades.", clubsH2, heartsH2, diamondsH2, spadesH2);
            int yourHandVal = sortedH1[0].Score;
            int oppHandVal = sortedH2[0].Score;

            // this is for a straight flush

            if (flushH1C == 5 || flushH1D == 5 || flushH1H == 5 || flushH1S == 5 && sortedH1[0].Score - 4 == sortedH1[4].Score)
            {
                yourHandVal = 1500 + sortedH1[0].Score;
            }
            if (flushH2C == 5 || flushH2D == 5 || flushH2H == 5 || flushH2S == 5 && sortedH2[0].Score - 4 == sortedH2[4].Score)
            {
                oppHandVal = 1500 + sortedH2[0].Score;
            }
            // this is for a flush

            else if (flushH1C == 5 || flushH1D == 5 || flushH1H == 5 || flushH1S == 5)
            {
                yourHandVal = 500 + sortedH1[0].Score;
            }
            else if (flushH2C == 5 || flushH2D == 5 || flushH2H == 5 || flushH2S == 5)
            {
                oppHandVal = 500 + sortedH2[0].Score;
            }
            //this is for a straight
            else if (sortedH1[0].Score + 5 == sortedH1[4].Score)
            {
                yourHandVal = 400 + sortedH1[0].Score;
            }
            else if (sortedH2[0].Score + 5 == sortedH2[4].Score)
            {
                oppHandVal = 400 + sortedH2[0].Score;
            }



            //this is for 3 of a kind
            else if (twosH1 == 3 || threesH1 == 3 || foursH1 == 3 || fivesH1 == 3 || sixesH1 == 3 || sevensH1 == 3 || eightsH1 == 3
                || ninesH1 == 3 || tensH1 == 3 || jacksH1 == 3 || queensH1 == 3 || kingsH1 == 3 || acesH1 == 3)
            {
                yourHandVal = 100+sortedH1[0].Score;
            }
            else if (twosH2 == 3 || threesH2 == 3 || foursH2 == 3 || fivesH2 == 3 || sixesH2 == 3 || sevensH2 == 3 || eightsH2 == 3
                || ninesH2 == 3 || tensH2 == 3 || jacksH2 == 3 || queensH2 == 3 || kingsH2 == 3 || acesH2 == 3)
            {
                oppHandVal = 100+sortedH2[0].Score;
            }
            //this is for two pair

            else if ((twosH1 == 2 || threesH1 == 2 || foursH1 == 2 || fivesH1 == 2 || sixesH1 == 2 || sevensH1 == 2 || eightsH1 == 2
                || ninesH1 == 2 || tensH1 == 2 || jacksH1 == 2 || queensH1 == 2 || kingsH1 == 2 || acesH1 == 2) && (twosH1 == 2 || threesH1 == 2 || foursH1 == 2 || fivesH1 == 2 || sixesH1 == 2 || sevensH1 == 2 || eightsH1 == 2
                || ninesH1 == 2 || tensH1 == 2 || jacksH1 == 2 || queensH1 == 2 || kingsH1 == 2 || acesH1 == 2))
            {
                yourHandVal = 50+sortedH1[0].Score;
            }
            else if ((twosH2 == 2 || threesH2 == 2 || foursH2 == 2 || fivesH2 == 2 || sixesH2 == 2 || sevensH2 == 2 || eightsH2 == 2
                || ninesH2 == 2 || tensH2 == 2 || jacksH2 == 2 || queensH2 == 2 || kingsH2 == 2 || acesH2 == 2) && (twosH2 == 2 || threesH2 == 2 || foursH2 == 2 || fivesH2 == 2 || sixesH2 == 2 || sevensH2 == 2 || eightsH2 == 2
                || ninesH2 == 2 || tensH2 == 2 || jacksH2 == 2 || queensH2 == 2 || kingsH2 == 2 || acesH2 == 2))
            {
                oppHandVal = 50 + sortedH2[0].Score;
            }



            //this is for two of a kind

            else if (twosH1 == 2 || threesH1 == 2 || foursH1 == 2 || fivesH1 == 2 || sixesH1 == 2 || sevensH1 ==2 || eightsH1 == 2
                || ninesH1 == 2 || tensH1 == 2 || jacksH1 == 2 || queensH1 == 2 || kingsH1 ==2 || acesH1 == 2)
            {
                yourHandVal = 25;
            }
            else if (twosH2 == 2 || threesH2 == 2 || foursH2 == 2 || fivesH2 == 2 || sixesH2 == 2 || sevensH2 == 2 || eightsH2 == 2
                || ninesH2 == 2 || tensH2 == 2 || jacksH2 == 2 || queensH2 == 2 || kingsH2 == 2 || acesH2 == 2)
            {
                oppHandVal = 25;
            }
            Console.WriteLine($"You have:\n{sortedH1[indexpos]}\n{sortedH1[indexpos + 1]}\n{sortedH1[indexpos + 2]}\n" +
             $"{sortedH1[indexpos + 3]}\n{sortedH1[indexpos + 4]}\nYour hand value is: {yourHandVal}.");
            Console.WriteLine($"\nYour Opponent has:\n{sortedH2[indexpos]}\n{sortedH2[indexpos + 1]}\n{sortedH2[indexpos + 2]}\n" +
            $"{sortedH2[indexpos + 3]}\n{sortedH2[indexpos + 4]}\nTheir hand value is: {oppHandVal}.");
            if (yourHandVal > oppHandVal )
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
