using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch01_P09_Arithmetic_EX
{
    internal class Program
    {
        static void Main(string[] args)
        {   /*
            int n0, n1;
            int sum, diff, product, div, rem;

            Console.WriteLine("Please input a number:n0");
            n0 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please input a number:n1");
            n1 = Convert.ToInt32(Console.ReadLine());
            */
            double n0, n1;
            double sum, diff, product, div ;//rem;

            Console.WriteLine("Please input a number:n0");
            n0 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please input a number:n1");
            n1 = Convert.ToDouble(Console.ReadLine());

            sum = n0 + n1;
            diff = n0 - n1;
            product = n0 * n1;
            div = n0 / n1;
            //rem = n0 % n1;

            Console.WriteLine($"n0 + n1 is equal to {sum}");
            Console.WriteLine($"n0 - n1 is equal to {diff}");
            Console.WriteLine($"n0 * n1 is equal to {product}");
            Console.WriteLine($"n0 / n1 is equal to {div}");
            //Console.WriteLine($"n0 % n1 is equal to {rem}");
            Console.ReadLine();
        }
    }
}
