using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05_P53_DelegateAsParameter_EX
{
    delegate void StringDelegate(string str);
    class Person 
    {
        string[] list = { "Andy", "Bill", "Carol" };
        public void PrintList(StringDelegate sd)
        { 
            foreach (var e in list) sd(e);
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            Person p = new Person();
            p.PrintList(PrintName);

            Console.ReadLine();
        }
        static void PrintName(string str) 
        {
            Console.WriteLine(str);
        }
    }
}
