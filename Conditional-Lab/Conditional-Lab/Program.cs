using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a whole number between 1 and 100");
            int userNumber = int.Parse(Console.ReadLine());

            if (userNumber >= 1 && userNumber <= 100) 
            {
                if (userNumber % 2 != 0 && userNumber < 60)
                {
                    Console.WriteLine(userNumber + " is odd and less than 60");
                }
                if (userNumber % 2 == 0 && userNumber >= 2 && userNumber <= 24) 
                { 
                    Console.WriteLine(userNumber + " is even and less than 25");
                }
                if (userNumber % 2 == 0 && userNumber >= 26 && userNumber <=60) 
                {
                    Console.WriteLine(userNumber + " is even and between 26 and 60 inclusive");
                }
                if(userNumber % 2 == 0 && userNumber > 60) 
                {
                    Console.WriteLine(userNumber + " is even and greater than 60");
                }
                if( userNumber % 2 != 0 && userNumber > 60) 
                {
                    Console.WriteLine(userNumber + " is odd and greater than 60");
                }
            }
            else
            {
                Console.WriteLine("Number is not between 1 and 100");
            }
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
        }
    }
}
