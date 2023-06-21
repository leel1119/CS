using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03_P173_GenericList_IndexOf_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> { 1, 1, 2, 3, 5, 8, 11 };
            var a = numbers.FindIndex(x => x < 10);
            Console.WriteLine(a);
            var b = numbers.FindLastIndex(x => x < 10);
            Console.WriteLine(b);
            var c = numbers.IndexOf(5);
            Console.WriteLine(c);
            var d = numbers.LastIndexOf(1);
            Console.WriteLine(d);
            var e = numbers.BinarySearch(8);
            Console.WriteLine(e);

            numbers.Reverse();
            numbers.Reverse();
            numbers.Sort();
            

            Console.ReadLine();
        }
    }
}
