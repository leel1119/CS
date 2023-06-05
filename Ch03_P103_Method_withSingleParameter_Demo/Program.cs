using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03_P103_Method_withSingleParameter_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double cost_3C;
            cost_3C = 16800;

            double res;
            res = CalculateTax(cost_3C);
            Console.WriteLine("The tax need to pay is: " + res);
            Console.ReadLine();
        }
        private static double CalculateTax(double money)
        {
            double tax;
            const double RATE = 0.05;
            tax = money * RATE;
            return tax;
        }

    }
}
