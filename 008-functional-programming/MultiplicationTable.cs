using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplication
{
    public class MultiplicationTable
    {
        public static void UseMultiplicationTable(int number)
        {
            int count = 1;
            while (count <= 10)
            {
                Console.WriteLine(count + " X " + number + " = " + (count * number));
                count++;
            }
        }
    }
}