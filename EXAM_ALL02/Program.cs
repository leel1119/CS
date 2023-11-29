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
            int j = 1;
            int oddPositive = 0, oddNagtive = 0, oddSum = 0;
            int evenPositive = 0, evenNagtive = 0, evenSum = 0;
            while ((2 * i - 1) < 100)
            {
                oddPositive= (2 * i - 1) * (2 * (i + 1) - 1) * (2 * (i + 2) - 1) * (2 * (i + 3) - 1);
                oddNagtive = (2 * (i+1) - 1) * (2 * (i + 2) - 1) * (2 * (i + 3) - 1) * (2 * (i + 4) - 1);
                oddSum = oddPositive - oddNagtive;
                i = i + 2;

            }
            while (2 * j <= 100)
            {
                evenNagtive = (2 * j) * (2 * (j + 1)) * (2 * (j + 2)) * (2 * (j + 3));
                evenPositive = (2 * (j + 1)) * (2 * (j + 2)) * (2 * (j + 3)) * (2 * (j + 4));
                evenSum = evenNagtive + evenPositive;
                j = j + 2;
            }
            Console.WriteLine($"oddSum = {oddSum}, evenSum = {evenSum}");
            Console.WriteLine($"TotalSum = {oddSum - evenSum}");
            Console.ReadLine();
        }
    }
}
