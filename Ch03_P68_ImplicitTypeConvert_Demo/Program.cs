using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03_P68_ImplicitTypeConvert_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float fValue;
            int iNum = 125;
            int iValue = 456;

            long lValue;

            lValue = iValue;
            Console.WriteLine("lValue = " + lValue +"\n" + "iValue= " + iValue);
            
            fValue = iNum + 123.45f;
            Console.WriteLine("fValue = " +  fValue);
            Console.ReadLine();
        }
    }
}
