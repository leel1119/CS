using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05_P52_AddRemove_Delegate_InvokeList_EX
{
    internal class Program
    {
        delegate void StrDelegate();
        static void Hello() { Console.WriteLine("Hello"); }
        static void C_Sharp() { Console.WriteLine("C#"); }
        static void Programing() { Console.WriteLine("Programing"); }
        static void Main(string[] args)
        {
            StrDelegate sd = Hello;
            sd += C_Sharp;
            sd += Programing;
            sd();

            Console.WriteLine("---------------------");

            sd -= Hello;
            sd();            
            Console.ReadLine();
        }
    }
}
