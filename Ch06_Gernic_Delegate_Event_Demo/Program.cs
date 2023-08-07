using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06_Gernic_Delegate_Event_Demo
{
    delegate void EventHandDelegate<T, U, V>(T sender, U eventArgs, V price);

    internal class Program
    {
        static void Main(string[] args)
        {
            Publisher p = new Publisher();
            Subscriber s = new Subscriber();

            // 訂閱事件
            p.myEvent += s.AddedEventHandler;

            // 呼叫 Add 方法
            p.Add(10.23);
            Console.ReadLine();
        }
    }

    class Publisher
    {
        double price = 0;

        // 建立事件 myEvent，使用 EventHandDelegate 作為委派型別
        public event EventHandDelegate<Publisher, EventArgs, double> myEvent;

        public void Add(double addPrice)
        {
            price += addPrice;
            // 觸發事件 myEvent，傳遞相關參數
            myEvent(this, EventArgs.Empty, price);
        }
    }

    class Subscriber
    {
        // 事件處理方法
        public void AddedEventHandler(Publisher sender, EventArgs args, double price)
        {
            Console.WriteLine($"發生了 Added 事件！\n" +
                $"發送者：{sender}\n" +
                $"接收者：{this}\n" +
                $"事件引數：{args.ToString()}\n" +
                $"價格：{price}");
        }
    }
}
