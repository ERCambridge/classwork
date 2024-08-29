using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5_My_Review
{
    internal class Program
    {

        static void Main(string[] args)
        {
            double[] testScores = { 4, 5, 6, 7, 8, 9, 10, 12 };

            // double[] testScores = new double[6];
            try
            {
                Console.WriteLine($"Test score #3 is: {testScores[2]}");
            }
            catch (Exception exceptionInfo) 
            {
                Console.WriteLine($"Error has occured\n{exceptionInfo.Message}");
            }


            // a List is a set of values all the same data type like an array
            // UNLIKE an array a List can be variable size
            // it's size does not have to be known when you define it
            // it can get bigger or smaller as you execute
            // more flexible than an array

            // TO define a List:

            // List<element-data-type> name = new List<element-data-type>();

            // NOTE: use of new keyword and same code on left of = is used on right with()

            // To add an element to a List:  listname.Add(value-to-add)

            // a foreach statement is typically used to process all elements in a list

            // syntax: foreach(element-type name-for-current-element in ListName)

            //use the name-for-current-element in the processing of the loop

            // Unlike a for-loop there is no index to tell you which element # is the current 
            // YOU must keep track of the element # if you want it 

            // a List element may be referenced by an index jsut like an array
            // a for-loop can be used to process a List 

            List<double> listOfScores = new List<double>();

            // Add some test scores to the list
            listOfScores.Add(10);
            listOfScores.Add(100);
            listOfScores.Add(-10);
            listOfScores.Add(90);

            //Display all the elements in a list

            foreach(double currentScore in listOfScores)
            {
                Console.WriteLine($"Test Score: {currentScore}");    
            }
            for(int i = 0; i < listOfScores.Count; i++) 
            { 
                Console.WriteLine($"Test Score {i}: {listOfScores[i]}");
            }

            listOfScores.RemoveAt(1); // RemoveAt(index) removes hte element at the index
            listOfScores.Remove(-10); // Remove(value) removes the first element with that value


            // an array or List can only store one value type
            // so if you need to relate two valuse - Can't use an array or a list
            // A dictionary is the best choice for this rather than two lists or two arrays
            // A dictionary is designed to relate two values in  a data structure
            // a dictionary requires a Key and a Value

            // the Key is how you want to identify the value
            // the Value is what is associated with the key

            // student-name = Key
            // test-scores = Value

            // Syntax: Dictionary<type-of-key, type-of-value> name = new Dictionary <type-of-key, type-of-value>

            // Define a Dictionary to hold 1 test score for each student

            // Key - name
            // Value - score

            Dictionary<string, double> studentScores = new Dictionary<string, double>();

            studentScores.Add("Fonzie", 100);
            studentScores.Add("Richie", 90);
            studentScores.Add("Ralph", 50);
            studentScores.Add("Potsie", 75);

            Console.WriteLine($"Fonzie got a score of {studentScores["Fonzie"]}");
            Console.WriteLine($"Fonzie got a score of {studentScores.ElementAt(0)}");

        }
    }
}
