using System;

namespace My_Loop_Examples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numberSum = 0;
            double aNumber = 0;
            int numNums = 0;
            /**
            Console.WriteLine("How many numbers do you need to enter?");
            numNums = int.Parse(Console.ReadLine());   

            for (int i = 0 ; i < numNums; i++) 
            {
                Console.WriteLine("Please enter number " + (i+1) + " of 3");
                aNumber = double.Parse(Console.ReadLine());    
                //Console.WriteLine("You entered " + aNumber);
                numberSum += aNumber;
            }
            **/

            /**
           // bool shouldLoop = true;
           //while(shouldLoop)
            while (true) 
            {
                Console.WriteLine("Enter a number or end to finish");
                string userInput = Console.ReadLine();
                if ( userInput== "end")
                {
                    //shouldLoop = false;
                    break;
                }
                //else 
                {
                    aNumber = double.Parse(userInput);
                    numberSum += aNumber;
                    numNums++;
                }


            } **/
            
            string userInput;
            do
            {
                Console.WriteLine("Enter a number or end to finish");
                userInput = Console.ReadLine();
                if (userInput == "end")
                {
                    
                    continue;
                }
                {
                    aNumber = double.Parse(userInput);
                    numberSum += aNumber;
                    numNums++;
                }

            } while (userInput != "end");
           

            double numberAverage = numberSum / numNums;

            Console.WriteLine("The sum is " + numberSum + " and the average is " + numberAverage);

            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();

           

        }
    }
}
