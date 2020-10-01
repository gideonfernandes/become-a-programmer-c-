using System;
using System.IO;
namespace _006_recursive_functions
{
    class Program
    {
        private static void ReadFiles(int fileNumber)
        {
            string filePath = @"./files/file" + fileNumber + ".txt";
            if (File.Exists(filePath))
            {
                using(StreamReader file = File.OpenText(filePath))
                {
                    string row;
                    while ((row = file.ReadLine()) != null)
                    {
                        Console.WriteLine(row);
                    }
                }
            }

            string nextFilePath = @"./files/file" + (fileNumber + 1) + ".txt";
            if (File.Exists(nextFilePath))
            {
                ReadFiles(fileNumber + 1);
            }
        }
        static void Main(string[] args)
        {
            ReadFiles(1);
        }
    }

}
