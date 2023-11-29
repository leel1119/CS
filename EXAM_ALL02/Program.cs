using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM_ALL02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int sum = 0;
            do 
            {
                switch (i % 4)
                { 
                    case 0:
                    case 1:
                        sum += i * (i + 2) * (i + 4) * (i + 6);
                        break;
                    case 2:
                    case 3:
                        sum -= i * (i + 2) * (i + 4) * (i + 6);
                        break;
                }
                i++;
            }while (i <= 100);
            Console.WriteLine($"TotalSum = {sum}");
            Console.ReadLine();
        }
    }
}
