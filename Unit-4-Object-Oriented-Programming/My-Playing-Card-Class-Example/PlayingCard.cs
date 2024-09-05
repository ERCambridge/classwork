using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Playing_Card_Class_Example
{
    // This is a class to represent a simple PlayingCard
    // It's in the same namespace as the application and doesn't need to be imported with a using statement

    //A class contains data and methods to operate and manipulate the data
    public class PlayingCard
    {
        // Define instance variables for the class (unique attributes for each object)

        // Instance variables are private to implement Encapsulation
        // (protect data from access outside the class)

        private int cardValue;
        private string cardSuit;
        private string cardColor;

        // To provide access so others can "see" or change data members 
        // We can provide "properties" to do that

        // A property is a public variable to allow access to private data
        // using "getters" and "setters"
        
        // a "getter" will return the value in a data member
        // a "setter" will allow the changing of a data member

        // a property is typically named the same as the variable but in PascalCase
        public int CardValue
        {
            get { return cardValue; } // getter - return the value
            set { cardValue = value; }  // setter - set cardValue to value used when assigning "value" is a keyword representing the value asigned

        }

        // Every class has at least on contructor

        // Constructors are responsible for initializing data in the object

        // Constructors: public, same name as class, no return type, may have parameters

        //Constructor to initialize all instance variables
        public PlayingCard(int theValue, string theSuit, string theColor)
        {
            cardColor = theColor; // initialize color to color passed
            cardValue = theValue; // initialize value to value passed
            cardSuit = theSuit; // initialize suit to suit passed
        }

        // a copy constructor is used to create a copy of a PlayingCard from a PlayingCard (aka "deep copy")
        // Avoids two references to the same object when creating an object from an object

        // A copy constructor receives an object of the class as a parameter and initialize using the data members in that object
        public PlayingCard(PlayingCard sourceCard)
        {            
            cardColor = sourceCard.cardColor;
            cardValue = sourceCard.cardValue;
            cardSuit = sourceCard.cardSuit;
        }


        // Method overrides to have the class behave the way we want not the default way

        // Overrides the default ToString() method
        // We must be sure the method signature matches the method we are overriding
        // An override is substituting your processing for the default processing 

        // Since the default ToString() returns a string and recieves no parameters, the override must do the same

        // The override keyword tells C# this is an override for default behavior 
        public override string ToString() 
        {
            return $"PlayingCard: Value={cardValue}, Color={cardColor}, Suit={cardSuit}";
        }
    }
}
