using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03_P193_Queue_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var queue = new Queue<string>();
            queue.Enqueue("Andy");
            queue.Enqueue("Bill");
            queue.Enqueue("Candy");
            queue.Enqueue("David");
            queue.Enqueue("Eric");

            ShowElement(queue);
            queue.Enqueue("Frank");
            queue.Enqueue("Garrady");
            Console.WriteLine($"Via Peek to observe Top Most Element, But not Remove it: {queue.Peek()}, Count:{queue.Count}");
            Console.WriteLine($"Via Peek to observe Top Most Element, But not Remove it: {queue.Dequeue()}, Count:{queue.Count}");
            ShowElement(queue);
            Console.ReadLine();
        }

        static void ShowElement(Queue<string> q)
        {
            foreach (var e in q)
            {
                Console.Write($"{e,8}");
            }
            Console.WriteLine();
        }
    }
}
