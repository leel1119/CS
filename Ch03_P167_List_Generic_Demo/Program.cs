using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03_P167_List_Generic_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> { 1, 2, 3 };            showElement();
            numbers.Add(5);                                     showElement();
            numbers.AddRange(new int[] { 7, 11 });              showElement();
            numbers.Insert(5, 1);                               showElement();
            numbers.InsertRange(1, new int[] { 13, 17, 19 });   showElement();
            Console.ReadLine();

            void showElement()
            { 
                foreach (var e in numbers) 
                {
                    Console.Write(e + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
