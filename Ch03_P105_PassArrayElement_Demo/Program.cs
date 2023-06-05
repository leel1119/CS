using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03_P105_PassArrayElement_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] someNums = { 10, 21, 32, 45 };
            MethodGetOneInetValue(someNums[0]);
            MethodGetOneInetValue(someNums[1]);
            MethodGetOneInetValue(someNums[2]);
            MethodGetOneInetValue(someNums[3]);
            foreach (int i in someNums) 
            {
                Console.WriteLine($"Each Element in Array : {i}");
            }
            Console.ReadLine();
        }

        private static void MethodGetOneInetValue(int oneVal)
        {
            Console.WriteLine($"Parameter In: {oneVal}");
            oneVal = 999;
            Console.WriteLine($"Parameter In chane to :{oneVal}");
        }
    }
}
