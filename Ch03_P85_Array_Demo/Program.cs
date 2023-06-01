using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03_P85_Array_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] x;
            x = new int[3];
            x[0] = 1;
            x[1] = 2;
            x[2] = 3;

            Console.WriteLine($"x is :{x[0]} + {x[1]} + {x[2]}");

            int[] y= new int[] {4,5,6};
            Console.WriteLine($"x is :{y[0]} + {y[1]} + {y[2]}");

            int[] z= {7,8,9};
            Console.WriteLine($"x is :{z[0]} + {z[1]} + {z[2]}");

            Console.ReadLine();
        }
    }
}
