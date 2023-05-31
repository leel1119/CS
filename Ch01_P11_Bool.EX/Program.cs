using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch01_P11_Bool.EX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n0, n1;

            Console.WriteLine("Please input a number:n0");
            n0 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please input a number:n1");
            n1 = Convert.ToInt32(Console.ReadLine());

            bool res;
            res = n0 > n1;
            //Console.WriteLine($" {n0} > {n1} = {res}");
            Console.WriteLine($" {n0} > {n1} = {n0 > n1}");
            Console.WriteLine($" {n0} >= {n1} = {n0 >= n1}");
            Console.WriteLine($" {n0} < {n1} = {n0 < n1}");
            Console.WriteLine($" {n0} <= {n1} = {n0 <= n1}");
            Console.WriteLine($" {n0} == {n1} = {n0 == n1}");
            Console.WriteLine($" {n0} != {n1} = {n0 != n1}");
            Console.ReadLine();
        }
    }
}
