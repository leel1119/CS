using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03_P155_Pass_Abstract_Object_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog spot = new Dog("Spot");
            Cat puff = new Cat("Puff");
            spot.Speak();
            puff.Speak();

            Animal_Speak(spot);
            Animal_Speak(puff);

            Console.ReadLine();
        }
        static void Animal_Speak(Animal ani) //upcating
        { 
            ani.Speak(); //Last Binding
        }

    }

    abstract class Animal
    { 
        public string Name { get; }
        public Animal(string name)
        {
            Name = name;
        }
        public abstract void Speak();
    }
    class Dog : Animal
    {
        public Dog(string name) : base(name) { }
        public override void Speak()
        {
            Console.WriteLine("Dog Speak as : woof");
        }
    }
    class Cat : Animal
    {
        public Cat(string name) : base(name) { }
        public override void Speak() 
        {
            Console.WriteLine("Cat Speak as : meow");
        }
    }


}
