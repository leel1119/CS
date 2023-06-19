using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03_P153_Abstract_Class_Medthod_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HourlyEmployee hEmp = new HourlyEmployee();
            GeneralEmployee gEmp = new GeneralEmployee();
            CS_Employee csEmp = new CS_Employee();

            hEmp.work();
            csEmp.work();
            gEmp.work();
            Console.ReadLine();
        }
    }
    abstract class Employee // for extending purpose;
    {
        public abstract void work();
        public virtual void vwork() { }
    }
    class HourlyEmployee : Employee
    {
        public override void work() 
        {
            Console.WriteLine("I am HourlyEmployee and I work Hourly!!!");
        }
    }
    class GeneralEmployee : Employee
    {
        public override void work()
        {
            Console.WriteLine("I am GeneralEmployee and I work Generally!!!");
        }
    }
    class CS_Employee : Employee
    {
        public override void work()
        {
            Console.WriteLine("I am C# Employee and I program C#!!!");
        }
        public override void vwork()
        {
            Console.WriteLine("I am C# Employee and I do virtually Logic Design Job!!!");
        }
    }


}
