using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03_P95_Foreach_Break_Continue_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, };
            foreach (int i in a) 
            {
                if (i == 8) break;
                if (i == 4) continue;
                Console.Write(i);
            }
            Console.ReadLine();
        }
    }
}
