using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03_P138_Protected_Attribute_Demo
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
            sales.Salary = 20000.0;
            sales.CommissionRate = 0.07;
            Console.WriteLine($"{sales.GetGreeting()} and Salary : {sales.Salary} ane sles CommissionRate : {sales.CommissionRate}");

            Console.ReadLine();
        }
    }

    class Employee
    {
        public int IdNum { get; set; } //Property,性質, Attribute,屬性
        protected double salary;
        public double Salary
        {
            get { return salary; }
            set { salary = (value < 15000) ? 15000 : value; } 
        }
        public string GetGreeting()
        {
            return "Hello, I am Emply #" + IdNum;
        }
    }

    class CommissionEmployee : Employee
    {
        private double commissionRate;
        public double CommissionRate 
        {
            get { return commissionRate; }
            set { commissionRate = 0; salary = 0; } 
        }
    }
}
