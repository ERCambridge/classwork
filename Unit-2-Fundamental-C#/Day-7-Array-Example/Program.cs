using System;

namespace Day_7_Array_Example
{
    internal class Program
    {
        /**************************************************************************************
         * This app will receive up to 10 numbers from the user
         *
         * After the user has indicated they have no more numbers to enter
         *             or 10 numbers have been entered...
         *               
         * We will display each or the numbers entered with an indicator if number odd or even,
         *                 their sum and average
         *****************************************************************************************/

        static void Main(string[] args)
        {
            Console.WriteLine("\nWelcome to my app!");       // Verify the app started

            // Set up a loop to get 5 numbers, one at a time
            const int ARRAY_SIZE = 10;

            double[] theNumbers = new double[ARRAY_SIZE];


            double theSum = 0;

            int numberEntered = 0;

            for (int i = 0; i < ARRAY_SIZE; i++)
            {

              

               

                if (!moreInput()) 
                {
                    break;
                }


                // Call the method to get a numeric value
                theNumbers[i] = GetANumber();
                numberEntered++;
   
                // Display the value we got from the method
                //Console.WriteLine("Number entered was: " + theNumbers[i]);
            }

            Console.WriteLine($"So I recieved {numberEntered} numbers from you");

            for (int i = 0; i < numberEntered; i++) 
            { 
                Console.WriteLine($"Element #:{i} is: {theNumbers[i]}" +
                    $"it is {(theNumbers[i]%2 == 0 ? "Even" : "Odd")}");
                theSum += theNumbers[i];

            }

            Console.WriteLine($"The sum of all the numbers is: {theSum}\nThe Average of all the numbers is: {theSum/numberEntered}");


            Console.WriteLine("\nThanks for using my app!"); // Verify the app ended

            Console.WriteLine("\nPress enter to end program...");
            Console.ReadLine();
        } // End of Main()

        /****************************************************************
         * Helper methods used by Main()
         ******************************************************************/
        // method starts with a method signature:  return-type name(parameters)

        // This method will get a numeric value from the user
        // It must be static because it will be used by the static method Main() (more later)
        // this method receives no parameters and returns a double (a double can also hold an int value)
       
        static bool moreInput() 
        {   
            bool isThereInput = false;

            string whatUserTyped = "";

            bool getInput = true;

            do 
            { 
                Console.WriteLine("Do you have any numbers to enter? (Y/N)");
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
            }while
            (getInput);

            return isThereInput;

        }
        
        
        static double GetANumber()
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
    } // End of class Program
} // End of namespace
