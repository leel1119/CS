using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03_Text_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int res;
            res = 0;
            string str = "";
            for (int i = 1; i <= 99; i++)
            {
                res = res + (i * (i + 1));
                /*
                if (i<=98)
                    str += i + "*" + (i + 1) + "+";
                else
                    str += i + "*" + (i + 1) + "=";
                */
                str += (i < 98) ? i + "*" + (i + 1) + "+" : i + "*" + (i + 1) + "=";
            }
            Console.WriteLine(str + "anser is :" + res);
            Console.ReadLine();
        }
    }
}
