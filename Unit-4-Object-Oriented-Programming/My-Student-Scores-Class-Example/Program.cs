using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Student_Scores_Class_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Dog");

            // Define a Student with a name and no test scores
            // Define a List of test scores to send to the constructor
            List<double> theScores = new List<double>();
            theScores.Add(100);
            theScores.Add(50);

            Student student2 = new Student("Fish",theScores);

            // Add test scores for a student

            // We need to use a method provided by the class to do so

            student1.ScoreAdd(75);
            student1.ScoreAdd(85);
            student1.ScoreAdd(95);
            student1.ScoreAdd(35);

            student2.ScoreAdd(80);

            // Display the data associated with each Student using a method provided by the CLass
            // because the class owns the data and knows how to display it
            // so we dont have to do any work as the user of the class to display 

            student1.ShowStudent();    
            student2.ShowStudent();
        }
    }
}
