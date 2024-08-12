using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Loops_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //excercise 1
            string userInput;
            do
            {
                Console.WriteLine("Hello World!");
                Console.WriteLine("Would you like to Continue? y/n");
                userInput = Console.ReadLine();
              
            } while (userInput != "n");

            //excercise 2
            do
            {
                Console.WriteLine("Please enter a whole number");
                int userNumber = int.Parse(Console.ReadLine());
                for (int i = 0; i <= userNumber; i++)
                {
                    Console.Write(userNumber - i + " ");

                }
                Console.WriteLine();
                for (int i = 0; i <= userNumber; i++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
                Console.WriteLine("Would you like to continue? y/n");
                userInput= Console.ReadLine();
            }


            //excercise 3
            while (userInput != "n");   
            int correctCode = 13579;
            int userCode = 0;
            while(userCode != correctCode) 
            {
                Console.WriteLine("Please enter the 5 digit keycode to begin");
                userCode = int.Parse(Console.ReadLine());
                if (userCode != correctCode)
                {
                    Console.Write("Incorrect code. Please try again.");
                }
                else
                {
                    Console.WriteLine("You've enetered the correct code. Welcome!");
                }
            }

            //excercise 4
            userCode = 0;
            int attemptLimit = 5;
            int userAttempts = 0;

            
            while (userCode != correctCode && userAttempts< 5)
                {
                    Console.WriteLine("Please enter the 5 digit keycode to begin");
                    userCode = int.Parse(Console.ReadLine());
                    userAttempts++;
                if (userCode != correctCode && userAttempts < 5)
                    {
                        
                        Console.WriteLine("Incorrect code. " + (attemptLimit - userAttempts) + " attempts remain" );
                    }
                    else if (userCode == correctCode)   
                    {
                        Console.WriteLine("You've enetered the correct code. Welcome!");
                    }
                    else if (userCode != correctCode && userAttempts== 5) 
                    {
                        Console.WriteLine("Too many incorrect attempts. You are now locked out.");
                    }
                }

            //excercise 6
            userCode= 0;
            userAttempts = 0;

            do
            {
                Console.WriteLine("Please enter the 5 digit keycode to begin");
                userCode = int.Parse(Console.ReadLine());
                userAttempts++;
                if (userCode != correctCode && userAttempts < 5)
                {

                    Console.WriteLine("Incorrect code. " + (attemptLimit - userAttempts) + " attempts remain");
                }
                else if (userCode == correctCode)
                {
                    Console.WriteLine("You've enetered the correct code. Welcome!");
                }
                else if (userCode != correctCode && userAttempts == 5)
                {
                    Console.WriteLine("Too many incorrect attempts. You are now locked out.");
                }
            }while(userCode != correctCode && userAttempts < 5);



            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
        }
    }
}
