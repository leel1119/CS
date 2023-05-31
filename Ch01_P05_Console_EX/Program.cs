using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch01_P05_Console_EX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n0 = 20.5;
            double n1;
            n1 = 30.65;
            double res;
            res = n0 + n1;

            //Console.WriteLine("The n0 is:{0}, and the n1 is:{1}",n0,n1);
            //Console.WriteLine("and n1+n2 is:{0}",res);
            Console.WriteLine($"The n0 is:{n0}, and the n1 is:{n1}");
            Console.WriteLine($"and n1+n2 is:{res}");

            Console.ReadLine();
        }
    }
}
