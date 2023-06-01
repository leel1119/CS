using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03_P71_Explicit_Casting_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 7;
            var res = 0.0; //res 必須為float否則下一行會出錯

            res = (float)a / b; //float 可以只在前面加入即可

            Console.WriteLine("result is :\"" + res.ToString("0.000") + "\"");
            Console.ReadLine();
        }
    }
}
