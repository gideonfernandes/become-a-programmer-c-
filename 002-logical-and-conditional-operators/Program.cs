using System;

namespace _002_logical_and_conditional_operators
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("If conditions");
            var a = 1;
            if (a == 1 || a == 6) Console.WriteLine("Entered the single if condition");
            var b = 1;
            if (b == 1 && b != 10) {
                Console.WriteLine("Entered the block if condition");
            }

            if (b > 5) {
                Console.WriteLine("b == 5");
            } else if (b == 7) {
                Console.WriteLine("b == 7");
            } else {
                Console.WriteLine("Entered the else block condition");
            }
            Console.Read();

            Console.WriteLine("Switch cases");
            var c = 6;
            switch (c)
            {
                case 1:
                    Console.WriteLine("c == 1");
                    break;
                case 2:
                    Console.WriteLine("c == 2");
                    break;
                default:
                    Console.WriteLine("Entered the default case");
                    break;
            }
            Console.Read();

            Console.WriteLine("Ternary operators");
            string ternary = (c == 5 ? "It is 5!" : "It is not 5!");
            Console.WriteLine(ternary);
        }
    }
}
