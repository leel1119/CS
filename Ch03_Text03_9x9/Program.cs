using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03_Text03_9x9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int res;
            res = 0;
            Console.WriteLine("------------------------------------------------------");
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 2; j <= 5; j++)
                {
                    res = j * i;
                    Console.Write($"{j} x {i} = {res}   " + "\t");
                }
                Console.WriteLine(" ");

            }
            Console.WriteLine(" ");
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 6; j <= 9; j++)
                {
                    res = j * i;
                    Console.Write($"{j} x {i} = {res}   " + "\t");
                }
                Console.WriteLine(" ");

            }
            Console.ReadLine();
        }
    }
}
