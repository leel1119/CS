using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06_P07_GenericMethodTypeParameter_Overloaded_Default_EX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dummy<String, int>(); // String default 是 NULL, int defult 是 0
            Dummy<ArrayList>();
            Console.ReadLine();
        }
        static void Dummy<T, U>()
        { 
            var x = default(T);  
            var y = default(U);
            Console.WriteLine($"The Default T:{x}, The Default U:{y}");
        }
        static void Dummy<T>()
        {
            var x = default(T);
            Console.WriteLine($"The Default T:{x}");
        }
    }
}
