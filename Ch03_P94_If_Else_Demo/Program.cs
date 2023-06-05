using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03_P94_If_Else_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = new Random().Next(5);
            /*
            if (x > 1) 
            {
                Console.WriteLine("Random Gen Num" + x + " > 1");
            }
            else 
            {
                Console.WriteLine("Random Gen Num" + x + " <= 1");
            }
            */
            string massage = x > 1 ? "Random Gen Num" + x + " > 1" : "Random Gen Num" + x + " <= 1";
            Console.WriteLine(massage);
            Console.ReadLine();
        }
    }
}
