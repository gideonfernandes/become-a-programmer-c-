using System;

namespace _001_variable_types
{
    class Program
    {
        static void Main(string[] args)
        {
            int i1 = 1;
            var i2 = 2;
            Console.WriteLine("int");
            Console.WriteLine(i1);
            Console.WriteLine(i2);
            Console.WriteLine();

            Console.WriteLine("string");
            string s1 = "Gideon";
            var s2 = "Fernandes";
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine();

            Console.WriteLine("float");
            float f1 = 1.5f;
            var f2 = 2.5f;
            Console.WriteLine(f1);
            Console.WriteLine(f2);
            Console.WriteLine();

            Console.WriteLine("double");
            double d1 = 1.566;
            var d2 = 2.566;
            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine();

            Console.WriteLine("bool");
            bool b1 = true;
            var b2 = false;
            Console.WriteLine(b1);
            Console.WriteLine(b2);
            Console.WriteLine();

            Console.WriteLine("Converting...");
            bool boolean = bool.Parse("false");
            bool boolean2 = Convert.ToBoolean(d1);
            Console.WriteLine(boolean);
            Console.WriteLine(boolean2);
            Console.WriteLine(d1.ToString());
            Console.WriteLine(d1.GetType());
            Console.WriteLine(Convert.ToString(b1));
            Console.WriteLine();
        }
    }
}
