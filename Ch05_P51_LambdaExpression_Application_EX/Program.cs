using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05_P51_LambdaExpression_Application_EX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("David");
            p.PrintName();
            p.Name = "Daniel";
            p.PrintName();
            Console.ReadLine();
        }
    }

    class Person
    { 
        private string name;
        public string Name
        { 
            //get { return name; } set { name = value; }
            get => name;
            set => name = value;
        }
        public Person(string n) => Name = n;
        public void PrintName() => Console.WriteLine(Name);
    }
}
