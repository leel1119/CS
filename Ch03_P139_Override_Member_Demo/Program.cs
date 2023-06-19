using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03_P139_Override_Member_Demo
{
   class Program
    {
        static void Main(string[] args)
        {
            Student payingStudent = new Student();
            ScholarshipStudent freeStudent = new ScholarshipStudent();

            payingStudent.Name = "Andy";
            payingStudent.Credits = 15;

            freeStudent.Name = "Bill";
            freeStudent.Credits = 18;

            Console.WriteLine($"payingStudent Name:{payingStudent.Name}, payingStudent Credits:{payingStudent.Credits}, payingStudent Tuition:{payingStudent.Tuition}");
            Console.WriteLine($"payingStudent Name:{freeStudent.Name}, payingStudent Credits:{freeStudent.Credits}, payingStudent Tuition:{freeStudent.Tuition}");
            Console.ReadLine();
        }
    }
    class Student
    {
        public string Name { get; set; }
        private const double Rate = 55.75;
        protected int credits;
        public virtual int Credits
        {
            get { return credits; }
            set { credits = value; tuition = credits * Rate; }
        }
        protected double tuition;
        public double Tuition
        {
            get { return tuition; }
        }

    }
    class ScholarshipStudent : Student
    {
        public override int Credits
        {
            set { credits = value; tuition = credits * 0; }
        }
    }
}
