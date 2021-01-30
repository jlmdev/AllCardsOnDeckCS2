using System;
using System.Collections.Generic;
using System.Linq;

namespace AllCardsOnDeckCS2
{
    class Program
    {
        public static List<string> CreateDeck()
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
                    // Console.WriteLine($"{cardRank}{cardSuit}");
                }
            }
            return deck;
        }

        public static List<string> ShuffleDeck(List<string> cardDeck)
        {
            int numberOfCards = cardDeck.Count();
            var randomNumberGenerator = new Random();

            // Shuffle Algorithm
            for (var rightIndex = numberOfCards - 1; rightIndex > 0; rightIndex--)
            {
                var leftIndex = randomNumberGenerator.Next(rightIndex - 1);
                var leftCard = cardDeck[rightIndex];
                var rightCard = cardDeck[leftIndex];

                // swap values in the deck itself
                cardDeck[rightIndex] = rightCard;
                cardDeck[leftIndex] = leftCard;
            }

            return cardDeck;
        }


        static void Main(string[] args)
        {



            var cardDeck = CreateDeck();

            // Confirm Deck Built
            Console.WriteLine("deck built");

            ShuffleDeck(cardDeck);

            foreach (var card in cardDeck)
            {
                Console.WriteLine(card);
            }


        }
    }
}
