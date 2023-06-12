using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03_P123_PassObjects_toMethod_Demo
{
    class Employee
    {
        private int idNamber;           //instance attribute 實例屬性
        public void WelcomeMessage()    //instance method; 實例方法
        {
            Console.WriteLine($"Welcome from Employee #{idNamber}");
            Console.WriteLine("How can I help you?");
        }
        static void DsiplayEmpolyeeData(string order, Employee emp)
        { 
            Console.WriteLine($"\nFrom {order} employee msg");
            emp.WelcomeMessage();
        }
        static void Main(string[] args)
        {
            Employee aWorker = new Employee();
            Employee anotherWorkker = new Employee();
            Employee.DsiplayEmpolyeeData("First", aWorker);
            Employee.DsiplayEmpolyeeData("Second", anotherWorkker);
            Console.ReadLine();
        }
    }
}
