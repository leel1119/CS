using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03_P157_Abstract_Property_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Emp = new HourlyEmployee("Henrry");  // Default CTOR
            Console.WriteLine($"HourlyEmployee Name is : {Emp.Name}");
            Console.ReadLine();
        }
    }

    abstract class Employee  // Abstract Class
    { 
        public abstract string Name { get;}
    }

    class HourlyEmployee : Employee // Concrete Class
    {
        public override string Name { get; }
        public HourlyEmployee(String name) // Standard CTOR
        {
            Name = name;
        }

        public HourlyEmployee() { } //Default CTOR
    }


}
