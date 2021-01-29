using System;
using System.Collections.Generic;


namespace AllCardsOnDeckCS2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare Variables
            var deck = new List<string>();
            var suit = new string[] { "\u2660", "\u2663", "\u2665", "\u2666" };
            var rank = new string[] { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };

            // Create Deck
            // TODO: Create the loop structure 
            for (var suitIndex = 0; suitIndex < suit.Length; suitIndex++)
            {
                for (var rankIndex = 0; rankIndex < rank.Length; rankIndex++)
                {
                    var cardSuit = suit[suitIndex];
                    var cardRank = rank[rankIndex];
                    deck.Add($"{cardRank}{cardSuit}");
                    Console.WriteLine($"{cardRank}{cardSuit}");
                }
            }



            Console.WriteLine("deck built");

        }
    }
}
