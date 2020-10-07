using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files
{
    public class ReadFiles
    {
        public static void UseReadFiles(int fileNumber)
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
                ReadFiles.UseReadFiles(fileNumber + 1);
            }
        }
    }
}