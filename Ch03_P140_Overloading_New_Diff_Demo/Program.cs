using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03_P140_Overloading_New_Diff_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee sales = new CommissionEmployee();
            sales.IdNum = 345;
            sales.Salary = 26500;
            Console.WriteLine(sales.GetGreeting());
            Console.WriteLine($" and sales Salary ; {sales.Salary}");
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
        public virtual string GetGreeting()
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
        public override string GetGreeting()
        {
            string str = null;
            str = base.GetGreeting();
            str += "\n Work on Commission";
            return str;
        }
    }
}
