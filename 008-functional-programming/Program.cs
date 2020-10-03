using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Files;
using Multiplication;
using Average;

namespace functional_programming
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        public const int END_APP = 0;
        public const int READ_FILES = 1;
        public const int MULTIPLICATION_TABLE = 2;
        public const int CALCULATE_AVERAGE = 3;

        private static void Menu()
        {
            while (true)
            {
                string message = "\nHello user! Welcome to the functional application!" +
                    "\n  Enter an option below:" +
                    "\n    0 - Ending Application" +
                    "\n    1 - Read Files" +
                    "\n    2 - Initialize multiplication table" +
                    "\n    3 - Calculate averages";
                
                Console.WriteLine(message);
                int entry = int.Parse(Console.ReadLine());
                
                Console.WriteLine("=========================================");
                if (entry == READ_FILES)
                {
                    ReadFiles.UseReadFiles(1);
                }
                else if(entry == MULTIPLICATION_TABLE)
                {
                    MultiplicationTable.UseMultiplicationTable(5);
                }
                else if (entry == CALCULATE_AVERAGE)
                {
                    CalculateAverage.UseCalculateAverage(5.4, 8.2);
                }
                else
                {
                    Console.WriteLine("\nApplication ending successfully!");
                    break;
                }
            }
        }
    }
}
