using System;

namespace StarTrekStuff
{
    public class StarFleetPersonnel
    {
        // data associated with the class

        //access modifier indicates who has access to the item

        // public - anyone with an object of the class
        // private - only methods in the class have access (no one outside the class)

        // access data
//      modifier type variable-name 
        public string name;
        public string rank;
        public string assignment;


        // Methods associated with the class
        // Typically a class has one or more constructors
        // Since a class is a programmer defined datatype the programmer must defin how  it initializes

        // A constructor is a method that initializes an object when it is instantiated/created

        // A constructor has no return type and has the same name as the class 
        // Constructors may recieve parameters used to initialize a new object

        // The constructor's job is to assign values to the data for the class

        // 3-arg constructor
        public StarFleetPersonnel(string personName, string theirRank, string theirAssignment)
        {
            name       = personName;
            rank       = theirRank;
            assignment = theirAssignment;
        }

        //Deafault
        //public StarFleetPersonnel() 
        //{
        //    name = "yourself";
        //    rank = "Cat";
        //    assignment = "Bartender";

        //}

        // Additional methods to support the class
        // aka Member Methods

        /************************************************************************************
         * Display a line from the list parsed into individual values
         ************************************************************************************/

        public void DisplayCrewMember()
        {
            Console.WriteLine($"\nName:\t{name}\nCrew:\t{assignment}\nRank:\t{rank}");
        } // End of DisplayLine()


    } // End of class StarFleetPersonnel
}  // End of namespace StarTrekStuff