
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06_Gernic_Delegate_Event_Demo
{
    delegate void EventHandDelegate<T,U,V>(T sender, U eventArgs, V price);
    internal class Program
    {
        static void Main(string[] args)
        {
            Publisher p = new Publisher();
            Subscriber s = new Subscriber();
            p.myEvent += s.AddedEventHandler;
            p.Add(10.23);
            Console.ReadLine();
        }
    }
    class Publisher
    {
        double price = 0;
        public event EventHandDelegate<Publisher, EventArgs, double> myEvent;
        public void Add(double addPrice)
        { 
            price += addPrice;
            myEvent(this, EventArgs.Empty, price);  
        }
    }
    class Subscriber
    { 
        public void AddedEventHandler(Publisher sender, EventArgs args, double price)
        {
            Console.WriteLine($"Added Event occured! sender:{sender} \n" +
                $"receiver:{this}\n" +
                $"with args:{args.ToString()}\n" +
                $"And Price:{price}");
        }
    }
}
