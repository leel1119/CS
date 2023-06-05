using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03_P108_PassArray_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] someNums = { 10, 21, 32, 45 };
            MethodGetOneInetValue(someNums);
            foreach (int i in someNums)
            {
                Console.WriteLine($"Each Element in Array : {i}");
            }
            Console.ReadLine();
        }

        private static void MethodGetOneInetValue(int[] theArray)
        {
            for (int idx=0; idx < theArray.Length; idx++)
            {
                Console.WriteLine($"Array Element In: {theArray[idx]}");
                theArray[idx] = 999;
                Console.WriteLine($"Array Element Out :{theArray[idx]}");

            }
        }
    }
}
