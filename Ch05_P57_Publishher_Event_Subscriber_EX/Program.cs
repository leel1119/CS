using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05_P57_Publishher_Event_Subscriber_EX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Publisher p = new Publisher();
            Subscriber s = new Subscriber();
            Subscriber s2 = new Subscriber();

            p.Added += s.AddedEventHandler;
            p.Add(10);
            p.Added += s2.AddedEventHandler;
            p.Add(20);

            Console.ReadLine();
        }
    }
    class Publisher : ArrayList
    {
        public delegate void EventHandlerDeleggate(object sender, int index, int value);
        public event EventHandlerDeleggate Added;

        public override int Add(object value)
        { 
            int i = base.Add(value);
            if (Added != null) Added(this, i, (int)value);
            return i;
        }

        public override string ToString()
        {
            return "I am Publisher";
        }
    }
    class Subscriber
    { 
        public void AddedEventHandler(object sender, int index, int value) 
        {
            Console.WriteLine($"sender : {sender.ToString()}, receiver: {this.ToString()} + index: {index}, and vlaue: {value}");
        }
        public override string ToString()
        {
            return "I am Subscriber";
        }
    }

}
