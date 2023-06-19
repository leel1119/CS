using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03_P137_ExtendingClass_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee accountant = new Employee();
            accountant.IdNum = 123;
            accountant.Salary = 30000.0;
            Console.WriteLine($"account IdNum : {accountant.IdNum} and Salary : {accountant.Salary}");

            CommissionEmployee sales = new CommissionEmployee();
            sales.IdNum = 123;
            sales.Salary = 30000.0;
            sales.CommissionRate = 0.07;
            Console.WriteLine($"{sales.GetGreeting()} and Salary : {sales.Salary} ane sles CommissionRate : {sales.CommissionRate}");

            Console.ReadLine();
        }
    }

    class Employee
    { 
        public int IdNum { get; set; } //Property,性質, Attribute,屬性
        public double Salary { get; set; }
        public string GetGreeting()
        { 
            return "Hello, I am Emply #" + IdNum;
        }
    }

    class CommissionEmployee : Employee
    {
        public double CommissionRate { get; set; }
    }
}
