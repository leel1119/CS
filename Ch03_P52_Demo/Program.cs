using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03_P52_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 20;
            int y;
            y = x++;
            Console.WriteLine("x=" + x + "and y="+y);
            //Console.ReadLine();

            x = y++;
            Console.WriteLine("x=" + x + "and y=" + y);
            Console.ReadLine();

        }
    }
}
