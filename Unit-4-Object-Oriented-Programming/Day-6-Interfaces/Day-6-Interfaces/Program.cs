using System;
using System.Diagnostics.Eventing.Reader;
using GeneralPurposeFunctions;

namespace Day_6_Interfaces
{
    internal class Program
    {
        private static CommonlyUsedFunctions generalFuncs = new CommonlyUsedFunctions();

        static void Main(string[] args)
        {
            generalFuncs.WriteSeparatorLine("Welcome to our Deck of Cards Example!");

            generalFuncs.WriteSeparatorLine("Instantiating and displaying a deck of cards without Jokers");
            CardDeck deckOfCards = new CardDeck();
            deckOfCards.Shuffle();

            PokerHand aPokerHand = new PokerHand();

            for (int i = 0;i < PokerHand.NUMBER_CARDS_IN_HAND; i++)
            {
                aPokerHand.AddCard(deckOfCards.DealACard());
            }
            aPokerHand.AddCard(new AmericanPlayingCard(13, "Spades"));

           aPokerHand.ShowHand();

            generalFuncs.WriteSeparatorLine("Remove 3rd card and add king of spades");
            aPokerHand.RemoveCard(aPokerHand.GetCardAtPosition(3));
            aPokerHand.AddCard(new AmericanPlayingCard(13, "Spades"));

            aPokerHand.ShowHand();

            generalFuncs.PauseProgram();         
            aPokerHand.ThrowInHand();
        
            deckOfCards.ShowDeck();
            deckOfCards.Count();

            generalFuncs.WriteSeparatorLine("Shuffling and displaying a deck of cards");
            deckOfCards.Shuffle();
            deckOfCards.ShowDeck();
            deckOfCards.Count();

            generalFuncs.WriteSeparatorLine("Instantiating and displaying a deck of cards WITH Jokers");
            CardDeck deckOfCards2 = new CardDeck(true);
            deckOfCards2.ShowDeck();
            deckOfCards2.Count();

            generalFuncs.WriteSeparatorLine("Deal 5 cards from deck without Jokers");

            for (int i = 0; i < 5; i++)
            {
                PlayingCard card = deckOfCards.DealACard();

                if (card == null)
                {
                    Console.WriteLine("!!!! Uh-oh - No cards left in current deck, getting new one !!!!");
                    deckOfCards = new CardDeck();
                    deckOfCards.Shuffle();
                    card = deckOfCards.DealACard();
                } 
                card.ShowCard();
            }

            Console.WriteLine($"# cards left in Deck: {deckOfCards.Count()}");

            generalFuncs.WriteSeparatorLine("Thanks for visiting our Deck of Cards Example!");
            generalFuncs.PauseProgram();

        }
    }
}
