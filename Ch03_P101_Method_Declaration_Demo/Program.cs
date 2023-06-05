using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03_P101_Method_Declaration_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayHellToWorld();
            Console.ReadLine();
        }
        private static void SayHellToWorld()
        {
            Console.WriteLine("Hello");
            Console.WriteLine("To The World of C# Program");
            Console.WriteLine("Have a great day");
        }
    }
}
