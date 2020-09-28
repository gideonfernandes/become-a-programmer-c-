using System;

namespace _003_loops
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("While looping");
            int number = 0;
            while(number <= 10)
            {
                if (number == 0)
                {
                    number++;
                    continue;
                }

                Console.WriteLine(number);
                number++;
            }
            Console.Read();

            Console.WriteLine("Do While looping");
            int number2 = 0;
            do
            {
                if (number2 == 3)
                {
                    break;
                }
                Console.WriteLine(number2);
                number2++;
            }
            while (number2 <= 10);
            Console.Read();

            Console.WriteLine("For looping");
            for(int number3 = 15; number3 <= 30; number3++)
            {
                Console.WriteLine(number3);
            }
            Console.Read();

            Console.WriteLine("Foreach looping");
            int[] numberCollection = {1, 2, 3, 4, 5};
            foreach(int value in numberCollection)
            {
                Console.WriteLine(value);
            }
            Console.Read();
        }
    }
}
