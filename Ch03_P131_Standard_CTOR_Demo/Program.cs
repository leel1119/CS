using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03_P131_Standard_CTOR_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empolyee aWorker = new Empolyee();
            Empolyee anotherWorker = new Empolyee(234, 45678);
            Empolyee theBoss = new Empolyee('A');
            Console.WriteLine($"aWorker ID is: {aWorker.IdNumber}, and Salary is: {aWorker.Salary}");
            Console.WriteLine($"anotherWorker ID is: {anotherWorker.IdNumber}, and Salary is: {anotherWorker.Salary}");
            Console.WriteLine($"theBoss ID is: {theBoss.IdNumber}, and theBoss is: {theBoss.Salary}");
            Console.ReadLine();
        }
    }
    class Empolyee
    {
        public int IdNumber { get; set; }
        public double Salary { get; set; }
        public Empolyee() : this(999, 0) { }
        public Empolyee(int empId) : this(empId, 0) { }
        public Empolyee(int empid, double salary)
        {
            IdNumber = empid;
            Salary = salary;
        }
        public Empolyee(char code) : this(111, 100000) { }
    }
}
