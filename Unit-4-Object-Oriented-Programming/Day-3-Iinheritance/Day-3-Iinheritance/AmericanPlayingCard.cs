using Day_3_Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3_Iinheritance
{
    // This will be asubclass of a PlayingCard and will add what an american playing card needs that differs from a generic card
    internal class AmericanPlayingCard : PlayingCard // Indicate playing card is our base class
    {
        // NO data in the subclass
        // NO methods other than the constructor
        // We get access to all the data and methods in the base class PlayingCard

        // 3-arg constructor for an AmericanPlayingCard
        // it must call the base() to initialize the base class with any values it gets when its instantiated
        public AmericanPlayingCard(int theValue, string theSuit, string theColor) : base(theValue,theSuit,theColor) // Pass all the data to the base class ctor
        {}


    }
}
