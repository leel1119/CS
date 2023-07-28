using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05_P48_Delegate_Practice
{
    delegate int DelType(int inp);
    internal class Program
    {
        static void Main(string[] args)
        {
            DelType dt;
            dt = new DelType(IntSquare);

            int res;
            res = dt(3);
            Console.WriteLine($"The Result is : {res} ");
            Console.ReadLine();
        }
        static int IntSquare(int input)
        {
            return input * input;
        }
    }
}
