using System;
using System.Collections.Generic;


namespace My_Dictionary_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {// create a dictionary to relate zip codes to the people who live in them 
            Dictionary<string, int> personInfo = new Dictionary<string, int>();

            // add some people and their zip codes
            // dictionaryName[key] = value;

            personInfo["Frank"] = 85339;
            personInfo["Evan"] = 48009;
            personInfo["Joshua"] = 15658;
            personInfo["Ryan"] = 48116;

            personInfo.Add("Jenna",85339);

            // Specifying a key that already exists in the Dictionary
            personInfo["Frank"] = 44143;

            if (!personInfo.ContainsKey("Frank")) 
            {
                personInfo.Add("Frank", 06082);
            }
            else 
            {
                personInfo["Frank"] = 06082;
            }
            Console.WriteLine($"Joshua lives in {personInfo["Joshua"]}");

            Console.WriteLine("Whose zipcode do you want");
            string name = Console.ReadLine();
            try
            {
                Console.WriteLine($"{name} lives in {personInfo[name]}");
            }
            catch (KeyNotFoundException exceptionInfo) 
            {
                Console.WriteLine($"Error looking for: {name}\n{exceptionInfo.Message}");
            }
            Console.ReadLine();
            
            foreach(KeyValuePair<string, int> anEntry in personInfo) 
            {
                Console.WriteLine($"{anEntry} lives in zip code: {anEntry.Value}");
            }
        }
    }
}
