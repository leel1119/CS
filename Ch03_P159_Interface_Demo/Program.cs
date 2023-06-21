using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03_P159_Interface_Demo
{
    public interface IWorkable 
    {
        string Work();
    }

    class Employee : IWorkable
    {
        public Employee(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
        public string Work() 
        {
            return "I do my Job";
        }
    }

    abstract class Animal : IWorkable
    { 
        public Animal(string name) { Name = name; }
        public string Name { get; set; }
        public abstract string Work();
    }

    class Dog : Animal
    { 
        public Dog(string name):base(name) { } // call parent Default CTOR
        public override string Work()
        {
            return "I watch the house";
        }
    }

    class Cat : Animal
    {
        public Cat(string name) : base(name) { }
        public override string Work()
        {
            return "I catch mice";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Employee bob = new Employee("Bob");
            Dog spot = new Dog("Spot");
            Cat puff = new Cat("Puff");
            Console.WriteLine($"Bob Name : {bob.Name} works : {bob.Work()}");
            Console.WriteLine($"spot.Name : {spot.Name} works : {spot.Work()}");
            Console.WriteLine($"puff.Name : {puff.Name} works : {puff.Work()}");
            Console.ReadLine();
        }
    }
}
