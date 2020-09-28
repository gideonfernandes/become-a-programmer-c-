using System;
using System.Collections.Generic;

namespace _004_array_and_collections
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Arrays...");
            string[] array1 = new string[3];
            var array2 = new string[3];
            Console.WriteLine(array1);
            Console.WriteLine(array2);
            array1[0] = "Gideon";
            array1[1] = "Lima";
            array1[2] = "Fernandes";

            foreach(string value in array1)
            {
                Console.WriteLine(value);
            }
            Array.Sort(array1);
            foreach(string value in array1)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine("Array size: " + array1.Length);
            if(Array.Exists(array1, value => value == "Fernandes"))
            {
                Console.WriteLine("Fernandes founded on array1!");
            }
            if(Array.Exists(array1, value => value.IndexOf("Lima") != -1))
            {
                Console.WriteLine("Lima founded on array1!");
            }
            Console.Read();

            Console.WriteLine("Collection or List...");
            List<string> collection1 = new List<string>();
            var collection2 = new List<string>();
            collection1.Add("Herika");
            collection1.Add("Maria");
            collection1.Add("Ramos");
            Console.WriteLine("Collection size: " + collection1.Count);
            if(collection1.Exists(value => value == "Gideon"))
            {
                Console.WriteLine("Gideon founded on collection1!");
            } else {
                Console.WriteLine("Gideon not founded on collection1!");
            }
            collection2.ToArray();
            Console.Read();
        }
    }
}
