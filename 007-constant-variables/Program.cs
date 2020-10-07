using System;

namespace _007_constant_variables
{
    class Program
    {
        public const int END_PROGRAM = 1;
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter " + END_PROGRAM + " to end the application!");
                int input = int.Parse(Console.ReadLine());

                if (input == END_PROGRAM)
                {
                    break;
                }
            }
            Console.WriteLine("Application ending successfully!");
        }
    }
}
