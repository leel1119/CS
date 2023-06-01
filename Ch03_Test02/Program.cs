using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03_Test02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int s;
            s=0;

            for (int i = 1; i <= 29; i = i+2) 
            {
                s = i * i;
                sum = sum + s;
            }
            Console.WriteLine(sum);

            int number = 1;
            double square;
            double total = 0;
            for (int i = 0;i < 15; i++) 
            {
                square = Math.Pow(number, 2);
                number = number + 2;
                total = total + square;
            }
            Console.WriteLine(total);

            Console.ReadLine();
        }
        
    }
}
