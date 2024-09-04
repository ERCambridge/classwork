using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Student_Scores_Class_Example
{
    // removed the internal attribute 
    class Student
    {
        // Define data we want to store for a student
        public string studentName;
        public List<double> testScores;

        // Methods for class

        // Constructors

        // Do we need a default constructor? Does a default student make sense 
        // No - so theres no 0-arg constructor

        // Do we want to create a student with just a name? (with no test scores)
        // Yes - Create a 1-arg constructor that takes a student name

        // Do we want to create a student with just test scores? (with no name)
        // No - No 1-arg constructor that takes test scores

        // Do we want to crerate a student that already has test scores?
        // Yes - Create a 2-arg constructor that takes a Student Name and their scores

        public Student(string name) 
        { 
            studentName = name; 
            testScores = new List<double>(); // Define and assign a default List for testScores
        }
        public Student (string name, List<double> scores) 
        {
            studentName = name;
            testScores = scores;

        }

        //Additional methods to support the class

        // Allow the user to add a score to testScores
        public void ScoreAdd(double score) 
        { 
            testScores.Add(score);  
        }


        // display the data in an object
        public void ShowStudent() 
        {
            Console.WriteLine($"\nName: {studentName}  Test Scores: ");
            foreach(double aScore in testScores) 
            { 
                Console.Write($"{aScore} " );
            }
        }


    }
}
