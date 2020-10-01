using System;

namespace _005_functions
{
    class Program
    {
        static int Calculate(int a, int b)
        {
            return a + b;
        }
        public static void PrintMessageOnScreen()
        {
            Console.WriteLine("Hello World!");
        }

        public static void CalculateTimes(int number)
        {
            int count = 1;
            while(count <= 10)
            {
                Console.WriteLine(number + " X " + count + " = " + (number * count));
                count++;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Calculate(15, 17));
            Console.Read();
            PrintMessageOnScreen();
            Console.Read();
            CalculateTimes(5);
            CalculateTimes(15);
        }
    }
}
