﻿using System;

// a namespace is a group of related things whose name and purpose is defined in the namespace
// allows things to be named the same and have different meanings depending on their context


namespace GeneralPurposeFunctions
{

    // a class is a group of related parts of an application
    // a class is used to instantiate/create objects to be used in the application
    // Object-Oriented Programs depend on objects whic are described by classes
    // Classes can be thought of as a programmer defined data-type
    public class CommonlyUsedFunctions
    {
        /************************************************************************************
         * Display a separator line block with a message
         ************************************************************************************/

        // methods are functions defined within a class 
        public void WriteSeparatorLine(string message)

            // If no constructor is supplied for a class C# defines a 0-arg constructor
            // that sets all data to standard defaults: null for object, 0 for numeric, false for boolean

            // This class has no data so there is nothing to initialize - no constructor needed
        {
            Console.WriteLine("\n-------------------------------------");
            Console.WriteLine("----- " + message);
            Console.WriteLine("-------------------------------------\n");

        } // End of WriteSeparatorLine()

        /************************************************************************************
         * Pause program until user presses the enter key
         ***********************************************************************************/
        public void PauseProgram()
        {
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
        } // End of PauseProgram()

        /************************************************************************************
         * Return a boolean value to indicate if the user has more input
         ************************************************************************************/
        public bool moreInput()
        {
            bool isThereInput = false;  // Hold teh return value 

            string whatUserTyped = "";     // Hold what the user enters

            bool getInput = true;   // Control the user interaction loop

            do
            {
                // Ask the user if they have any numbers to enter (Y/N)
                Console.WriteLine("\nDo you have any values to enter (Y/N)?");
                whatUserTyped = Console.ReadLine();

                whatUserTyped = whatUserTyped.ToUpper();

                string firstChar = whatUserTyped.Substring(0, 1);

                if (firstChar == "Y")
                {
                    getInput = false;
                    isThereInput = true;
                }
                else
                {
                    if (firstChar == "N")
                    {
                        getInput = false;
                        isThereInput = false;
                    }
                }
            } while (getInput); // Loop while we get input

            return isThereInput;

        }  // End of moreInput()

        /************************************************************************************
         * This method will get a numeric value from the user
         ***********************************************************************************/

        public double GetANumber()
        {
            // define a variable for the return value
            double theValue = 0;

            // Ask the user for a numeric value and have them keep trying until we get one

            bool isValidNumber = false;  // Determine is user entered a valid value

            // Loop until we get a valid numeric value

            do  // do loop is used so we ask the user for a number at least once
            {
                // Prompt the user to enter a numeric value
                Console.WriteLine("Please enter a number");

                // Get the input from the user
                string userInput = Console.ReadLine();

                try // We want to handle an Exception that might occur in this block of code
                {
                    // Convert the user input to a double
                    theValue = double.Parse(userInput); // Could cause an Exception
                    isValidNumber = true;  // if .Parse() worked we have a valid number
                }
                // catch (Exception exceptionBlock) will handle every Exception that can occur
                catch (FormatException exceptionBlock) // Handle a FormatException in previous try block
                {
                    Console.WriteLine("\n----- Uh-oh Uh-oh Uh-oh ------");
                    Console.WriteLine("There is problem with " + userInput);
                    Console.WriteLine(exceptionBlock.Message); // Display the system message for the error
                    Console.WriteLine("------ Uh-oh Uh-oh Uh-oh ------\n");
                }
            } while (!isValidNumber); // Loop while we don't have a valid number

            // return the double value from the user input
            return theValue;
        } // End of getANumber() method

    } // End of class CommonlyUsedFunctions
} // End of namespace GeneralPurposeFunctions
