using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace Ch05_P61_Exception_EX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int km = 0;
            int gas = 0;
            int km_per_gas = 0;

            try
            {
                Console.WriteLine("Please input KM travelled: ");
                km = int.Parse(Console.ReadLine());
                Console.WriteLine("Please input gallon of gas used: ");
                gas = int.Parse(Console.ReadLine());
                km_per_gas = km / gas;
            }
            catch (Exception ex)
            {
                km_per_gas = 0;
                Console.WriteLine(ex.Message);
            }
            finally 
            {
                Console.WriteLine("Finally is executed absolutely");
                Console.WriteLine($"km er gas:{km_per_gas}");
            }

            Console.ReadLine();
        }
    }
}
