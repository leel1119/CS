using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03_P22_PI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double PI = Math.PI; 
            int r ;
            r = 30;
            Console.WriteLine("圓周長為: " + r);
            Console.WriteLine("圓面積為: " + (PI * r * r));
            Console.Read();

        }
    }
}
