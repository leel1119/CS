using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03_P119_Class_Object_Demo
{
    class Employee
    { 
        internal int idNumber;
        internal int salary;
        internal void WelcomeMessage()
        {
            Console.WriteLine($"Wellcome from Emplyee #{idNumber}");
            Console.WriteLine("How can I help you?");
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();//Default CTOR, compiler auto create 內定建構子
            emp.idNumber = 234;
            emp.salary = 45000;
            emp.WelcomeMessage();
            Console.WriteLine($"Salary: {emp.salary}, and ID: {emp.idNumber}");
            Console.ReadLine();
        }
    }
}
