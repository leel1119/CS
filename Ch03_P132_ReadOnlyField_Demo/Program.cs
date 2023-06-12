using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03_P132_ReadOnlyField_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee myAssistant = new Employee(3456);
            Employee myDriver = new Employee(4321);
            //myAssistant.IdNumber = 6543;
            Console.WriteLine($"myAssistant ID : {myAssistant.IdNumber}");
            Console.WriteLine($"myDriver ID : {myDriver.IdNumber}");
            Console.ReadLine();
        }
    }
    class Employee
    {
        private readonly int idNumber;
        //private int idNumber;
        public int IdNumber
        {
            get { return idNumber; }
            //set { idNumber = value; } //readonly 導致無法set
        }
        public Employee(int id)
        {
            idNumber = id;
        }
    }
}
