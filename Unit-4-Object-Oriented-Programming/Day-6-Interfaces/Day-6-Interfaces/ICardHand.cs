using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6_Interfaces
{
    // Interface for behaviors/methods a Class wanting to be a CardHand must implement 

    // Interfaces have:
    //  1. no data
    //  2. method signatures of the methods they require 

    public interface ICardHand
    {

        void AddCard(PlayingCard cardToAdd);

        void RemoveCard(PlayingCard cardToRemove);

        void SortHand(string howToSort);

        void ThrowInHand();

        void ShowHand();

    }
}
