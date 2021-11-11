using System;
using System.IO;
namespace Random3
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
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(dataFromFile[rnd1.Next(0, dataFromFile.Length)]);
            }



        }
    }
}
