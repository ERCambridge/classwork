using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6_Interfaces
{
    public class PokerHand : ICardHand
    {

        public const int NUMBER_CARDS_IN_HAND = 5;

        private List<PlayingCard> theHand;


        public PokerHand()
        {
            theHand = new List<PlayingCard>();

        }
        public void AddCard(PlayingCard cardToAdd)
        {
            if (theHand.Count != NUMBER_CARDS_IN_HAND)
            {
                theHand.Add(cardToAdd);
            }
            else
            {
                Console.WriteLine("The hand is full card not added");
            }
        }

        public void RemoveCard(PlayingCard cardToRemove)
        {
            theHand.Remove(cardToRemove);
        }

        public void ShowHand()
        {
            foreach(PlayingCard card in theHand) 
            { 
                card.ShowCard();
            }
        }

        public void SortHand(string howToSort)
        {
            throw new NotImplementedException();
        }

        public void ThrowInHand()
        {
            theHand.Clear();
        }

        public PlayingCard GetCardAtPosition(int position)
        { 
            return theHand[position-1];
        }
    }
}
