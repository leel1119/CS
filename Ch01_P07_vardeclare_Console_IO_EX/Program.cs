using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch01_P07_vardeclare_Console_IO_EX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double db_num;
            int int_num;
            string str;

            Console.WriteLine("Please input a number:");
            db_num = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine($"The number is: {db_num} ");

            Console.WriteLine("Please input a number:");
            int_num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please input a number:");
            str = Console.ReadLine();

            Console.WriteLine($"Your input double number is : {db_num} ");
            Console.WriteLine($"Your input int number is : {int_num} ");
            Console.WriteLine($"Your input string is : {str} ");
            Console.ReadLine();
        }
    }
}
