using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Ch03_P84_StringBuilder_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("Hello");
            Console.WriteLine($"The sb is {sb}");

            sb.Append(" World");
            Console.WriteLine($"The sb is {sb}");

            sb.Remove(0, 5);
            Console.WriteLine($"The sb is {sb}");

            sb.Insert(0, "Bye");
            Console.WriteLine($"The sb is {sb}");

            string s = sb.ToString();
            Console.WriteLine($"s is {s}");

            Console.ReadLine();
        }
    }
}
