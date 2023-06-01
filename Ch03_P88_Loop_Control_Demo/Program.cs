using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03_P88_Loop_Control_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            i = 0;
            int sum = 10;
            for (i = 0; i < 10; i++) 
            {
                sum = sum + i;        
            }
            Console.WriteLine(sum);

            i = 0;
            sum = 10;
            do 
            {
                sum = sum + i;
                i++;
            } while (i < 10);
            Console.WriteLine(sum);

            i = 0;
            sum = 10;
            while (i < 10)
            { 
                sum = sum + i;
                i++;
            }
            Console.WriteLine(sum);

            //1+3+5+....+99 =?
            //2i+1是公式
            i= 0;
            sum = 0;
            for (i = 0;i < 50;i++) 
            {
                sum = sum + 2 * i + 1;
            }
            Console.WriteLine(sum);

            Console.ReadLine();
        }
    }
}
