using System;
using System.IO;
namespace DataFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Whats your favourite colour");
            string userColor = Console.ReadLine();

            string output = GetLineFromFileData(userColor);

            if(output.Length != 0)
            {
                Console.WriteLine(output);
            }
            else
            {
                Console.WriteLine("Sorry,Colour not found");
            }

        }
        private static string[] ReadDataFromFile()
        {
            string rootDirectory = @"C:\Users\opilane\Samples";
            string fileName = "Personality.txt";
            string fullfilePath = $@"{rootDirectory}\{fileName}";

            string[] dataFromFile = File.ReadAllLines(fullfilePath);
            return dataFromFile;
        }
        private static string GetLineFromFileData(string userInput)
        {
            string[] dataFromFile = ReadDataFromFile();
            string result = "";
            foreach (string line in dataFromFile)
            {
                if (line.Contains(userInput))
                {
                    result = line;
                    break;
                }      
            }
            return result;
        }
    }
}
