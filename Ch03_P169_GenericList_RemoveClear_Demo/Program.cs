using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03_P169_GenericList_RemoveClear_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 13, 17, 19, 2, 3, 4, 7, 1, 1, 11 };

            numbers.Remove(1);               showElement();
            numbers.RemoveRange(2,3);        showElement();
            numbers.RemoveAll(e => e < 10);  showElement();   //lamba Expression
            numbers.RemoveAt(1);             showElement();
            numbers.Clear();                   showElement();
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
