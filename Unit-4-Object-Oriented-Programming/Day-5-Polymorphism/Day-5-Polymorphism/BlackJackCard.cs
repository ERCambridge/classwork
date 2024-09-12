﻿using System;

namespace Day_5_Polymorphism
{
    // This is a subclass of an AmericanPlayingCard
    // and will add what an BlackJackCard needs that differs from an AmericanPlayingCard:
    //
    //    1. When comparing card values, suits and colors don't matter
    //            sub-class  is-a  base-class 
    public class BlackJackCard : AmericanPlayingCard
    {
    /*********************************************************************
     * Data members (attributes, properties, variables)
     *
     * No additional data members are required for this sub-class
     * (All super-class variables are available to the sub-class
     *********************************************************************/

    /**********************************************************************
     * Constructors - Initialize objects instantiated for the class
     *
     * Since this sub--class has no additional data to add to the base-class
     *
     * All it needs to do is receives the values required to initialize the
     *     base-class object and nothing more
     **********************************************************************/

    public BlackJackCard(int value, string suit) : base(value, suit) { }

    /****************************************************************************************
     * Helper Methods for class - support class and manipulate data on behalf of the class
     ***************************************************************************************/

        /****************************************************************************************
         * Overrides - Replace unwanted behavior of base class with behaviors for the subclass
         *
         * Note: if .Equals() is overriden it is good practice to also override GethashCode()
         *          so equal objects appear equal to C# regardless of which it uses
         ***************************************************************************************/

        //---------------------------------------------------------------------
        // Override the default Equals() method: public bool Equals(object obj)
        // 
        // Equals() returns true to data members of two objects are equal
        //---------------------------------------------------------------------
        public override bool Equals(Object anObject)
    {
        if (anObject.GetType() != this.GetType())  // If types differ...
        {
            return false;                          //     they can't be equal
        }

        if (anObject == this)                      // if the same object...
        {
            return true;                           //    they must be equal
        }

        // Create a sub-class object from the generic object passed to the method
        BlackJackCard secondCard = anObject as BlackJackCard;  // Note alternate casting syntax

        if(CardValue == secondCard.CardValue)      // If card value matches
        {
            return true;                           //    they ar equal
        }
        return false;                              // if they are not equal return false

        // Alternate solution
        // return CardValue == secondCard.CardValue;
    }

        // Display an object of the class
        public override void ShowCard()
         {
          Console.WriteLine($"AmericanPlayingCard: Value: {GetCardValueName()} ({base.CardValue}), Suit: {base.CardSuit}, Color: {base.CardColor}");
         }

        //---------------------------------------------------------------------
        // Override the default GetHashCode method:  public int GetHashCode()
        //
        // GetHashCode() should return a unique value generated by the member data
        //
        // GetHashCode() is used by C# in certain situations to determine of two
        //                  objects are equal and when inserting an object in
        //                  a hash-based collection e.g. HashSet, HashTable. 
        //-------------------------------------------------------------------------
        public override int GetHashCode()
        {
            // A HashCode may be generated determining the sum of:
            //
            //     numeric values * prime-number
            //     string, bool, objects - Use System GetHashCode method
            //
            // Since the only data member this subclass cares about is CardValue
            //       only CardValue is used in the .Equals() and calculating of HashCode
            return CardValue * 17;
        }

    }
}