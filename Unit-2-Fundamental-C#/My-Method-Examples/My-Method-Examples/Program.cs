using System;


namespace My_Method_Examples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the program");
            for (int i = 0; i < 5; i++) 
            {
                double aValue = getANumber();

                Console.WriteLine($"Number entered was: {aValue}");

            }
            Console.WriteLine("Thanks for using the program");
        }

        static double getANumber()
        {
            double theValue = 0;
            bool isValidNumber = false;
            do
            {
                Console.WriteLine("Please enter a number");

                string userInput = Console.ReadLine();
                try
                {

                    theValue = double.Parse(userInput);
                    isValidNumber = true;   

                }
                catch (FormatException exceptionBlock)
                {

                    Console.WriteLine($"Invalid response '{userInput}' is not a number.");

                }
                

            } while (!isValidNumber);
            return theValue;
        }


    }
}
