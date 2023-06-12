using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03_P125_Creating_Property_Demo
{
    class Employee
    {
        private int idNumber; //instance attribut
        public int Idnumber
        { 
            get { return idNumber; } 
            set { idNumber = value; }
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee myChef = new Employee();
            myChef.Idnumber = 2345; //setter property
            Console.WriteLine($"The IdNumber of myChef: {myChef.Idnumber}"); //getter property
            Console.ReadLine();

        }
    }
}
