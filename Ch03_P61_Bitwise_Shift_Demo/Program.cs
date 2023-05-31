using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03_P61_Bitwise_Shift_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0b0011_1100;//12*4+12=60
            int b = 0b0000_1111;//15
            int c = 0b0000_1100;//3
            int d = 0b0111_1000;//7*16+8=120
            int f = 0b0000_0011;//3
            int g = 0b0111_1000;//7*16+8=120
            int r;
            r = a & b;//0b0000_1100=12;
            Console.WriteLine("a & b =: " + r);

            r = a | b;//0b0011_1111=3*16+15=63;
            Console.WriteLine("a & b =: " + r);

            r = a ^ b;//0b0011_0011=3*16+3=51;
            Console.WriteLine("a & b =: " + r);

            Console.WriteLine("f = " + f);
            Console.WriteLine("f <<1 = " + (f<<1));
            Console.WriteLine("f >>2 = " + (f>>2));

            Console.ReadLine();

        }
    }
}
