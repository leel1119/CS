using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03_P102_InternalAccess_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHello.SayHellToWorld();
            Console.Read();
        }

    }
    class SayHello
    {
        internal static void SayHellToWorld()
        {
            Console.WriteLine("Hello");
            Console.WriteLine("To The World of C# Program");
            Console.WriteLine("Have a great day");
        }
    }
}
