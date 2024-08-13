using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_Roller_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the grand circus casino!\n" + "How many side should each die have?");
            int dieSides = int.Parse(Console.ReadLine());
            string userResponse= "y";
            int currentRoll = 1;

            do
            {
                int firstRoll = randomRoller(1,dieSides);
                int secondRoll = randomRoller(1, dieSides+1);
                int rollSum = firstRoll + secondRoll;
                Console.WriteLine($"Roll: {currentRoll}\nYou rolled a {firstRoll} and a {secondRoll} ({rollSum} Total)" );
                if (dieSides == 6)
                {
                   Console.WriteLine(doubleRollIdentifier(firstRoll, secondRoll));
                   Console.WriteLine(rollSumIdentifier(firstRoll, secondRoll));
                }
                Console.WriteLine("Roll again? (y/n)");
                userResponse = Console.ReadLine();
                currentRoll++;

            } while (userResponse != "n");
            randomRoller(1, 6);
        }

        static int randomRoller(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        static string doubleRollIdentifier (int firstRoll, int secondRoll) 
        {
            int sum = firstRoll + secondRoll;
            switch (sum)
            {
                case 2:
                {
                    return "Snake Eyes";
                   
                }
                case 3: 
                {
                    return "Ace Deuce";
                    
                }
                case 12:
                {
                    if (firstRoll == 6 && secondRoll == 6) 
                    { 
                        return "Box Cars"; 
                    }
                    return "";
                    
                }
                default: 
                {
                    return ""; 
                }

            }
                
        }

        static string rollSumIdentifier (int firstRoll, int secondRoll) 
        { 
            int sum = (firstRoll + secondRoll);
            switch (sum) 
            {
                case 12:
                case 3:
                case 2: 
                {
                    return "Craps!";                
                }
                case 7:
                case 11:
                {
                    return "Win!";
                }
                default: 
                {
                    return "";   
                }

            
            }
        
        
        
        }
    }
}
