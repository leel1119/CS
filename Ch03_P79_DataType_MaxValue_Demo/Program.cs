using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03_P79_DataType_MaxValue_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double half_d = Math.Pow(2, 30); //2的30次方
            int half_i = (int)half_d;
            int half_i1 = half_i - 1;
            int myInt32 = half_i + half_i1;
            Console.WriteLine("The Max Value of Type int :" + myInt32);
            int myInt32_Max = int.MaxValue;
            Console.WriteLine("The MaxValue provided Type is :" + myInt32_Max);
            myInt32 = myInt32 + 1;
            Console.WriteLine("The Min Value is :" + myInt32);
            int myInt32_Min = int.MinValue;
            Console.WriteLine("The Min Value is :" + myInt32_Min);
            //Console.ReadLine();

            //---------------------------------------------------------------------------------------------
            Console.WriteLine("//------------------------------------------------------------//");

            double half_dd = Math.Pow(2, 62); //2的62次方
            long half_l = (long)half_d;
            long half_l1 = half_l - 1;
            long myLong64 = half_l + half_l1;
            Console.WriteLine("The Max Value of Type long :" + myLong64);
            long myLong64_Max = long.MaxValue;
            Console.WriteLine("The MaxValue provided Type long is :" + myLong64_Max);
            myLong64 = myLong64 + 1;
            Console.WriteLine("The Min Value is :" + myLong64);
            long myLong64_Min = long.MinValue;
            Console.WriteLine("The Min Value is :" + myLong64_Min);
            Console.ReadLine();
        }
    }
}
