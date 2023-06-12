using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03_P133_Object_init_Orders_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee aWorker = new Employee() 
            {
                IdNumber = 123,
            };
            Console.WriteLine($"Employee ID: {aWorker.IdNumber}, and Salary: {aWorker.Salary}");
            Console.ReadLine();

        }
    }
    class Employee
    {
        public int IdNumber { get; set; }
        public double Salary { get; set; }

        public Employee()
        {
            Salary = 34567.89;
            Console.WriteLine($"Employee ID: {IdNumber}, and Salary: {Salary}");
        }
    }
}
