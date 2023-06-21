using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03_P165_IComparable_GenericMethod_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( $"Max is : {maximun(3, 4, 5)}");
            Console.ReadLine();
        }
        static T maximun<T>(T x, T y, T z) where T : IComparable<T>
        {
            T max;
            max = x;
            if (y.CompareTo(max) > 0) max = y;
            if (z.CompareTo(max) > 0) max = z;
            return max;
        }
    }
}
