using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03_P134_Mutliplelnit_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee aWorker = new Employee() { IdNumber=456, Salary = 56789.12};
            Console.WriteLine($"aWorker ID: {aWorker.IdNumber}, and Salary : {aWorker.Salary}");
            Console.ReadLine();

        }
    }
    class Employee
    { 
        public int IdNumber { get; set; }
        public double Salary { get; set; }
    }
}
