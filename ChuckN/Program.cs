using System;
using System.IO;
namespace DataFromFile
{
    class Program
    {
        static void Main(string[] args)
        {

            string rootDirectory = @"C:\Users\opilane\Samples";
            string fileName = "Chuck.txt";
            string fullfilePath = $@"{rootDirectory}\{fileName}";

            string[] dataFromFile = File.ReadAllLines(fullfilePath);
            Random rnd1 = new Random();
            Console.WriteLine(dataFromFile[rnd1.Next(dataFromFile.Length)]);
        }
    }
}