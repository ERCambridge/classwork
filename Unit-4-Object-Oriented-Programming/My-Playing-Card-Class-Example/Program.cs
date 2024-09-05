using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneralPurposeFunctions; //Give me access to the GeneralPurposeFunctions code

namespace My_Playing_Card_Class_Example
{
    internal class Program
    {
        // Instantiate a copy of the code in CommonlyUsedFunctions
        // It's static beacuse it's used in Main() (which is static)
        static CommonlyUsedFunctions myFuncs = new CommonlyUsedFunctions();

        //This is the application program Main()

        // It will instantiate and manipulate the objects of various classes
        static void Main(string[] args)
        {
            myFuncs.WriteSeparatorLine("Welcome to our first OOP example");

            // Define/Instantiate a PlayingCard - an Ace of Hearts that is red
            myFuncs.WriteSeparatorLine("Instatiate and display a PlayingCard");

            PlayingCard aCard = new PlayingCard(1, "Hearts", "Red");

            Console.WriteLine($"aCard is: {aCard}");
            // Console.WriteLine expects a string to be written
            // Interpolation generates a string
            // aCard is a PlayingCard type not a string
            // In order for it to be written it needs to be converted to a string
            // The default method to convert an object to a string generates  a string containing the "namespace.className"
            // If you want your class object to be representd as a string you must override the default ToString() method in your class
            // You decide what a string representation of your class looks like

            // Defin a new PlayingCard to be the same as aCard

            // PlayingCard newCard = aCard;// This makes both newCard and aCard point to the same object 
            PlayingCard newCard = new PlayingCard(aCard);

            Console.WriteLine($"aCard is: {aCard}");
            Console.WriteLine($"newCard is: {newCard}");

            myFuncs.WriteSeparatorLine("Change value in newCard to 2");
            //newCard.cardValue; //Cannot acess private data in an object
            newCard.CardValue = 2;
            Console.WriteLine($"newCard is: {newCard}");
            Console.WriteLine($"aCard is: {aCard}");

            myFuncs.PauseProgram();
        }
    }
}
