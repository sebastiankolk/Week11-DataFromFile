using System;
using System.IO;
namespace DataFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Whats your horoscope");
            string userHoroscope = Console.ReadLine();

            string output = GetLineFromFileData(userHoroscope);

            if (output.Length != 0)
            {
                Console.WriteLine(output);
            }
            else
            {
                Console.WriteLine("Sorry, Horoscope not found");
            }

        }
        private static string[] ReadDataFromFile()
        {
            string rootDirectory = @"C:\Users\opilane\Samples";
            string fileName = "horoscope.txt";
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