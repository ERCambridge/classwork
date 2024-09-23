using GeneralPurposeFunctions;

namespace My_Logging_Example
{
    internal class Program
    {
        static CommonlyUsedFunctions myFuncs = new CommonlyUsedFunctions();
        static StreamWriter logFile = new StreamWriter("../../../program.log", true);

        static string inputFilePath = "../../../data/IMDB-Top-25-SciFi-Movies.txt";
        static void Main(string[] args)
        {
            LogEvent("Program started");
           //Read and display all the data in the IMDB-Top-25-SciFi-Movies file

           //Define a Stream Reader for the file
           StreamReader fileReader = new StreamReader(inputFilePath);

            //Define a List to hold each line from the file
            List<string> sciFiMovies = new List<string>();

            while (!fileReader.EndOfStream) 
            {
               sciFiMovies.Add(fileReader.ReadLine()); 
            }

            do
            {
                Console.WriteLine("Enter a word in the title of the movie you're looking for...");

                string userInput = Console.ReadLine();

                foreach (string aLine in sciFiMovies)
                {
                    if (aLine.ToLower().Contains(userInput.ToLower()))
                    {
                        Console.WriteLine(aLine);
                    }
                }
            } while (myFuncs.moreInput());


            fileReader.Close();
            LogEvent("Program ended"); 
            logFile.Close();
        }

        public static void LogEvent(string messageToLog) 
        {
            DateTime now = DateTime.Now;
            string formattedTime = now.ToString("yyyy-MM-dd-HH:mm:ss");
            logFile.WriteLine($"{formattedTime} - {messageToLog}");
            logFile.Flush();
        }
    }
}
