using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03_P93_All_QX_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 4; i++) 
            {
                for (int tri = 0; tri < 4-i; tri++)
                {
                    Console.Write(" ");
                }
                for (int sta = 0; sta < 2*i + 1 ; sta++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            for (int i = 1; i <= 4; i++)
            {
                for (int tri = 0; tri < i; tri++)
                {
                    Console.Write(" ");
                }
                for (int sta = 0; sta < 2 * (4 - i) + 1; sta++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}
