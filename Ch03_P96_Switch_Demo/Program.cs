using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03_P96_Switch_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = new Random().Next(4);
            switch (x) 
            {
                case 0:
                    Console.WriteLine($"{x} is 0");
                    break;
                case 1:
                    Console.WriteLine($"{x} is 1");
                    break;
                case 2:
                    Console.WriteLine($"{x} is 2");
                    break;
                default:
                    Console.WriteLine($"{x} is 3");
                    break;
            }
            Console.ReadLine();
        }
    }
}
