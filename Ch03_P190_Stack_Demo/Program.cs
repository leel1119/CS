using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03_P190_Stack_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack<string>();
            stack.Push("Andy");
            stack.Push("Bill");
            stack.Push("Candy");
            stack.Push("David");
            stack.Push("Eric");

            ShowElement(stack);
            stack.Push("Frank");
            stack.Push("Garrady");
            Console.WriteLine($"Via Peek to observe Top Most Element, But not Remove it: {stack.Peek()}, Count:{stack.Count}");
            Console.WriteLine($"Via Peek to observe Top Most Element, But not Remove it: {stack.Pop()}, Count:{stack.Count}");
            ShowElement(stack);
            Console.ReadLine();
        }

        static void ShowElement(Stack<string> s)
        { 
            foreach (var e in s)
            {
                Console.Write($"{e,8}");
            }
            Console.WriteLine();
        }
    }
}
