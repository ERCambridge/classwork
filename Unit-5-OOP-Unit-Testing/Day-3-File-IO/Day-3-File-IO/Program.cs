using GeneralPurposeFunctions;
namespace Day_3_File_IO
{
    internal class Program
    {
        private static CommonlyUsedFunctions _myFuncs = new CommonlyUsedFunctions();

        static void Main(string[] args)
        {
            _myFuncs.WriteSeparatorLine("Welcome to a File I/O Example");

            //Display the current Execution folder (folder the app is running from)
            //The environment object gives you access to information about the current execution environment 
            Console.WriteLine($"Current execution folder is: {Environment.CurrentDirectory}");

            //Display all the lines in the file called: numbers.txt in files directory/folder
            //Define a StreamReader for the file path containing the file
            //files path is 3 levels up from the execution path
            //StreamReader numberReader = new StreamReader("../../../files/numbers.txt");
            //Define a StreamWriter object to hold the output from the program in a file
            StreamWriter outputWriter = new StreamWriter("../../../silence.output");

            //Define a running total outside the loop
            int runningTotal = 0;

            try
            {
                using (StreamReader numberReader = new StreamReader("../../../files/numbers.txt"))
                    //Loop until all the lines in the file have been processed (not the EndOfStream)
                    while (!numberReader.EndOfStream) //.EndOfStream will indicate when file is empty (no more data)
                    {
                        //Get a line from the file
                        string currentNum = numberReader.ReadLine();

                        //Display and sum the numbers
                        //Split line into values
                        string[] theValues = currentNum.Split(",");

                        int sum = 0;

                        //Loop through the values
                        for (int i = 0; i < theValues.Length; i++)
                        {
                            //Trim any leading or trailing spaces from the value
                            string aValue = theValues[i].Trim();
                            //Convert a value from string to int
                            int intValue = int.Parse(aValue);
                            //Add the int value to the sum
                            sum += intValue;
                            //Display the value 
                            outputWriter.WriteLine($"Value #{i}: {aValue}");
                        }
                        //After we processed all the numbers
                        outputWriter.WriteLine($"The sum is: {sum}");
                        runningTotal += sum;    

                        //Display the line
                        //Console.WriteLine(currentNum);               
                    }
            }
            catch (Exception ex)
            {
                outputWriter.WriteLine(ex.Message );

            }
            outputWriter.WriteLine($"The running subtotal is: {runningTotal}");
            //numberReader.Close();
            outputWriter.Close();

            _myFuncs.PauseProgram();
            _myFuncs.WriteSeparatorLine("Thanks for visiting a File I/O Example");

        }
    }
}
