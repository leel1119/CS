using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03_P107_PassArrayElementRef_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] someNums = { 10, 21, 32, 45 };
            MethodGetOneInetValue(ref someNums[0]);
            MethodGetOneInetValue(ref someNums[1]);
            MethodGetOneInetValue(ref someNums[2]);
            MethodGetOneInetValue(ref someNums[3]);
            foreach (int i in someNums)
            {
                Console.WriteLine($"Each Element in Array : {i}");
            }
            Console.ReadLine();
        }

        private static void MethodGetOneInetValue(ref int oneVal)
        {
            Console.WriteLine($"Parameter In: {oneVal}");
            oneVal = 999;
            Console.WriteLine($"Parameter In chane to :{oneVal}");
        }
    }
}
