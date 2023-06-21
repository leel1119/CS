using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03_P162_Generic_Method_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4, 5, 6, };
            double[] doubleArray = {1.1, 2.2, 3.3, 4.4, 5.5, 6.6, 7.7 };
            char[] charArray = { 'H', 'E', 'L', 'L', 'O' };

            DisplayArray(intArray);
            DisplayArray(doubleArray);
            DisplayArray(charArray);
            Console.Read();
        }
        /*
        static void DisplayArray(int[] inputArray)
        {
            foreach (int e in inputArray)
            {
                Console.Write($"e element is : {e} \t");
            }
                Console.WriteLine();
        }
        static void DisplayArray(double[] inputArray)
        {
            foreach (double e in inputArray)
            {
                Console.Write($"e element is : {e} \t");
            }
                Console.WriteLine();
        }
        static void DisplayArray(char[] inputArray)
        {
            foreach (char e in inputArray)
            {
                Console.Write($"e element is : {e} \t");
            }
                Console.WriteLine();
        }
        */
        //------------------------------------------------------------------------
        static void DisplayArray<T>(T[] inputArray) //Generic Method
        {
            foreach (T e in inputArray)
            {
                Console.Write($"e element is : {e} \t");
            }
            Console.WriteLine();
        }
    }
}
