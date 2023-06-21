using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03_P171_Generic_Find_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 5, 7, 11 }; 

            var a = numbers.Find(e => e < 10);
            Console.WriteLine(a);

            var b = numbers.FindLast(e => e < 10);
            Console.WriteLine(b);

            var c = numbers.FindAll(e => e < 10);
            showElements(c);

            Console.Read();

            void showElements(List<int>input)
            {
                foreach (var e in input)
                {
                    Console.Write(e + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
