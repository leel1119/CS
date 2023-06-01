using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03_P89_Q1_Triangle_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i,j;

            for (i = 0; i < 5; i++)
            {
                for (j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("--------------------------------------------------");
            for (i = 0;i < 5; i++) 
            {
                for(j = 0; j < 5; j++) 
                {
                    if (j < (4-i))
                        Console.Write(" ");                    
                    else 
                        Console.Write("*");
                    
                }
                Console.WriteLine();
            }
            Console.WriteLine("--------------------------------------------------");
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    if (j < i)
                        Console.Write(" ");
                    else
                        Console.Write("*");

                }
                Console.WriteLine();
            }
            Console.WriteLine("--------------------------------------------------");
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    if (j < (5 - i))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
