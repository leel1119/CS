using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03_P9_Method_Demo
{
    class MyClass
    {
        static void Main(string[] args)
        {
            MyPrint();
            MyClass MyProgram = new MyClass();
            MyProgram.MyPrint01();
            Console.ReadLine();
        }

        static void MyPrint()
        {
            Console.WriteLine("This is my first Statick method.");
        }
        void MyPrint01()
        {
            Console.WriteLine("This is my first Instance method.");
        }
    }
}
