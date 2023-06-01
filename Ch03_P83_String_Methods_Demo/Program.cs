using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03_P83_String_Methods_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String a = "String";
            String b = "";

            b = a.Replace("i","o");
            Console.WriteLine($"String a is {a}, and String b is {b}");

            b = a.Insert(0,"My ");
            Console.WriteLine($"String a is {a}, and String b is {b}");

            b = a.Remove(0, 3);
            Console.WriteLine($"String a is {a}, and String b is {b}");

            b = a.Substring(3);
            Console.WriteLine($"String a is {a}, and String b is {b}");

            b = a.Substring(0, 3);
            Console.WriteLine($"String a is {a}, and String b is {b}");

            b = a.ToUpper();
            Console.WriteLine($"String a is {a}, and String b is {b}");

            int length;
            length = a.Length;
            Console.WriteLine($"String a is {a}, and String Length is {length}");

            Console.ReadLine();
        }
    }
}
