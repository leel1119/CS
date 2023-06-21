using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03_Test07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var week = new List<string> { "Sun", "Man", "Tue", "Wed", "Thi", "Fri", "Sat" };

            week.Sort();  showElements(week);

            week.Reverse(); showElements(week);

            void showElements(List<string> weekElement)
            { 
                foreach (string e in weekElement) 
                {
                    Console.Write(e + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
