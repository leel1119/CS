using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch3_P47_C_F_Temp_Trransforrm_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double C, F;
            Console.WriteLine("Please input F degree:");
            F = Convert.ToDouble(Console.ReadLine());
            C = (F - 32) * 5 / 9;
            Console.WriteLine("The Temperture C is :" + C);
            //Console.ReadLine();

            Console.WriteLine("Please input C degree:");
            C = Convert.ToDouble(Console.ReadLine());
            F = C * 9 / 5 + 32;
            Console.WriteLine("The Temperture F is :" + F);
            Console.ReadLine();
        }
    }
}
