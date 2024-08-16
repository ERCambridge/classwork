using System;

namespace My_Sample_Conditional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an odd number between 11 and 17");
            int userNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("You entered: " + userNumber);

            if (userNumber >= 11 && userNumber <= 17 && userNumber % 2 != 0)
            {
                Console.WriteLine("The value is odd and between 11 and 17");
            }
            else 
            {
                Console.WriteLine("The value isn't odd and between 11 and 17");
            }

         

            Console.WriteLine("Press 'Enter' to continue...");
            Console.ReadLine(); 

        }
    }
}
