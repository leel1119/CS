using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03_P126_Auto_Properties_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee aWorker = new Employee();
            aWorker.IdNumber = 2456;
            aWorker.Salary = 78.9;
            Console.WriteLine($"Empolyee {aWorker.IdNumber} earns {aWorker.Salary}");
            Console.ReadLine();
        }
    }
    class Employee
    { 
        public int IdNumber { get; set; }
        public double Salary { get; set; }
    }
}
