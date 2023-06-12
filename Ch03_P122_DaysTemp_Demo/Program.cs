using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03_P122_DaysTemp_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            DaysTemp t1 = new DaysTemp();
            DaysTemp t2 = new DaysTemp();
            t1.Hight = 39;
            t1.Low = 27;
            t2.Hight = 40;
            t2.Low = 29;
            Console.WriteLine($"t1 Hight: {t1.Hight} , t1 Low: {t1.Low}, and t1 average is : {t1.Average()}");
            Console.WriteLine($"t2 Hight: {t2.Hight} , t2 Low: {t2.Low}, and t2 average is : {t2.Average()}");
            Console.ReadLine();

        }
    }
    class DaysTemp
    {
        public double Hight, Low;
        public double Average()
        {
            return (Hight + Low) / 2.0;
        }
    }
}
