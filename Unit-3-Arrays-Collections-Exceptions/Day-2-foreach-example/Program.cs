using System;

namespace Day_2_foreach_example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] doubleList = {2000, 1.5, 6.7, 13.3 };

            //double[] newList = new double[6];

            //doubleList[0] = 2;


            for (int i = 0; i < doubleList.Length; i++)
            {
                Console.WriteLine($"Element #{i}: {doubleList[i]}");


            }
            
            foreach(double anElement in doubleList) 
            {
                Console.WriteLine($"Element: {anElement}");
            }
        }
    }
}
