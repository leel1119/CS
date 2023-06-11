using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profit_commission
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Profit = 0;
            double ans = 0;
            Console.WriteLine("請輸入利潤:");
            Profit = Convert.ToInt32(Console.ReadLine());

            if (Profit <= 100000)
            {
                ans = Profit / 10;
                Console.WriteLine("可提抽成為:" + ans);
            }
            else if (100000 < Profit && Profit <= 200000)
            {
                ans = (Profit-100000) * 0.075 + (100000/10);
                Console.WriteLine("可提抽成為:" + ans);
            }
            else if (200000 < Profit && Profit <= 400000)
            {
                ans = (Profit - 200000) * 0.05 + 100000 * 0.075 + (100000 / 10);
                Console.WriteLine("可提抽成為:" + ans);
            }
            else 
            {
                ans = (Profit - 400000 ) * 0.03 + 200000 * 0.05 + 100000 * 0.075 + (100000 / 10);
                Console.WriteLine("可提抽成為:" + ans);
            }

            Console.ReadLine();


        }
    }
}
