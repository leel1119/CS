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

            int[] y = new int[] { 4, 5, 6 };
            Console.WriteLine($"x is :{y[0]} + {y[1]} + {y[2]}");

            int[] z = { 7, 8, 9 };
            Console.WriteLine($"x is :{z[0]} + {z[1]} + {z[2]}");

            Console.WriteLine("-----------------------------------------------");
            string[,] xx;
            xx = new string[2, 2];
            xx[0, 0] = "ABC"; xx[0, 1] = "def";
            xx[1, 0] = "123"; xx[1, 1] = "456";
            Console.WriteLine($"String XX is {xx[0, 0]} + {xx[0, 1]} + {xx[1, 0]} + {xx[1, 1]}");

            string[,] yy;
            yy = new string[,] {{"qwe", "456"},{"852", "zxc"} };
            Console.WriteLine($"String YY is {yy[0, 0]} + {yy[0, 1]} + {yy[1, 0]} + {yy[1, 1]}");

            string[,] zz = { { "qwe", "456" }, { "852", "zxc" } };
            Console.WriteLine($"String ZZ is {zz[0, 0]} + {zz[0, 1]} + {zz[1, 0]} + {zz[1, 1]}");

            Console.ReadLine();
        }
    }
}
